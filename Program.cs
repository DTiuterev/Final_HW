Console.WriteLine("Данная программа из введенного Вами массива строк (количество строк органичено 5), состоящих из произвольного количества символов (буквы, цифры, спецсимволы) сформирует массив из строк, содержащих не более трех символов.");
Console.WriteLine("Введите Ваш массив строка за строкой. При отсутствии строк нажимайте Enter.");
string s1 = InputString($"Введите первую строку: ");
string s2 = InputString($"Введите вторую строку: ");
string s3 = InputString($"Введите третью строку: ");
string s4 = InputString($"Введите четвертую строку: ");
string s5 = InputString($"Введите пятую строку: ");
        
string InputString(string input)
{
  Console.Write(input);
  string output = Convert.ToString(Console.ReadLine());
  return output;
}

string[] array = new string[] {s1, s2, s3, s4, s5};
string[] array3sym = new string[array.Length];
//int count = 0;
void Array3Symbols(string[] array, string[] array3sym)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        array3sym[count] = array[i];
        count++;
        }
    }
}

Console.Write("Массив из строк, содержащих не более трех символов: ");
void PrintArray3Symbols(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
}
Array3Symbols(array, array3sym);
PrintArray3Symbols(array3sym);