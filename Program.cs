void Z1() 
{
int [] ar = new int [12];

}

//void FillArray(int[] ar, int starttNumber = -10, int finishNumber = 10)
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
while (i<ray.Length) 
{
        if (ray[i] < 0) ray[i] = Math.Abs(ray[i]);
        else if (ray[i] > 0) ray[i] *= -1;
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

 void Z4() 
 {
 int [] ray = new int [6];
 int i = 0,
 size = ray.Length;
 Console.Write("Массив [");
 while (i<ray.Length) 
 {
 int rayn = new Random().Next(0, 11);
 ray[i] = rayn;
 Console.Write(($"{ray[i]}" + ", "));
 i++;
 }
 i = 0;
 Console.Write("\b\b" + "]");
 Console.WriteLine();
 int j = size;
 while (j > 0 && i < size)
 {
     int res = ray[i] * ray[j];
     //Console.WriteLine("Произведение " + $"{ray[i]}" + " * " + $"{ray[j]}" + " = " + $"{ray[i]*ray[j]}");
     Console.WriteLine("Произведение " + ray[i] + " * " + ray[j] + " = " + res);
     i++;
     j--;
}
}
Console.WriteLine();
Z4();

void Z5() 
{
int [] ray = new int [10];
int i = 0,
size = ray.Length;
Console.Write("В массиве [");
while (i<ray.Length) 
{
int rayn = new Random().Next(0, 151);
ray[i] = rayn;
Console.Write(($"{ray[i]}" + ", "));
i++;
}
i = 0;
int co = 0;
Console.Write("\b\b" + "]");
Console.WriteLine();
while(i < size) 
{
    if (ray[i] >= 10 && ray[i] <= 99) co++;
    i++;
}
Console.Write(" - " + co + " элемента(ов) в данном промежутке");
}
Console.WriteLine();
Z5();
