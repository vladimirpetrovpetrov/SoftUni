namespace PizzaCalories;

public class Program
{
    static void Main()
    {
        var pizzaInput = Console.ReadLine().Split(" ");
		try
		{
            Pizza pizza = new Pizza(pizzaInput[1]);
            var doughInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            try
            {
                Dough dough = new Dough(doughInput[1], doughInput[2], double.Parse(doughInput[3]));
                pizza.Dough = dough;

                var toppingInput = Console.ReadLine();
                while(toppingInput != "END") 
                {
                    var topInfo = toppingInput.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    try
                    {
                        Topping topping = new Topping(topInfo[1], double.Parse(topInfo[2]));
                        try
                        {
                            pizza.AddTopping(topping);
                        }
                        catch (Exception ex)
                        {

                            Console.WriteLine(ex.Message);
                            return;
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        return;
                    }
                    toppingInput= Console.ReadLine();


                }
                Console.WriteLine(pizza);





            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return;
            }
        }
		catch (Exception ex)
		{

            Console.WriteLine(ex.Message);
            return;
		}
        
        

		


    }
}