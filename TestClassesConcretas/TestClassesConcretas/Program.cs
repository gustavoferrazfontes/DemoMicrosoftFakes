using System;

namespace TestClassesConcretas
{
    public class Program
    {
        static void Main(string[] args)
        {
            Saudacao saudacao = new Saudacao();
            Console.WriteLine(saudacao.Saudar());

            Console.ReadKey();
        }
    }

    public class Saudacao
    {
        public string Saudar()
        {
            if (DateTime.Now.TimeOfDay <= new TimeSpan(11, 59, 59))
                return "Bom dia!";
            else if (DateTime.Now.TimeOfDay > new TimeSpan(11, 59, 59) && DateTime.Now.TimeOfDay <= new TimeSpan(17, 59, 59))
                return "Boa tarde!";

            else if (DateTime.Now.TimeOfDay > new TimeSpan(17, 59, 59))
                return "Boa noite!";


            return string.Empty;
        }
    }
}
