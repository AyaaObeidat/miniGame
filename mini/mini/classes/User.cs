using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini
{

    public class User

    {
        public int ID = 0;

        public int MaxDuration, MinDuration, MaxScore, MinScore, TotalDuration;

        public User()
        {


            MaxDuration = 0;
            MinDuration = 100;
            MaxScore = 0;
            MinScore = 100;
            TotalDuration = 0;

        }
        public string _Name { get; set; }
        public int _Age { get; set; }
        public string _Gender { get; set; }
        public string _FavC { get; set; }

      }
}
