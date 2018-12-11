using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnect
{
    class Program
    {
        static void Main(string[] args)
        {

            // opretter en kunde

            string navn, adr, regNr, mærke, model, brændstofstype;

            int årgang, km;

            int tast;

            Console.WriteLine("tast 1 for at oprette en kunde");
            Console.WriteLine("tast 2 for at finde en kunde");
            Console.WriteLine("tast 3 for at opdatere en kunde");
            Console.WriteLine("tast 4 for at slette en kunde");

            tast = int.Parse(Console.ReadLine());

            switch (tast == 1)


            {
                case 1:

                    Console.WriteLine("Indtast navn");
                    navn = Console.ReadLine();
                    Console.WriteLine("Indtast adresse");
                    adr = Console.ReadLine();
                    Console.WriteLine("Indtast regNr");
                    regNr = Console.ReadLine(); ;
                    Console.WriteLine("Indtast Mærke");
                    mærke = Console.ReadLine();
                    Console.WriteLine("Indtast Model");
                    model = Console.ReadLine();
                    Console.WriteLine("Indtast Brændstofstype");
                    brændstofstype = Console.ReadLine();
                    Console.WriteLine("årgang");
                    årgang = int.Parse(Console.ReadLine());
                    Console.WriteLine("Indtast Kilometer");
                    km = int.Parse(Console.ReadLine());

                    break;

                case 2:
                    sqlDB.Select("select * from kunder");
                    Console.ReadKey();

                    break;

                case 3:
            }


            opretKunde(navn, adr, regNr, mærke, model, brændstofstype, årgang, km);
            sqlDB.Select("select * from kunder");
            Console.ReadKey();
        }


        private static void opretKunde(string nv, string adr, string regNr, string mærke, string model, string brændstofstype, int årgang, int km)
        {
           // string statement = "insert into Kunder values('Knud Andersen', ' telegrafvej 9', 45)";

            string statement = "insert into Kunder values('"+ nv +"' , '" + adr + "', '" + regNr + "' , '"+ mærke +"' , '"+ model +"', '"+ brændstofstype +"' , " + årgang +", "+ km +")";
            sqlDB.Insert(statement);
        }


    }
}

