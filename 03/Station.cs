using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineRadioStation
{
    internal class Song
    {
        private string name;
        private string performer;
        private int minute;
        private int second;

        public Song(string name, string performer, int minute, int second)
        {
            NAME = name;
            PERFORMER = performer;
            MINUTE = minute;
            SECOND = second;
        }

        public string NAME
        {
            get { return name; }
            set
            {
                if (value.Length <= 3 || value.Length >= 30)
                {
                    throw new("Invalid song.");
                }
                else
                {
                    name = value;
                }
            }
        }

        public string PERFORMER
        {
            get { return performer; }
            set
            {
                if (value.Length <= 3 || value.Length >= 20)
                {
                    throw new("Artist name should be between 3 and 20 symbols.");
                }
                else
                {
                    performer = value;
                }
            }
        }

        public int MINUTE
        {
            get { return minute; }
            set
            {
                if (value < 0 || value > 14)
                {
                    throw new("Song minutes should be between 0 and 14.");
                }
                else
                {
                    minute = value;
                }
            }
        }

        public int SECOND
        {
            get { return second; }
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new("Song seconds should be between 0 and 59.");
                }
                else
                {
                    second = value;
                }
            }
        }
        
    }
}
