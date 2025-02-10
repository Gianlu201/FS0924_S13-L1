using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS0924_S13_L1
{
    public class Athlete
    {
        private string? _firstName;
        private string? _lastName;
        private int _age;
        private string? _sport;
        private int _competitionsWinned;

        public string FirstName
        {
            get{
                return _firstName;
            }
            set{
                _firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }

        public string Sport
        {
            get
            {
                return _sport;
            }
            set
            {
                _sport = value;
            }
        }

        public int CompetitionsWinned
        {
            get
            {
                return _competitionsWinned;
            }
            set
            {
                _competitionsWinned = value;
            }
        }

        public string Presentation()
        {
            return "My name is " + this.FirstName + " " + this.LastName + ", I'm " + this.Age + " years old, and I'm an athlete. I do " + this.Sport + " and I won " + this.CompetitionsWinned + " championships";
        }
    }
}
