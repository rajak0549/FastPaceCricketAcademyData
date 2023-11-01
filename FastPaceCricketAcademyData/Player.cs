using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastPaceCricketAcademyData
{
    internal class Player
    {
        private int PlayerId;
        private string PlayerName;
        private int PlayerAge;


        public int PlayerIdProperty
        {
            get { return PlayerId; }
            set { PlayerId = value; }

        }
        public string PlayerNameProperty
        {
            get { return PlayerName; }
            set { PlayerName = value; }
        }

        public int PlayerAgeProperty
        {
            get { return PlayerAge; }
            set { PlayerAge = value; }

        }
    }

}

