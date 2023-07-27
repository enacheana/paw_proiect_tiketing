using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paw_proiect_tiketing
{
    class Programmer:IClonable, IComparable<Programmer>
    {
        private string nume;
        private int nivelExperienta;
        private int varsta;
        private List<string> limbaje;

        public string Nume { get => nume; set => nume = value; }
        public int NivelExperienta { get => nivelExperienta; set => nivelExperienta = value; }
        public int Varsta { get => varsta; set => varsta = value; }
        public List<string> Limbaje { get => limbaje; set => limbaje = value; }

        public Programmer(string nume, int nivelExperienta, int varsta, List<string> limbaje)
        {
            this.nume = nume;
            this.nivelExperienta = nivelExperienta;
            this.varsta = varsta;
            Limbaje = limbaje;
        }

        public static Programmer operator +(Programmer p1, Programmer p2)
        {
            return new Programmer(p1.Nume + " " + p2.Nume, p1.NivelExperienta + p2.NivelExperienta, p1.Varsta+p2.varsta, new List<string>(p1.Limbaje.Concat(p2.Limbaje)))
            {
                Nume = p1.Nume + " " + p2.Nume,
                NivelExperienta = p1.NivelExperienta + p2.NivelExperienta
            };
        }
        public object Clone()
        {
            return new Programmer(this.nume, this.nivelExperienta, this.varsta, new List<string>(Limbaje));
        }

        public int CompareTo(Programmer other)
        {
            if (other == null) return 1;

            return this.nivelExperienta.CompareTo(other.nivelExperienta);
        }

        public bool KnowsLanguage(string limbaje)
        {
            return Limbaje.Contains(limbaje);
        }

        public int GetTotalLanguagesKnown()
        {
            return Limbaje.Count;
        }

        public override string ToString()
        {
            return $"Nume: {Nume}, Nivel Experienta: {NivelExperienta}, Varsta: {Varsta}, Limbaje: {string.Join(", ", Limbaje)}";
        }

    }

}

