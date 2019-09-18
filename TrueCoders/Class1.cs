using System;
using System.Collections.Generic;
using System.Text;

namespace TrueCoders
{
    class People
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string HairColor { get; set; }

        public People(int age, string firstname , string lastname, string haircolor)
        {
            Age = age;
            FirstName = firstname;
            LastName = lastname;
            HairColor = haircolor;

        }
        public People()
        { }
    }
}
