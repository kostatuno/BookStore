using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConsoleApplication
{
    class WorkerSecond : Worker
    {
        public WorkerSecond(Mediator mediator) : base(mediator)
        {
        }

        public override void Notify()
        {
            Console.WriteLine("worker second");
        }

        public void ZaebashitKurku(string msg)
        {
            mediator.Send(msg, this);
        }
    }
}
