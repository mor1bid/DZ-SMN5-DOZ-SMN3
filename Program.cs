void DZ1() 
{
int [] rayh = new int [4];
int co = 0;
Console.Write("В массиве [");
for (int i = 0, size = rayh.Length; i < size; i++)
{
int num = new Random().Next(100, 1000);
rayh[i] = num;
Console.Write(rayh[i] + ", ");
if (rayh[i] % 2 == 0) co++;
}
Console.Write("\b\b" + "] - " + co + " чётных чисел" );
}

void DZ2() 
{

}
DZ1();
DZ2();
