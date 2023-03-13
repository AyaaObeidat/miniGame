using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini
{

    public class Game
    {
        public int Level;
        public int Score1;
        public int Score2;
        public int Level1Duration;
        public int Level2Duration;
        public int Duration;
        public DateTime date;
        public int FirstPlayerID;
        public int SecondPlayerID;
        public int GameID;
        public Game()
        {
            Level = 1;
            Score1 = 0;
            Score2 = 0;
            Duration = 0;
            date = DateTime.Today;

        }
        public Game(Game g)
        {
            Level = g.Level;
            Score1 = g.Score1;
            Score2 = g.Score2;
            Duration = g.Duration;
            date = g.date;

        }
    }
       
    }

