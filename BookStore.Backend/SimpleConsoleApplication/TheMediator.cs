using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConsoleApplication
{
    class TheMediator : Mediator
    {
        public override void Send(string msg, Worker worker)
        {
            if (worker == WorkerFirst)
            {
                WorkerFirst.Notify();
            }
            else if (worker == WorkerSecond)
            {
                WorkerSecond.Notify();
            }
        }
    }
}
