using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paw_proiect_tiketing
{
    class Solution
    {
        private List<Programmer> programmersInvolved;
        private string descriereSolutie;
        private DateTime dateImplemented;
        //private int[,] matrix;

        internal List<Programmer> ProgrammersInvolved { get => programmersInvolved; set => programmersInvolved = value; }
        public string DescriereSolutie { get => descriereSolutie; set => descriereSolutie = value; }
        public DateTime DateImplemented { get => dateImplemented; set => dateImplemented = value; }
       // public int[,] Matrix { get => matrix; set => matrix = value; }

        public Solution(List<Programmer> programmersInvolved, string descriereSolutie, DateTime dateImplemented, int[,]matrix)
        {
            ProgrammersInvolved = programmersInvolved;
            this.descriereSolutie = descriereSolutie;
            DateImplemented = dateImplemented;
           // this.matrix = matrix;
        }

    }
}

