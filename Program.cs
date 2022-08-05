void Z1() 
{


}
Console.WriteLine();
Z1();

Console.WriteLine();
void Z2() 
{


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
    Console.Write("\b " + "]");
    Console.Write(" есть число " + num); 
    return; 
    }
else i++;
}
Console.Write("\b " + "]");
Console.WriteLine(" нет числа " + num); 


}
Console.WriteLine();
Z3();