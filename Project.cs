using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paw_proiect_tiketing
{
    class Project
    {
        private List<Bug> bugs;
        private List<Programmer> programmers;
        private List<Solution> solutions;

        internal List<Bug> Bugs { get => bugs; set => bugs = value; }
        internal List<Programmer> Programmers { get => programmers; set => programmers = value; }
        internal List<Solution> Solutions { get => solutions; set => solutions = value; }

        public Project(List<Bug> bugs, List<Programmer> programmers, List<Solution> solutions)
        {
            Bugs = bugs;
            Programmers = programmers;
            Solutions = solutions;
        }
    }
}
