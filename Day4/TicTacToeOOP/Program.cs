using System;

namespace TicTacToeOOP
{
    class Game
    {
        private char[] field;
        public char[] CreateField()
        {
            field = new char[9];
            for(int i = 0; i < field.GetLength(0); i++)
            {
                field[i] = ' ';
            }
            return field;
        }
        public string WriteField()
        {
            string fieldString = "";

            for(int i = 0; i < field.GetLength(0); i += 3)
            {
                if(i % 3 == 0 && i != 0){
                    fieldString += "\n―――――――――\n";
                }
                fieldString += $"{field[i]} | {field[i + 1]} | {field[i + 2]}";
            }
            return fieldString;
        }
        public bool IsWin()
        {
            return ((field[0] == field[1] && field[1] == field[2] && field[1] != ' ') ||
            (field[3] == field[4] && field[4] == field[5] && field[4] != ' ') ||
            (field[6] == field[7] && field[7] == field[8] && field[7] != ' ') ||
            (field[0] == field[3] && field[3] == field[6] && field[3] != ' ') ||
            (field[1] == field[4] && field[4] == field[7] && field[4] != ' ') ||
            (field[2] == field[5] && field[5] == field[8] && field[5] != ' ') ||
            (field[0] == field[4] && field[4] == field[8] && field[4] != ' ') ||
            (field[2] == field[4] && field[4] == field[6] && field[4] != ' '));
        }
        int count = 0;

        int position;
        public void SetPos(int pos)
        {
            position = pos;
        }
        public char Turn()
        {
            if (field[position - 1] == ' ')
            {
                if(count % 2 == 0)
                {
                    field[position - 1] = 'x';
                    count++;
                }
                else
                {
                    field[position - 1] = 'o';
                    count++;
                }
            }
            return field[position - 1];
        }
        public bool IsFieldFull()
        {
            int fullCellsCount = 0;
            for (int i = 0; i < field.GetLength(0); i++)
            {
                if (field[i] != ' ')
                {
                    fullCellsCount++;
                }
            }
            return (fullCellsCount == field.GetLength(0));
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.CreateField();
            while (true)
            {
                Console.WriteLine(game.WriteField());
                game.SetPos(Convert.ToInt32(Console.ReadLine()));
                game.Turn();
                if (game.IsWin())
                    {
                        Console.WriteLine($"Win {game.Turn()}");
                        break;
                    }
                if (game.IsFieldFull())
                    {
                        Console.WriteLine("Field Full");
                        break;
                    }
            }
            Console.WriteLine(game.WriteField());
            
            
        }
    }
}
