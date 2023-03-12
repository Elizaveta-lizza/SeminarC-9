int GetIncomingData(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintPrevNaturalNumbers(int naturalnumber)
{
    if(naturalnumber > 1)
    {
        Console.Write($"{naturalnumber},");    
        naturalnumber--;
    }
    else
    {
        Console.Write($"{naturalnumber}");    
        return;
    };
    PrintPrevNaturalNumbers(naturalnumber);
}

int NaturalNumbers = GetIncomingData("Введите натуральное число");
PrintPrevNaturalNumbers( NaturalNumbers );