//Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

string GetStringFromArray(char[,] array)
{
    string result = String.Empty;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result += array[i, j];
        }
    }
    return result;
}
char[,] chars ={
                 {'H','e','l','l','o',' '},
                 {'m','y',' ','w','o','r'},
                 {'l','d','!','!','!','!'},
               };
string result = GetStringFromArray(chars);
Console.WriteLine($"Result: {result}");

