static void Main(string[] args)
{
    int i;
    int b = 8, a = 32;
    for (i = 0; i <= 10; i++)
    {
        if ((a / b * 2) == 2)
            Console.Write(i + " ");
        else if (i != 4)
            Console.Write(i + " ");
        else
            break;
    }
}