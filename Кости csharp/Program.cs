using System;

namespace Кости_csharp
{
    class Program
    {
        static void Main()
        {
            var startRules = new Rules();
            var StartGame = new Game();
            startRules.StartRule();
            StartGame.StartGames();
        }
    }
}