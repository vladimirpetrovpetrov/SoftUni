using Microsoft.Data.SqlClient;
using System.Text;

namespace Problem_4
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string connectionString = @"Server=DESKTOP-3APE4MB;Database=MinionsDB;Integrated Security=True;TrustServerCertificate=True";
            await using SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            Console.WriteLine("Connection established");
            string[] minionInfo = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] villainName = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            var result = await AddNewMinionASync(connection, minionInfo[1], villainName[1]);
            Console.WriteLine(result);
        }

        static async Task<string> AddNewMinionASync(SqlConnection connection, string miniongInfo, string villainName)
        {
            StringBuilder st = new StringBuilder();
            string[] minionArgs = miniongInfo.Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();

            string mName = minionArgs[0];
            int mAge = int.Parse(minionArgs[1]);
            string mTownName = minionArgs[2];
            string vName = villainName;
            try
            {
                int townId = await GetTownIdAsync(connection, st, mTownName);
                int villainId = await GetVillainIdAsync(connection, st, vName);
                await AddMinion(connection, mName, mAge, townId);
                int minionId = await GetMinionId(connection, mName);
                await AddMinionIdAndVillainId(connection, st, mName, vName, villainId, minionId);

            }
            catch (Exception e)
            {
            }

            return st.ToString().TrimEnd();




        }

        private static async Task AddMinionIdAndVillainId(SqlConnection connection, StringBuilder st, string mName, string vName, int villainId, int minionId)
        {
            const string AddMinionIdAndVillainIdSql = @"INSERT INTO MinionsVillains (MinionId, VillainId) VALUES (@minionId, @villainId)";
            SqlCommand addMinionIdVillainId = new SqlCommand(AddMinionIdAndVillainIdSql, connection);
            addMinionIdVillainId.Parameters.AddWithValue("@minionId", minionId);
            addMinionIdVillainId.Parameters.AddWithValue("@villainId", villainId);
            await addMinionIdVillainId.ExecuteNonQueryAsync();
            st.AppendLine($"Successfully added {mName} to be minion of {vName}.");
        }

        private static async Task<int> GetMinionId(SqlConnection connection, string mName)
        {
            const string GetMinionIdSql = @"SELECT Id FROM Minions WHERE Name = @Name";
            SqlCommand getMinionId = new SqlCommand(GetMinionIdSql, connection);
            getMinionId.Parameters.AddWithValue("@Name", mName);
            int minionId = (int)await getMinionId.ExecuteScalarAsync();
            return minionId;
        }

        private static async Task AddMinion(SqlConnection connection, string mName, int mAge, int townId)
        {
            const string InsertMinionSql = @"INSERT INTO Minions (Name, Age, TownId) VALUES (@name, @age, @townId)";
            SqlCommand insertMinion = new SqlCommand(InsertMinionSql, connection);
            insertMinion.Parameters.AddWithValue("@name", mName);
            insertMinion.Parameters.AddWithValue("@age", mAge);
            insertMinion.Parameters.AddWithValue("@townId", townId);
            await insertMinion.ExecuteNonQueryAsync();
        }

        private static async Task<int> GetVillainIdAsync(SqlConnection connection, StringBuilder st, string vName)
        {
            const string checkIfVillainExistSql = @"SELECT Id FROM Villains WHERE Name = @Name";
            SqlCommand checkVillain = new SqlCommand(checkIfVillainExistSql, connection);
            checkVillain.Parameters.AddWithValue("@Name", vName);
            object? villanIdObj = await checkVillain.ExecuteScalarAsync();
            if (villanIdObj == null)
            {
                const string InsertVillainSql = @"INSERT INTO Villains (Name, EvilnessFactorId)  VALUES (@villainName, 4)";
                SqlCommand insertVillain = new SqlCommand(InsertVillainSql, connection);
                insertVillain.Parameters.AddWithValue("@villainName", vName);
                await insertVillain.ExecuteNonQueryAsync();
                villanIdObj = await checkVillain.ExecuteScalarAsync();
                st.AppendLine($"Villain {vName} was added to the database.");
            }
            return (int)villanIdObj!;
        }

        private static async Task<int> GetTownIdAsync(SqlConnection connection, StringBuilder st, string mTownName)
        {
            const string checkIfCityExistSql = @"SELECT Id FROM Towns WHERE Name = @townName";
            SqlCommand checkCity = new SqlCommand(checkIfCityExistSql, connection);
            checkCity.Parameters.AddWithValue("@townName", mTownName);
            object? townIdObj = await checkCity.ExecuteScalarAsync();
            if (townIdObj == null)
            {
                const string addTown = @"INSERT INTO Towns (Name) VALUES (@townName)";
                SqlCommand insertTown = new SqlCommand(addTown, connection);
                insertTown.Parameters.AddWithValue("@townName", mTownName);
                await insertTown.ExecuteNonQueryAsync();
                townIdObj = await checkCity.ExecuteScalarAsync();
                st.AppendLine($"Town {mTownName} was added to the database.");
            }

            return (int)townIdObj!;
        }
    }
}