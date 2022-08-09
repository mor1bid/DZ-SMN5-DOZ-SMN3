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
for (int i = 0, i2 = si-1; i < i2; i++, i2--)
    {
        int numa = ra.Next(-10, 11);
        ray[i] = numa;
        Console.Write(ray[i] + ", ");
        double numb = Math.Round (ra.NextDouble() * (mav-miv)+miv, 2);
        ray[i2] = numb;
        Console.Write(ray[i2] + ", ");
    }
double max = ray[0], min = ray[0];
for (int i = 0; i < si; i++)
    {
        if (ray[i] >= max) max = ray[i];
        else if (ray[i] < min) min = ray[i];
    }
if (min<0) Console.Write("\b\b" + "] разница между максимальным значением " + max + " и минимальным значением " + min + " = " + $"{Math.Round(max+min, 2)}");
else Console.Write("\b\b" + "] разница между максимальным значением " + max + " и минимальным значением " + min + " = " + $"{Math.Round(max-min, 2)}");
Console.WriteLine();
}

Console.WriteLine();
void DOZ41() 
{
    // Дан массив средних температур (массив заполняется случайно) за последние 10 лет. 
    // На ввод подают номер месяца и год начали и конца.
    // Определить самые высокие и низкие температуры для лета, осени, зимы и весны в заданном промежутке. 
    // Если таких температур нет, сообщить, что определить не удалось.

Console.WriteLine("3.4. Введите номер месяца и год: ");
int month = Convert.ToInt32(Console.ReadLine()),
    year = Convert.ToInt32(Console.ReadLine());
    if (month>12) 
    {
        Console.WriteLine("Задано неверное кол-во месяцев.");
        return;
    }
int [] mass = new int [20];
int i = 0;
while (i<mass.Length) 
    {
        int num = new Random().Next(-10, 10); 
        mass[i] = num;
        i++;
    }
i = 0;
int yi = 0,
    mi = 1;
Console.WriteLine("В " + yi + " году:");
while (yi-1<year) 
    {
    int temp = mass [i], min = 0, plu = 0;
        if (temp>plu) plu = temp;
        else if (temp<min) min = temp;
        
        if (mi==1) Console.WriteLine ("В июне было от " + min + " до " + plu + "°C");
        else if (mi==2) Console.WriteLine ("В июле было от " + min + " до " + plu + "°C");
        else if (mi==3) Console.WriteLine ("В августе было от " + min + " до " + plu + "°C");
        else if (mi==4) Console.WriteLine ("В сентябре было от " + min + " до " + plu + "°C");
        else if (mi==5) Console.WriteLine ("В октябре было от " + min + " до " + plu + "°C");
        else if (mi==6) Console.WriteLine ("В ноябре было от " + min + " до " + plu + "°C");
        else if (mi==7) Console.WriteLine ("В декабре было от " + min + " до " + plu + "°C");
        else if (mi==8) Console.WriteLine ("В январе было от " + min + " до " + plu + "°C");
        else if (mi==9) Console.WriteLine ("В феврале было от " + min + " до " + plu + "°C");
        else if (mi==10) Console.WriteLine ("В марте было от " + min + " до " + plu + "°C");
        else if (mi==11) Console.WriteLine ("В апреле было от " + min + " до " + plu + "°C");
        else if (mi==12) Console.WriteLine ("В мае было от " + min + " до " + plu + "°C");

    i++;
    mi++;
    if (mi>12) 
    { 
        mi=1;
        yi++;
        i = 0;
        Console.WriteLine("В " + yi + " году:");
    }
    }
}
Console.WriteLine(" ");

void DOZ51() 
{
    // На вход подаётся число n > 4, указывающее длину пароля. 
    // Создайте метод, генерирующий пароль заданной длины. 
    // В пароле обязательно использовать цифру, букву и специальный знак.

int index = 0;
Console.WriteLine("3.5. Введите число символов в пароле: ");
int n = Convert.ToInt32(Console.ReadLine());
string let = "a!1b@2c#3d$4e%5f^6g&7h*8i(9j)0k_l+m=n-o?p:q;r№stuvwxyz";
int letl = let.Length;
Console.Write("Пароль: ");
if (n>4) 
{
    while (index<n) 
    {
        string letres = String.Empty;
        int ilet = new Random().Next(0, letl);
        string Replace(string let, char oldValue, char newValue) 
        {
            if (let[ilet] == oldValue) letres += $"{newValue}";
            else letres += $"{let[ilet]}";
            return letres;
        }
        string letpass = Replace(let, ' ', ' ');
    Console.Write(letpass);
    index++;
    }
}
else Console.WriteLine("Задана слишком малая длинна пароля.");
}
Console.WriteLine();

