void DZ1() 
{
int [] rayh = new int [4];
int i = 0, 
    size = rayh.Length, 
    eco = 0, 
    uco = 0;
Console.Write("В массиве [");
void FRay() 
{
    for (int i = 0; i < size; i++)
    {
        int num = new Random().Next(100, 1000);
        rayh[i] = num;
        Console.Write(rayh[i] + ", ");
        //if (rayh[i] % 2 == 0) eco++;
        //else uco++;
    }
}
FRay();
i = 0;
    while (i<size) 
    {
        if (rayh[i] % 2 == 0) eco++;
        else uco++;
        i++;
    }
Console.Write("\b\b" + "] - " + eco + " чётных чисел и " + uco + " нечётных." );
Console.WriteLine();
}

Console.WriteLine();
void DZ2() 
{
int [] ray = new int [4];

}
DZ1();
DZ2();
