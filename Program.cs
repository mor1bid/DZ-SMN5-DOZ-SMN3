void Z1() 
{


}
Console.WriteLine();
Z1();

Console.WriteLine();
void Z2() 
{
int [] ray = new int [5];
int i = 0;
Console.Write("Был: [");
while (i<ray.Length) 
{
int rayn = new Random().Next(-11, 12);
ray[i] = rayn;
Console.Write(($"{ray[i]}" + ", "));
i++;
}
i = 0;
Console.Write("\b\b" + "]");
Console.WriteLine();
Console.Write("Стал: [");
//int j = i + 1;
while (i<ray.Length) 
{
    int min = i;
    //while (j<ray.Length) 
    //{
        if (ray[i] < 0) ray[i] = Math.Abs(ray[i]);
        else if (ray[i] > 0) ray[i] *= -1;
    //}
    Console.Write(ray[i] + ", ");
    i++;
}
Console.Write("\b\b" + "]");
}
Console.WriteLine();
Z2();

Console.WriteLine();
void Z3() 
{
Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine()), 
    i = 0;
int [] ray = new int [5];
Console.Write("В массиве [");
while (i<ray.Length) 
{
int rayn = new Random().Next(0, 11);
ray[i] = rayn;
Console.Write(($"{ray[i]}" + ", "));
i++;
}
i = 0;
while (i<ray.Length) 
{
if (ray[i] == num) 
{ 
    Console.Write("\b\b" + "]");
    Console.Write(" есть число " + num); 
    return; 
    }
else i++;
}
Console.Write("\b\b" + "]");
Console.WriteLine(" нет числа " + num); 


}
Console.WriteLine();
Z3();