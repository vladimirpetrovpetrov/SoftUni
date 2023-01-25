
                //FIX THE CODE

//double dul, sh, V = 0;
//Console.WriteLine("Length: ");
//dul = double.Parse(Console.ReadLine());
//Console.WriteLine("Width: ");
//sh = double.Parse(Console.ReadLine());
//Console.WriteLine("Heigth: ");
//V = double.Parse(Console.ReadLine());
//V = (dul + sh + V) / 3;
//Console.WriteLine($"Pyramid Volume: {V:f2}");



double length = double.Parse(Console.ReadLine()!);
double width = double.Parse(Console.ReadLine()!);
double height = double.Parse(Console.ReadLine()!);

double volume = (length * width * height) / 3.00;
Console.WriteLine($"Length: Width: Height: Pyramid Volume: {volume:f2}");
