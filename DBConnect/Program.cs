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

            int tast, ID;
            DateTime dato;

            Console.WriteLine("tast 1 for at oprette en kunde");
            Console.WriteLine("tast 2 for at finde en kunde");
            Console.WriteLine("tast 3 for at opdatere en kunde");
            Console.WriteLine("tast 4 for at slette en kunde");

            tast = int.Parse(Console.ReadLine());

            switch (tast)


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
                    dato = DateTime.UtcNow;

                

                    opretKunde(navn, adr, regNr, mærke, model, brændstofstype, årgang, km, dato);
                    sqlDB.Select("select * from kunder");
                    break;

                case 2:
                    sqlDB.Select("select * from kunder");
                    Console.ReadKey();

                    break;

                case 3:
                    sqlDB.Select("select * from kunder");
                    Console.WriteLine("vælg hvilket id der skal opdateres");

                    ID = int.Parse(Console.ReadLine());

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

                    sqlDB.Update($"Update kunder set navn = '{navn}', adr = '{adr}', regNr = '{regNr}', Mærke = '{mærke}', Model = '{model}', Brændstofstype = '{brændstofstype}', årgang = {årgang}, KM = {km} where id = {ID}");

                    break;


                case 4:
                    sqlDB.Select("select * from kunder");
                    Console.WriteLine("vælg hvilket id der skal Slettes");

                    ID = int.Parse(Console.ReadLine());

                    sqlDB.Delete($"Delete from kunder where id = {ID}");


                    break;

            }
            Console.WriteLine("Press the ANY key to exit");
            Console.ReadKey();
           // opretKunde(navn, adr, regNr, mærke, model, brændstofstype, årgang, km);
            //sqlDB.Select("select * from kunder");
        }


        private static void opretKunde(string nv, string adr, string regNr, string mærke, string model, string brændstofstype, int årgang, int km, DateTime dato)
        {
           // string statement = "insert into Kunder values('Knud Andersen', ' telegrafvej 9', 45)";

            string statement = "insert into Kunder (navn, adr, regNr, Mærke, Model, Brændstofstype, årgang, KM) values('"+ nv +"' , '" + adr + "', '" + regNr + "' , '"+ mærke +"' , '"+ model +"', '"+ brændstofstype +"' , " + årgang +", "+ km +")";
            sqlDB.Insert(statement);
        }
      
    }
}

