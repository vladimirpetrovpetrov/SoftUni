namespace Medicines.DataProcessor
{
    using Medicines.Data;
    using Medicines.Data.Models;
    using Medicines.Data.Models.Enums;
    using Medicines.DataProcessor.ImportDtos;
    using Newtonsoft.Json;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.Text;
    using System.Xml.Serialization;

    public class Deserializer
    {
        private const string ErrorMessage = "Invalid Data!";
        private const string SuccessfullyImportedPharmacy = "Successfully imported pharmacy - {0} with {1} medicines.";
        private const string SuccessfullyImportedPatient = "Successfully imported patient - {0} with {1} medicines.";

        public static string ImportPatients(MedicinesContext context, string jsonString)
        {
            int[] medIds = context.Medicines.Select(x => x.Id).ToArray();
            var patientsDtos = JsonConvert.DeserializeObject<ImportPatientDto[]>(jsonString);

            var sb = new StringBuilder();

            List<Patient> patients = new List<Patient>();

            foreach (var pDto in patientsDtos)
            {
                if (!IsValid(pDto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var patient = new Patient()
                {
                    FullName = pDto.FullName,
                    AgeGroup = pDto.AgeGroup,
                    Gender = pDto.Gender
                };

                foreach (var medicineId in pDto.Medicines)
                {
                    if (medIds.Contains(medicineId) && !patient.PatientsMedicines.Any(pm => pm.MedicineId == medicineId))
                    {
                        patient.PatientsMedicines.Add(new PatientMedicine()
                        {
                            MedicineId = medicineId
                        });
                    }
                    else
                    {
                        sb.AppendLine(ErrorMessage);
                    }
                }
                patients.Add(patient);
                sb.AppendLine(string.Format(SuccessfullyImportedPatient,patient.FullName,patient.PatientsMedicines.Count));
            }
            context.AddRange(patients);
            context.SaveChanges();

            return sb.ToString().Trim();
        }

        public static string ImportPharmacies(MedicinesContext context, string xmlString)
        {

            XmlSerializer serializer = new XmlSerializer(typeof(ImportPharmacyDto[]), new XmlRootAttribute("Pharmacies"));

            ImportPharmacyDto[] pDtos = (ImportPharmacyDto[])serializer.Deserialize(new StringReader(xmlString));

            var sb = new StringBuilder();

            List<Pharmacy> pharmacies = new();

            foreach (var pDto in pDtos)
            {

                if (!IsValid(pDto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                if (!bool.TryParse(pDto.IsNonStop, out bool isNonStopResult))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var pToAdd = new Pharmacy()
                {
                    IsNonStop = isNonStopResult,
                    Name = pDto.Name,
                    PhoneNumber = pDto.PhoneNumber
                };

                var validMedicines = new List<Medicine>();

                foreach (var medicineDto in pDto.Medicines)
                {
                    if (!IsValid(medicineDto))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    if (!DateTime.TryParseExact(medicineDto.ProductionDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime productionDateResult))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    if (!DateTime.TryParseExact(medicineDto.ExpiryDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime expiryDateResult))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    if (productionDateResult >= expiryDateResult)
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    var medicine = new Medicine
                    {
                        Category = (Category)medicineDto.Category,
                        Name = medicineDto.Name,
                        Price = medicineDto.Price,
                        ProductionDate = productionDateResult,
                        ExpiryDate = expiryDateResult,
                        Producer = medicineDto.Producer
                    };



                    if (!validMedicines.Any(m => m.Name == medicine.Name && m.Producer == medicine.Producer))
                    {
                        validMedicines.Add(medicine);
                    }
                    else
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                }
                pToAdd.Medicines = validMedicines;
                pharmacies.Add(pToAdd);

                sb.AppendLine($"Successfully imported pharmacy - {pToAdd.Name} with {pToAdd.Medicines.Count} medicines.");
            }
            context.AddRange(pharmacies);
            context.SaveChanges();


            return sb.ToString().Trim();
        }

        private static bool IsValid(object dto)
        {
            var validationContext = new ValidationContext(dto);
            var validationResult = new List<ValidationResult>();

            return Validator.TryValidateObject(dto, validationContext, validationResult, true);
        }
    }
}
