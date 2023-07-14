namespace Box
{
    public class Program
    {
        static void Main(string[] args)
        {
            var length = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            try
            {
                Box box = new Box(length, width, height);
                box.CalculateSurfaceArea();
                box.CalculateLateralSurfaceArea();
                box.CalculateVolume();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            
            
        }
    }
}