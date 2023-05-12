using Microsoft.Data.SqlClient;
using System.Text;

namespace Problem_5
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string connectionString = @"Server=DESKTOP-3APE4MB;Database=MinionsDB;Integrated Security=True;TrustServerCertificate=True";
            await using SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            Console.WriteLine("Connection established");
            string countryName = Console.ReadLine();
            string result = await GetAllChangedCitiesInCountry(connection, countryName);
            Console.WriteLine(result);
        }

        private static async Task<string> GetAllChangedCitiesInCountry(SqlConnection connection, string countryName)
        {
            StringBuilder st = new StringBuilder();

            const string UpdateTownsInCountrySQL =
                @"UPDATE Towns
                SET Name = UPPER(Name)
                WHERE CountryCode = (SELECT c.Id FROM Countries AS c WHERE c.Name = @countryName)";
            SqlCommand updateTownsInCountry = new SqlCommand(UpdateTownsInCountrySQL, connection);
            updateTownsInCountry.Parameters.AddWithValue("@countryName", countryName);
            var changedTowns = await updateTownsInCountry.ExecuteNonQueryAsync();
            if (changedTowns == 0)
            {
                return "No town names were affected.";
            }
            else
            {
                st.AppendLine($"{changedTowns} town names were affected.");
                const string GetAllCitiesFromCountry = @"SELECT t.Name 
                                                           FROM Towns as t
                                                           JOIN Countries AS c ON c.Id = t.CountryCode
                                                          WHERE c.Name = @countryName";
                SqlCommand getCities = new SqlCommand(GetAllCitiesFromCountry, connection);
                getCities.Parameters.AddWithValue("@countryName", countryName);
                SqlDataReader reader = await getCities.ExecuteReaderAsync();
                List<string> cities = new List<string>();
                while (reader.Read())
                {
                    string city = (string)reader["Name"];
                    cities.Add(city);
                }
                st.AppendLine($"[{String.Join(", ", cities)}]");
                return st.ToString().TrimEnd();
            }
        }
    }
}