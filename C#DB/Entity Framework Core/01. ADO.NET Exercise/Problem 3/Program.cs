using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System.Text;

namespace Problem_3
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string connectionString = @"Server=DESKTOP-3APE4MB;Database=MinionsDB;Integrated Security=True;TrustServerCertificate=True";
            await using SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            Console.WriteLine("Connection established");
            int villainId = int.Parse(Console.ReadLine());
            var result = await GetVillainWithAllMinionsByIdAsync(connection, villainId);
            Console.WriteLine(result);
        }



        static async Task<string> GetVillainWithAllMinionsByIdAsync(SqlConnection connection, int villanId)
        {
            StringBuilder st = new StringBuilder();
            const string GetVillainNameById = @"SELECT Name FROM Villains WHERE Id = @Id";

            SqlCommand getVillainById = new SqlCommand(GetVillainNameById, connection);
            getVillainById.Parameters.AddWithValue("@Id", villanId);
            object? villainNameObj = await getVillainById.ExecuteScalarAsync();
            if (villainNameObj == null)
            {
                return $"No villain with ID {villanId} exists in the database.";
            }
            string villanName = (string)villainNameObj;
            st.AppendLine($"Villain: {villanName}");
            //Till now we know if the Villain with this Id exist and if he exist we know his name
            const string GetAllMinionsByVillainId = @"SELECT ROW_NUMBER() OVER (ORDER BY m.Name) AS RowNum,
                                         m.Name, 
                                         m.Age
                                    FROM MinionsVillains AS mv
                                    JOIN Minions As m ON mv.MinionId = m.Id
                                   WHERE mv.VillainId = @Id
                                ORDER BY m.Name";
            SqlCommand getAllMinionsCommand = new SqlCommand(GetAllMinionsByVillainId, connection);
            getAllMinionsCommand.Parameters.AddWithValue("@Id", villanId);
            SqlDataReader reader = await getAllMinionsCommand.ExecuteReaderAsync();
            if (!reader.HasRows)
            {
                st.AppendLine("(no minions)");
            }
            else
            {
                while (reader.Read())
                {
                    long rowNum = (long)reader["RowNum"];
                    string name = (string)reader["Name"];
                    int age = (int)reader["Age"];
                    st.AppendLine($"{rowNum}. {name} {age}");
                }
            }
            return st.ToString().TrimEnd();
        }
    }
}