/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

double[] getRandomArray(int length, double startPoint, double endPoint)
{
    double[] resultArray = new double[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = Convert.ToDouble(Console.ReadLine());
    }
    return resultArray;
}

void DifferenceBetweenMaxAndMin(double[] incomingArray)
{
    double minPosition = incomingArray[0];
    double maxPosition = incomingArray[0];
    for (int i = 0; i < incomingArray.Length; i++)
    {
        if (minPosition > incomingArray[i])
        {
            minPosition = incomingArray[i];
        }
        else if (maxPosition < incomingArray[i])
        {
            maxPosition = incomingArray[i];
        }
    }
    double result = maxPosition - minPosition;
    Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {result}");
}

Console.WriteLine("Введите массив вещественных чисел:");
double[] currentArray = getRandomArray(4, -100, 100);

DifferenceBetweenMaxAndMin(currentArray);

