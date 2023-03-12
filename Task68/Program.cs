
int GetIncomingData(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int GetAckerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else
    {
        if ((m != 0) && (n == 0))
        {
            return GetAckerman(m - 1, 1);
        }
        else
        {
            return GetAckerman(m - 1, GetAckerman(m, n - 1));
        }
    }
}

int m = GetIncomingData("Введите m");
int n = GetIncomingData("Введите n");
Console.WriteLine(GetAckerman(m, n));