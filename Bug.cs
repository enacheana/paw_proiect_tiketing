using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paw_proiect_tiketing
{
    class Bug:IClonable, IComparable<Bug>
    {
        private string denumire;
        private string descriere;
        private int severitate;

        public string Denumire { get => denumire; set => denumire = value; }
        public string Descriere { get => descriere; set => descriere = value; }
        public int Severitate { get => severitate; set => severitate = value; }

        public Bug(string denumire, string descriere, int severitate)
        {
            this.denumire = denumire;
            this.descriere = descriere;
            this.severitate = severitate;
        }

        public static bool operator >(Bug b1, Bug b2)
        {
            if (b1.Severitate > b2.Severitate)
            {
                Console.WriteLine("Bug-ul " + b1.Denumire + " are gravitatea mai mare decat bug-ul " + b2.Denumire + ".");
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <(Bug b1, Bug b2)
        {
            if (b1.Severitate < b2.Severitate)
            {
                Console.WriteLine("Bug-ul " + b2.Denumire + " are gravitatea mai mare decat bug-ul " + b1.Denumire + ".");
                return true;
            }
            else
            {
                return false;
            }
        }

        public object Clone()
        {
            return new Bug(this.denumire, this.descriere, this.severitate);
        }

        public int CompareTo(Bug other)
        {
            if (other == null) return 1;

            return this.severitate.CompareTo(other.severitate);
        }
    }

}

