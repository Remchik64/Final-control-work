using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите элементы массива через пробел:");
        string input = Console.ReadLine();

        // Разделение введенной строки на массив строк
        string[] words = input.Split(' ');

        // Фильтрация строк по условию (длина <= 3)
        string[] result = FilterWords(words);

        // Вывод результата
        Console.WriteLine("Результат:");
        foreach (string word in result)
        {
            Console.Write(word + " ");
        }
    }

    static string[] FilterWords(string[] words)
    {
        // Подсчет количества строк, подходящих под условие
        int count = 0;
        foreach (string word in words)
        {
            if (word.Length <= 3)
            {
                count++;
            }
        }

        // Создание нового массива с подходящими строками
        string[] result = new string[count];
        int index = 0;
        foreach (string word in words)
        {
            if (word.Length <= 3)
            {
                result[index] = word;
                index++;
            }
        }

        return result;
    }
}
