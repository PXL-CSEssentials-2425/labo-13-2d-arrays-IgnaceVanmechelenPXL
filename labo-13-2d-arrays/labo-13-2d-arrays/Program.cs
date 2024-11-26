int[,] numbers = new int[3, 5];
Random rnd = new Random();
int amountOfRows = numbers.GetLength(0);
int amountOfColumns = numbers.GetLength(1);
for (int r = 0; r < amountOfRows; r++)
{
    if (r == 0)
    {
        for (int c = 0; c < amountOfColumns; c++)
        {
            numbers[r, c] = rnd.Next(1, 11);
        }
    }
    else if (r == 1)
    {
        for (int c = 0; c < amountOfColumns; c++)
        {
            Console.WriteLine($"Geef getal {c+1}: ");
            int.TryParse(Console.ReadLine(), out int numberInput);
            numbers[r, c] = numberInput;
        }
    }
    else if (r == 2)
    {
        for (int c = 0; c < amountOfColumns; c++)
        {
            numbers[r, c] = numbers[r - 2, c] + numbers[r - 1, c];
        }
    }
}
Console.WriteLine();
for (int r = 0;r < amountOfRows; r++)
{
    Console.Write($"rij {r+1} ==>     ");
    for (int c = 0; c < amountOfColumns; c++)
    {
        if ((c+1)%5 != 0)
        {
            Console.Write($"{numbers[r, c]}   ");
        }
        else if ((c+1)%5 == 0)
        {
            Console.WriteLine($"{numbers[r, c]}   ");
        }
    }
}
Console.ReadKey();