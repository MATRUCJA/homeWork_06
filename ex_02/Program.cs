//Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.

void ReplacementUpperSymbol(string line)
{
    for (int i=0; i<line.Length;i++)
    {
        if (char.IsUpper(line[i])) Console.Write(char.ToLower(line[i]));
        else Console.Write(line[i]);
    }
}
string inputString="Hello my Love!";
ReplacementUpperSymbol(inputString);

