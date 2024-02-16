Console.Write("Въведете тегло (в кг):");

int weight = int.Parse(Console.ReadLine());

Console.Write("Въведете тегло (в кг):");

double hight = double.Parse(Console.ReadLine());

double BMI = weight / (hight * hight);

if (BMI <= 18)
{
    Console.WriteLine("Podnormeno teglo");
}
else if (BMI > 18 &&  BMI <= 25)
{
    Console.WriteLine("Normalno teglo");
}
else
{
    Console.WriteLine("Nadnormeno teglo");
}