Console.WriteLine();
void DOZ71() 
{
    // Массив из ста элементов заполняется случайными числами от 1 до 100. 
    // Удалить из массива все элементы, содержащие цифру 3. 
    // Вывести в консоль новый массив и количество удалённых элементов.

int [] array = new int [100];
int size = array.Length,
    junk = 0;
    //i = 0;
Console.WriteLine();
Console.Write("3.7. В массиве [");
for (int i = 0; i < size; i++)
    {
        int num = new Random().Next(1, 10);
        array[i] = num;
        Console.Write(array[i] + ", ");
    }
Console.WriteLine("\b\b" + "]"); 
Console.WriteLine("="); 
Console.Write("[");
int [] ray = new int [100];
for (int i = 0; i < size; i++)
{
    int num = array[i];
    if (num % 10 == 3 || (num % 100)/10 == 3) 
        {
            junk++;
        }
    else 
        {
            ray [i] = num;
            Console.Write(ray[i]);
            Console.Write(", ");
        }
}
Console.WriteLine("\b\b" + "]");
Console.WriteLine("было " + junk + " чисел с цифрой 3");
}
Console.WriteLine(" ");
 
Console.WriteLine(" ");
void DOZ81() 
{
    // Напишите программу, который выводит на консоль таблицу умножения от 1 до n, 
    // где n задаётся случайно от 2 до 100.

int numa = new Random().Next(2, 100), 
    j = 1,
    i = 1;
Console.WriteLine("3.8. Число: " + numa);
while (i<=numa) 
{
    if (j<=10) 
    {
        Console.WriteLine(i + "*" + j + "=" + $"{i*j}");
        j++;
    } 
    else 
    {
        i++;
        j = 1;
        Console.WriteLine(" ");
    }
}
Console.WriteLine(" ");
}

Console.WriteLine(" ");
void DOZ91() 
{
    // Дана игра со следующими правилами. 
    // Первый игрок называет любое натуральное число от 2 до 9, 
    // второй умножает его на любое натуральное число от 2 до 9, 
    // первый умножает результат на любое натуральное число от 2 до 9 и т. д. 
    // Выигрывает тот, у кого впервые получится число больше 1000. Запрограммировать консольный вариант игры.

int index=0;
Console.WriteLine("3.9. Правила игры: Первый игрок называет любое натуральное число от 2 до 9, второй умножает его на любое натуральное число от 2 до 9, первый умножает результат на любое натуральное число от 2 до 9 и т. д. Выигрывает тот, у кого впервые получится число больше 1000.");
Console.WriteLine("Игрок 1, введите начальное число");
int res = Convert.ToInt32(Console.ReadLine());
if (res<10) 
{
    while (index<1000) 
    {
        Console.WriteLine("Игрок 2, введите своё число");
        int numpl2 = Convert.ToInt32(Console.ReadLine());
        if (numpl2<10 && res>1000) 
        {
            Console.WriteLine("Игрок 1 выигрывает со счётом: " + res);
            return;
        }
        else if (res<=1000)
        {
            res *= numpl2;
            Console.WriteLine(res);
        }
        else 
        {
            Console.WriteLine("Введено некорректное число");
        }
        Console.WriteLine("Игрок 1, введите своё число");
        int numpl1 = Convert.ToInt32(Console.ReadLine());
        if (numpl1<10 && res>1000) 
        {
            Console.WriteLine("Игрок 2 выигрывает со счётом: " + res);
            return;
        }
        else if (res<=1000) 
        {
            res *= numpl1;
            Console.WriteLine(res);
        }
            
        else 
        {
            Console.WriteLine("Введено некорректное число");
        }
        index++; 
    }  
}
else 
{
    Console.WriteLine("Введено некорректное число");
}
}
Console.WriteLine(" ");

DZ1();
DZ2();
DZ3();
DOZ41();
DOZ51();
DOZ71();
DOZ81();
DOZ91();