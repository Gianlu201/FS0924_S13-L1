using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS0924_S13_L1
{
    public class Employee
    {
        public string? _firstName { get; set; }
        public string? _lastName { get; set; }
        public int? _age { get; set; }
        public string? _company {  get; set; }
        public string? _job { get; set; }

        public string SayHello()
        {
            return "Hi, my name is " + this._firstName + " " + this._lastName + ", I'm " + this._age + " years old and I'm an employee in " + this._company;
        }
    }
}
