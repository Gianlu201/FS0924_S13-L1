using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS0924_S13_L1
{
    internal class Animal
    {
        private string _name;
        private string _breef;
        private int _age;
        private int _nb_paws;

        public Animal(string name, string breef, int age, int nb_paws)
        {
            this._name = name;
            this._breef = breef;
            this._age = age;
            this._nb_paws = nb_paws;
        }

        public string ShowAnimalInfo()
        {
            return "It's a " + this._breef + " and its name is " + this._name;
        }
    }
}
