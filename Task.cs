using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paw_proiect_tiketing
{
    public abstract class Task
    {
        private string description;
        private DateTime dueDate;
        private bool isComplete;

        public string Description { get => description; set => description = value; }
        public DateTime DueDate { get => dueDate; set => dueDate = value; }
        public bool IsComplete { get => isComplete; set => isComplete = value; }

        public abstract void Execute();

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
