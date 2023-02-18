using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Кости_csharp
{
    class Game
    {
        public string randomName()
        {
            string[] enemyPlayerName = { "Игорь", "Лев", "Никита", "Глеб", "Николай", "Марк", "Денис", "Даниил", "Петр", "Роман", "Руслан", "Сергей", "Тимофей", "Федр" };
            int indexRandomName = new Random().Next(enemyPlayerName.Length);
            return $"{enemyPlayerName[indexRandomName]}";
        }
        public string Games(string player, string enemyPlayer)
        {
            int cubs = 0;
            Console.WriteLine($"{player}, кидайте кость! 1 - Кинуть / 2 - Сдаться"); string? choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    while (cubs < 8)
                    {
                        int RandomThrow = new Random().Next(1, 7);
                        int EnemyRandomThrow = new Random().Next(1, 7);
                        Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine($"\t{player}, вы выбросили {RandomThrow}"); Console.ResetColor();
                        cubs++;
                        if (RandomThrow == 6)
                        {
                            return $"Выиграл {player}! {player} выбросил {RandomThrow}";
                        }                       
                        else if (RandomThrow != 6)
                        {
                            Console.WriteLine($"{enemyPlayer}, кидайте кость!");
                            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine($"\t{enemyPlayer}, выбросил {EnemyRandomThrow}"); Console.ResetColor();
                            cubs++;
                            if (EnemyRandomThrow == 6)
                            {
                                return $"Выиграл {enemyPlayer}! {enemyPlayer} выбросил {EnemyRandomThrow}";
                            }
                            if (cubs < 8) { Console.WriteLine($"{player}, кидайте кость! 1 - Кинуть / 2 - Сдаться"); string? vybor = Console.ReadLine(); }                         
                        }
                        if (cubs == 8 && RandomThrow != 6 && EnemyRandomThrow != 6)
                        {
                            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("\tНичья! Никому не выпала 6!"); Console.ResetColor();
                        }
                    }
                    break;
                case "2":
                    return $"Так как {player} сдался, победа досталась {enemyPlayer + "(у/ю)"}";
                default: Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine($"Возможно вы ошиблись! Попробуйте еще раз!"); Console.ResetColor(); break;
            }
            return null;
        }
        public void StartGames()
        {
            Console.WriteLine("Представьтесь! Как вас зовут?"); string? Player = Console.ReadLine();
            string enemyPlayer = randomName(); Console.WriteLine($"Здравствуйте {Player}! Вашего соперника звать - {enemyPlayer}.\nПриятной игры!");
            Console.WriteLine(Games(Player, enemyPlayer));
            Console.WriteLine("Будете ли вы играть дальше? 1 - Да / 2 - Нет"); string? choice = Console.ReadLine();
            if (choice == "1")
            {
                while (choice == "1")
                {
                    enemyPlayer = randomName(); Console.WriteLine($"Здравствуйте {Player}! Вашего соперника звать - {enemyPlayer}.\nПриятной игры!");
                    Console.WriteLine(Games(Player, enemyPlayer));
                    Console.WriteLine("Будете ли вы играть дальше? 1 - Да / 2 - Нет"); choice = Console.ReadLine();
                    Console.Clear();
                }
            }
            if (choice == "2") { Console.Clear(); } Console.ReadKey();
        }
    }
}
