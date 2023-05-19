using P01_HospitalDatabase.Data;

namespace P01_HospitalDatabase;

public class Program
{
    public static void Main(string[] args)
    {
        HospitalContext context = new HospitalContext();
        context.Database.EnsureDeleted();
        context.Database.EnsureCreated();

    }
}