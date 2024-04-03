using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Оголошення та ініціалізація двовимірного масиву
        int[,] array = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        // Завдання а): виведення усього масиву
        Console.WriteLine("Усі елементи масиву:");
        PrintArray(array);

        // Завдання б): виведення будь-якого елемента другого рядка масиву
        int rowIndex = 1; // Індекс другого рядка
        int columnIndex = 2; // Індекс елемента у другому рядку
        Console.WriteLine($"Елемент другого рядка з індексом [{rowIndex}, {columnIndex}]: {array[rowIndex, columnIndex]}");

        // Завдання в): виведення будь-якого елемента масиву
        int anyRowIndex = 0; // Індекс будь-якого рядка
        int anyColumnIndex = 1; // Індекс будь-якого елемента у цьому рядку
        Console.WriteLine($"Будь-який елемент масиву з індексом [{anyRowIndex}, {anyColumnIndex}]: {array[anyRowIndex, anyColumnIndex]}");
    }

    // Метод для виведення усього масиву
    static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
