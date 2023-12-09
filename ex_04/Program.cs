// Задайте строку, состоящую из слов, разделенных пробелами. Сформировать строку, в которой слова расположены в обратном порядке. 
// В полученной строке слова должны быть также разделены пробелами.

//В ПРОЦЕССЕ, ЕЩЕ НЕ ГОТОВА
Console.Write("Введите фразу:");
string line = Console.ReadLine();

void ReverseString(string line)
{
    int temp = 0;
    int sizeLine = line.Length;
    int count = 0;
    int n = 0;
    int[] means = new int[count];
    for (int i = sizeLine - 1; i >= 0; i--)
    {
        if (line[i] == ' ')
        {
            temp = i;
            count++;
            Console.Write(temp);
            means[n] = temp;
            for (int j = temp; j < sizeLine; j++)
            {
                Console.Write(line[i]);
            }
        }
    }

}
ReverseString(line);





