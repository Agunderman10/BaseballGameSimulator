using System;
using System.Collections.Generic;

namespace BaseballGameSimulator
{ 
    class PlayGame
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your team name?");
            string teamName = Console.ReadLine();
            Console.WriteLine("What is the name of your team's stadium?");
            string teamStadium = Console.ReadLine();

            BaseballTeam UserTeam = new BaseballTeam(teamName, teamStadium);
            Random Random = new Random();

            //162 games to match a typical professional baseball season
            UserTeam.PlayGame(Random.Next(0,10),Random.Next(0,10));
            for(int i = 0; i < 157; i++)
            {
                UserTeam.PlayGame(Random.Next(0, 10), Random.Next(0, 10));
            }

            UserTeam.PlayGame(3,1);
            UserTeam.PlayGame(ResultEnums.Win);
            UserTeam.PlayGame(ResultEnums.Lose);
            UserTeam.PlayGame(ResultEnums.Draw);

            Console.WriteLine("Record: " + UserTeam.Record);

            Console.Write(UserTeam.ToString());

            UserTeam = null;

            //keep console open
            Console.ReadKey();
        }
    }
}
