using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gr76OOP2
{
    class Insan
    {
        //encapsulation - kapsullama
        //inheritance - varislik
        //polymorphizm - choxyonumluluk
        //abstract - mucerredlik
        //interface - arayuz

        private string name;

        public string Name { get => name; set => name = value.ToUpper(); }
       

        private string surname;
        public string Surname { get => surname; set => surname = value.ToUpper(); }
       

        private string birthPlace;

        public string BirthPlace { get => birthPlace; set => birthPlace = value.ToUpper(); }
        
        private int birthYear;

        public int BirthYear { get => birthYear; set => birthYear =  Math.Abs(value); }



        public int GetAge(int il)
        {
            int age = DateTime.Now.Year - il;
            return age;
        }

    }
}
