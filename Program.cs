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
while (i<ray.Length) 
{
int rayn = new Random().Next(0, 2000000001);
ray[i] = rayn;
if (ray[i] == num) Console.WriteLine("Число " + num + " есть в массиве " + ($"{ray[i]} + ", ""));
i++;
}



}
Console.WriteLine();
Z3();