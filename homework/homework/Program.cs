Console.Write("Въведете тегло (в кг):");

int weight = int.Parse(Console.ReadLine());

Console.Write("Въведете тегло (в кг):");

double hight = double.Parse(Console.ReadLine());

double BMI = weight / (hight * hight);

if (BMI <= 18)
{
    Console.WriteLine("Класификация:Поднормено тегло");
}
else if (BMI > 18 &&  BMI <= 25)
{
    Console.WriteLine("Класификация:Нормално тегло");
}
else
{
    Console.WriteLine("Класификация:Наднормено тегло");
}