namespace TestConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CancellationTokenSource cancelTokenSource = new CancellationTokenSource();
            CancellationToken token = cancelTokenSource.Token;

            Task task = new Task(() => PrintSquares(token), token);
            try
            {
                task.Start();
                Thread.Sleep(1000);
                // после задержки по времени отменяем выполнение задачи
                cancelTokenSource.Cancel();

                // ожидаем завершения задачи
                task.Wait();
            }
            catch (AggregateException ae)
            {
                foreach (Exception e in ae.InnerExceptions)
                {
                    if (e is TaskCanceledException)
                        Console.WriteLine("Операция прервана");
                    else
                        Console.WriteLine(e.Message);
                }
            }
            finally
            {
                cancelTokenSource.Dispose();
            }

            //  проверяем статус задачи
            Console.WriteLine($"Task Status: {task.Status}");


            void PrintSquares(CancellationToken token)
            {
                for (int i = 1; i < 10; i++)
                {
                    if (token.IsCancellationRequested)
                        token.ThrowIfCancellationRequested(); // генерируем исключение

                    Console.WriteLine($"Квадрат числа {i} равен {i * i}");
                    Thread.Sleep(200);
                }
            }
        }
    }
}