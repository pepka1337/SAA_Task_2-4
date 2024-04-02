// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        DrawChessBoard();
    }

    static void DrawChessBoard()
    {
        char[,] chessBoard = new char[8, 8];

        for (int row = 0; row < 8; row++)
        {
            for (int col = 0; col < 8; col++)
            {
                if ((row + col) % 2 == 0)
                {
                    chessBoard[row, col] = '■'; // Черные клетки
                }
                else
                {
                    chessBoard[row, col] = '□'; // Белые клетки
                }
            }
        }

        Console.WriteLine("  a b c d e f g h");
        for (int row = 0; row < 8; row++)
        {
            Console.Write(8 - row + " ");
            for (int col = 0; col < 8; col++)
            {
                Console.Write(chessBoard[row, col] + " ");
            }
            Console.WriteLine(8 - row);
        }
        Console.WriteLine("  a b c d e f g h");
        Console.Write("Введите координаты первого поля (например, a1): ");
        string field1 = Console.ReadLine().ToLower(); // Приводим к нижнему регистру для унификации
        Console.Write("Введите координаты второго поля (например, b2): ");
        string field2 = Console.ReadLine().ToLower(); // Приводим к нижнему регистру для унификации

        // Определение цветов полей и проверка на одинаковость цвета
        bool fieldsSameColor = IsSameColorField(field1, field2);

        // Вывод результата
        Console.WriteLine(fieldsSameColor ? "Поля одного цвета." : "Поля разного цвета.");
    }

    static bool IsSameColorField(string field1, string field2)
    {
        // Определяем цвет первого и второго поля
        int sum1 = (field1[0] - 'a') + (field1[1] - '1');
        int sum2 = (field2[0] - 'a') + (field2[1] - '1');

        // Поля одного цвета, если сумма координат четная или нечетная
        return sum1 % 2 == sum2 % 2;
    }
}



