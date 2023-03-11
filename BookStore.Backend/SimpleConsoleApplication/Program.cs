namespace SimpleConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mediator mediator = new TheMediator();
            
            var first = new WorkerFirst(mediator);
            var second = new WorkerSecond(mediator);

            mediator.WorkerFirst = first;
            mediator.WorkerSecond = second;

            first.ZaebashitKurku("msg 1");
            second.ZaebashitKurku("msg 1");
        }
    }
}