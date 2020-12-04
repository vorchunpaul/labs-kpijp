﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Employe
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public bool Programmer { get; private set; }


        public Employe(string name, int age, bool programmer)
        {
            Name = name;
            Age = age;
            Programmer = programmer;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
