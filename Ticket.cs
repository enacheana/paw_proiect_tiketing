using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paw_proiect_tiketing
{
    class Ticket
    {
        private string descriere;
        private int severitate;
        private string status;

        public string Descriere { get => descriere; set => descriere = value; }
        public int Severitate { get => severitate; set => severitate = value; }
        public string Status { get => status; set => status = value; }

        public Ticket(string descriere, int severitate, string status)
        {
            this.descriere = descriere;
            this.severitate = severitate;
            this.status = status;
        }
    }
}
