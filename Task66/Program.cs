int GetIncomingData(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int GetSumm(int naturalnumber, int high)
{
    naturalnumber++;
    if (naturalnumber == high)
    {
        return naturalnumber;
    };
    return GetSumm(naturalnumber, high) + naturalnumber;
}

int Low = GetIncomingData("Введите нижнюю границу натуральным числом");
int High = GetIncomingData("Введите верхнюю границу натуральным числом");
Console.WriteLine(GetSumm(Low-1, High));