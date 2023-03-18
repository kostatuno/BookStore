using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConsoleApplication
{
    abstract class Worker
    {
        protected Mediator mediator { get; set; }
        public Worker(Mediator mediator)
        {
            this.mediator = mediator;
        }

        public abstract void Notify();
    }
}
