using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConsoleApplication
{
    abstract class Mediator
    {
        public WorkerFirst WorkerFirst { get; set; }
        public WorkerSecond WorkerSecond { get; set; }
        public abstract void Send(string msg, Worker worker);
    }
}
