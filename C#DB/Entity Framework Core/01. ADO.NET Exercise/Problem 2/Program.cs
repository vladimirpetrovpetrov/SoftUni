using _2._Villain_Names;
using Microsoft.Data.SqlClient;
using System.Text;

await using SqlConnection connection = new SqlConnection(Config.ConnectionString);

await connection.OpenAsync();
SqlCommand sqlCommand = new SqlCommand(SqlStorage.VillainNames,connection);


//Problem 2
//One row many columns
SqlDataReader reader = await sqlCommand.ExecuteReaderAsync();
StringBuilder st = new StringBuilder(); 
while (reader.Read())
{
    string villainName = (string)reader["Name"];
    int minionsCount = (int)reader["MinionsCount"];

    st.AppendLine($"{villainName} - {minionsCount}");
}
Console.WriteLine(st.ToString().TrimEnd('\n'));

