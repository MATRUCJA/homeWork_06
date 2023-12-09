//Задайте произвольную строку. Выясните, является ли она палиндромом.

Console.Write("Введите слово:");
string line = Console.ReadLine();
void FindPalindrome(string line)
{
    int countSymbol = 0;
    int size = line.Length;
    for (int i = 0; i < size / 2; i++)
    {
        if (line[i] == line[size - i - 1])
        {
            countSymbol++;
        }

    }
    if (countSymbol == size / 2)
        Console.WriteLine("Вы ввели палиндром");
    else Console.WriteLine("Вы ввели НЕ палиндром");
}

FindPalindrome(line);