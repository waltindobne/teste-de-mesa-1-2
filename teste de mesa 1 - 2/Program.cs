using System;

namespace testeDeMesa2
{
    class Program
    {
        static void Main(string[] args)
        {
            Objects objects = new Objects();
            objects.Loop();
        }
    }
    public class Objects() 
    {
        int a = 2;
        string c = "verdadeiro";
        int i = 0;
        public void Loop()
        {
            while(a <= 6)
            {
                ++a;
                i++;
                if(a-1 == 6)
                {
                    c = "Falso";
                }
                Console.WriteLine($"posição: {i-1}, variavel: {a-1}, vetor[{i-1}]: {a*10}, contador: {a}, condição: {c}");
            }
        }
    }
}