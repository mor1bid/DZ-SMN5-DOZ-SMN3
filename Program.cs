void DZ1() 
{
int si = new Random().Next(4, 14);
int [] rayh = new int [si];
int //i = 0, 
    //si = rayh.Length, 
    eco = 0, 
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
Console.Write("36. В массиве [");
for (int i = 0; i < si; i++)
    {
        int num = new Random().Next(1, 10);
        ray[i] = num;
        Console.Write(ray[i] + ", ");
        if (i % 2 != 0) sum += ray[i];
    }
Console.Write("\b\b" + "] - " + " сумма чисел на нечётных позициях массива составляет " + sum);
Console.WriteLine();
}
DZ1();
DZ2();
