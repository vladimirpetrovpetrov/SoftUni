namespace Medicines.DataProcessor
{
    using Medicines.Data;
    using Medicines.Data.Models.Enums;
    using Medicines.DataProcessor.ExportDtos;
    using Newtonsoft.Json;
    using System.Globalization;
    using System.Text;
    using System.Xml.Serialization;
    using System.Xml;
    using Medicines.Data.Models;

    public class Serializer
    {
        public static string ExportPatientsWithTheirMedicines(MedicinesContext context, string date)
        {
            if (DateTime.TryParseExact(date, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
            {
                var patients = context.Patients
                    .Where(p => p.PatientsMedicines.Any(pm => pm.Medicine.ProductionDate > parsedDate))
                    .OrderByDescending(p => p.PatientsMedicines.Count(pm => pm.Medicine.ProductionDate > parsedDate))
                    .ThenBy(p => p.FullName)
                .Select(p => new ExportPatientDto
                {
                    Gender = p.Gender.ToString().ToLower(),
                    Name = p.FullName,
                    AgeGroup = p.AgeGroup.ToString(),
                    Medicines = p.PatientsMedicines
                        .Where(pm => pm.Medicine.ProductionDate > parsedDate)
                        .OrderByDescending(pm => pm.Medicine.ExpiryDate)
                        .ThenBy(pm => pm.Medicine.Price)
                        .Select(pm => new ExportMedicineDto
                        {
                            Category = pm.Medicine.Category.ToString().ToLower(),
                            Name = pm.Medicine.Name,
                            Price = pm.Medicine.Price.ToString("F2", CultureInfo.InvariantCulture),
                            Producer = pm.Medicine.Producer,
                            BestBefore = pm.Medicine.ExpiryDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)
                        })
                        .ToArray()
                })
                .ToArray();


                var serializer = new XmlSerializer(typeof(ExportPatientDto[]), new XmlRootAttribute("Patients"));
                var sb = new StringBuilder();

                var xns = new XmlSerializerNamespaces();
                xns.Add(string.Empty, string.Empty);

                using (var writer = new StringWriter(sb))
                {
                    serializer.Serialize(writer, patients, xns);
                }

                return sb.ToString().Trim();




            }
            else
            {
                return "";
            }





        }

        public static string ExportMedicinesFromDesiredCategoryInNonStopPharmacies(MedicinesContext context, int medicineCategory)
        {
            var medicines = context.Medicines
                .Where(m => m.Category == (Category)medicineCategory && m.Pharmacy.IsNonStop)
                .ToArray()
                .OrderBy(m => m.Price)
                .ThenBy(m => m.Name)
                .Select(m => new
                {
                    Name = m.Name,
                    Price = m.Price.ToString("F2", CultureInfo.InvariantCulture),
                    Pharmacy = new
                    {
                        Name = m.Pharmacy.Name,
                        PhoneNumber = m.Pharmacy.PhoneNumber
                    }
                })
                .ToList();

            return JsonConvert.SerializeObject(medicines, Newtonsoft.Json.Formatting.Indented);
        }
    }
}
