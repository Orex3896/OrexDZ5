/*void ShowArray(int[] array)// метод выводит массив
{
    for(int i =0;i<array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
*/
/*int[] CreateRandomArray(int size, int minValue, int maxValue)// размер массива, минимальное его число и максимальное число
{
    int[] array = new int[size]; //выделили память
    for(int i = 0;i<size;i++)
    {
        array[i]= new Random().Next(minValue,maxValue+1);
    }
    return array;
}
*/
//Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
//числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int KolvoChetnih(int[] array)
{
    int kolvo= 0;
    for(int i = 0; i<array.Length; i++)
        if(array[i]%2==0)// нечетных чисел %2!=0
            kolvo++;//подсчёт кол-ва
            return kolvo;
}

Console.Write("Введите кол-во элементов массива ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальный элемент массива ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальный элемент массива ");
int max = Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateRandomArray(length, min, max);
Console.Write("Вывод массива:\t ");
ShowArray(myArray);
int result = KolvoChetnih(myArray);
Console.WriteLine($"Кол-во четных числе в массиве = {result}");
*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
/*
int SummaNechetnihI(int[] array)
{
    int sum= 0;
    for(int i = 0; i<array.Length; i++)
        if(i%2!=0)
            sum+=array[i];//подсчёт суммы
            return sum;
}
int SummaNechetnihPolzovatel(int[] array)
{  
    int sum= 0;
    for(int i = 0; i<array.Length; i++)
        if(i%2==0)
            sum+=array[i];//подсчёт суммы
            return sum;
}
Console.Write("Введите кол-во элементов массива ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальный элемент массива ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальный элемент массива ");
int max = Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateRandomArray(length, min, max);
Console.Write("Вывод массива:\t ");
ShowArray(myArray);
int result = SummaNechetnihI(myArray);
Console.WriteLine($"Сумма элементов находящихся на нечетном месте в массиве = {result}");
int ResultPolozovatel = SummaNechetnihPolzovatel(myArray);
Console.WriteLine($"Сумма элементов находящихся на нечетном месте в массиве со стороны пользователя= {ResultPolozovatel}");
*/
//Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
//максимальным и минимальным элементов массива.
void ShowArray(double[] array)// метод выводит массив
{
    for(int i =0;i<array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
double[] CreateRandomDoubleArray(int size, int minValue, int maxValue)
{   
    double[] sum = new double[size];
    int[] array = new int[size]; 
    double[] doubleArray = new double[size];
    for(int i = 0;i<size;i++)
    {
        array[i]= new Random().Next(minValue,maxValue);
        doubleArray[i]= new Random().NextDouble();
        doubleArray[i] = Math.Round(doubleArray[i],2);//рандомный массив double
        sum[i]=array[i]+doubleArray[i];//Слияние двух массивов int и double
    }
    return sum;
}
double RaznicaMinMaxArrayI(double[] array)
{
    double min = array[0];
    for(int i=0; i<array.Length; i++)
    {
        if(min>array[i])
        {
            min=array[i];
        }
    }
    double max = array[0];
    for(int i=0; i<array.Length; i++)
    {
        if(max<array[i])
        {
            max=array[i];
        }
    }
    double rezult = max-min;// разница между min и max
    return rezult;
}

Console.Write("Введите кол-во элементов массива ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальный элемент массива ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальный элемент массива ");
int max = Convert.ToInt32(Console.ReadLine());
double [] myArray = CreateRandomDoubleArray(length, min, max);
Console.Write("Вывод массива:\t ");
ShowArray(myArray);
double raznica = RaznicaMinMaxArrayI(myArray);
Console.WriteLine($"Разница между min и max = {raznica}");
