namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cua<object> c1 = new Cua<object>();
            Cua<object> c2 = new Cua<object>();

            Console.WriteLine("INICADA LA CUA");
            Console.WriteLine(c1);

            c1.Encua("A");
            c1.Encua("B");
            c1.Encua("C");
            c1.Encua("D");
            c1.Encua("E");

            Console.WriteLine("ENCUEM ELEMENTS");
            Console.WriteLine(c1);
            Console.WriteLine();

            c1.Desencua();
            c1.Desencua();

            Console.WriteLine("HAN ATÉS A [A] I [B]");
            Console.WriteLine(c1);
            Console.WriteLine();

            Console.WriteLine("QUI ES EL PRIMER ARA?");
            Console.WriteLine("[" + c1.Primer + "]");
            Console.WriteLine();

            Console.WriteLine("LA CUA ÉS BUIDA?");
            Console.WriteLine(c1.EsBuida);
            Console.WriteLine();

            c1.Desencua();
            c1.Desencua();
            c1.Desencua();

            Console.WriteLine("ATENEN A TOTS!!!");
            Console.WriteLine(c1);
            Console.WriteLine();

            Console.WriteLine("I ARA, ÉS BUIDA?");
            Console.WriteLine(c1.EsBuida);
            Console.WriteLine();

            c1.Encua("A");
            c1.Encua("B");
            c1.Encua("C");
            c1.Encua("D");
            c1.Encua("E");

            c2.Encua("A");
            c2.Encua("B");
            c2.Encua("C");
            c2.Encua("D");
            c2.Encua("E");

            Console.WriteLine();
            Console.WriteLine("LES CUES [C1] I [C2] SÓN IGUALS?");
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine();
            Console.WriteLine(c1.Equals(c2));
            Console.WriteLine();

            c1.Desencua();

            Console.WriteLine();
            Console.WriteLine("I ARA?");
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine();
            Console.WriteLine(c1.Equals(c2));
            Console.WriteLine();

            c1.Encua("A");

            Console.WriteLine();
            Console.WriteLine("I ARA?");
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine();
            Console.WriteLine(c1.Equals(c2));
            Console.WriteLine();
        }
    }
}
