using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Кости_csharp
{
    public class Rules
    {
        public void StartRule()
        {
            Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine($"\t---------Приветствуем вас в игре Четыре кубика~----------"); Console.ResetColor();
            Console.WriteLine("Ознакомлены ли вы с правилами данной игры? 1 - Да / 2 - Нет"); string? choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine($"\tХорошо!"); Console.ResetColor();
                    Console.WriteLine("Игроки бросают четыре кубика. Если выпадет хотя бы одна шестерка - выигрывает первый, нет - другой игрок. \nВероятность выпадения шестерки - 51.8%");
                    Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine($"\tПриступаем к игре!"); Console.ResetColor();
                    break;
                case "2":
                    Console.WriteLine("\t-----Отлично!-----");
                    Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine($"\tПриступаем к игре!"); Console.ResetColor();
                    break;
                default: Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine($"Возможно вы ошиблись! Попробуйте еще раз!"); Console.ResetColor(); break;
            }
        }
    }
}
