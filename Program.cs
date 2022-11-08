using System.Diagnostics;
using ThreadState = System.Diagnostics.ThreadState;

public class test
{
    public static void Main()
    {
        Stopwatch sw = Stopwatch.StartNew();

        Thread thread = new Thread(new ThreadStart(test.eitaPoh));
        thread.Start();

        Thread thread1 = new Thread(new ThreadStart(test.eitaPreula));
        thread1.Start();

        for (int i = 0; i < 100000; i++){
            Console.WriteLine(i + " esse é do Main");
            testeWhile();
        }

        sw.Stop();
        Console.WriteLine("Elapsed Time is {0} ms", sw.ElapsedMilliseconds);

        if (!thread.ThreadState.Equals(ThreadState.Running))
            thread.Interrupt();
        if(!thread1.ThreadState.Equals(ThreadState.Running))
            thread1.Interrupt();
    }

    public static void eitaPoh()
    {
        for(int i = 0; i < 100000; i++){
            Console.WriteLine(i + " essa Thread é cabulosa");
            testeWhile();
        }
    }

    public static void eitaPreula()
    {
        for(int i = 0; i < 100000; i++){
            Console.WriteLine(i + " esse é do eitaPreula");
            testeWhile();
        }
    }

    private static void testeWhile()
    {
        int i = 0;
        while(i < 1){
            Console.WriteLine("-----------------------------------------");
            i++;
        }
    }
}