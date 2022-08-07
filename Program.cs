void DZ1() 
{
int si = new Random().Next(4, 14);
int [] rayh = new int [si];
int eco = 0, 
    uco = 0;
Console.Write("34. В массиве [");
    for (int i = 0; i < si; i++)
    {
        int num = new Random().Next(100, 1000);
        rayh[i] = num;
        Console.Write(rayh[i] + ", ");
        if (rayh[i] % 2 == 0) eco++;
        else uco++;
    }
Console.Write("\b\b" + "] - " + eco + " чётных чисел и " + uco + " нечётных." );
Console.WriteLine();
}

void DZ2() 
{
int sum = 0, si = new Random().Next(4, 14);
int [] ray = new int [si];
Console.Write("36. Сумма чисел на нечётных позициях в массиве [");
for (int i = 0; i < si; i++)
    {
        int num = new Random().Next(1, 10);
        ray[i] = num;
        Console.Write(ray[i] + ", ");
        if (i % 2 != 0) sum += ray[i];
    }
Console.Write("\b\b" + "] = " + sum);
Console.WriteLine();
}

void DZ3() 
{
int si = new Random().Next(4, 14);
double [] ray = new double [si];
double mav = -10.5, miv = 11.5; 
Random ra = new Random();
Console.Write("38. В массиве [");
for (int i = 0; i < si; i++)
    {
        double num = Math.Round (ra.NextDouble() * (mav-miv)+miv, 2);
        ray[i] = num;
        Console.Write(ray[i] + ", ");
    }
double max = 0, min = ray[0];
for (int i = 0; i < si; i++) 
    {
        if (ray[i] >= max) max = ray[i];
        else if (ray[i] < min) min = ray[i];
    }
if (min<0) Console.Write("\b\b" + "] разница между максимальным значением " + max + " и минимальным значением " + min + " = " + $"{max+min}");
else Console.Write("\b\b" + "] разница между максимальным значением " + max + " и минимальным значением " + min + " = " + $"{max-min}");
}

DZ1();
DZ2();
DZ3();