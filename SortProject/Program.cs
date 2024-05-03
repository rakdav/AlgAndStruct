using System.Diagnostics;

int[] mas = new int[1000000];
//int[] mas1 = new int[100000];
Random random = new Random();
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = random.Next(10, 100);
}
//Array.Copy(mas, mas1, mas.Length);
Stopwatch stpWatch = new Stopwatch();
stpWatch.Start();
//BubbleSort(mas);
//ShakerSort(mas);
InsortSort(mas);
stpWatch.Stop();
Console.WriteLine("StopWatch: " +
(stpWatch.ElapsedMilliseconds/1000.0).ToString("F4"));

//Stopwatch stpWatch1 = new Stopwatch();
//stpWatch1.Start();
//Array.Sort(mas1);
//stpWatch1.Stop();
//Console.WriteLine("StopWatch: " +
//(stpWatch1.ElapsedMilliseconds / 1000.0).ToString("F4"));

void Swap(ref int e1,ref int e2)
{
    var temp = e1;
    e1 = e2;
    e2 = temp;
}
int[] BubbleSort(int[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        for(int j = i + 1; j < array.Length; j++)
        {
            if (array[i] > array[j])
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
    return array;
}

int[] ShakerSort(int[] array)
{
    for (int i = 0; i < array.Length/2; i++)
    {
        var swapFlag = false;
        for (int j = i; j < array.Length-i-1; j++)
        {
            if (array[j] > array[j + 1])
            {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
                swapFlag = true;
            }
        }
        for(var j = array.Length - 2 - i; j > i; j--)
        {
            if (array[j-1] > array[j])
            {
                int temp = array[j-1];
                array[j-1] = array[j];
                array[j] = temp;
                swapFlag = true;
            }
        }
        if (!swapFlag) break;
    }
    return array;
}
//сортировка вставками
int[] InsortSort(int[] array)
{
    for (int i = 1; i < array.Length; i++)
    {
        var key = array[i];
        var j = i;
        while ((j > 1) && (array[j - 1] > key))
        {
            Swap(ref array[j - 1], ref array[j]);
            j--;
        }
        array[j] = key;
    }
    return array;
}

