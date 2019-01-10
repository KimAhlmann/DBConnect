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
            while (true)
            {
                try
                {

                    Console.Clear();

                    string navn, adr, by, regNr, mærke, model, brændstofstype, noter;

                    int årgang, km, postNr, KundeID, pris, BilID, BesøgsID;

                    int tast, ID;
                    DateTime dato;

                    Console.WriteLine("tast 1 for at oprette en kunde");
                    Console.WriteLine("tast 2 for at oprette en bil");
                    Console.WriteLine("tast 3 for at finde en kunde");
                    Console.WriteLine("tast 4 for at finde en bil");
                    Console.WriteLine("tast 5 for at opdatere en kunde");
                    Console.WriteLine("tast 6 for at opdatere en bil");
                    Console.WriteLine("tast 7 for at slette en kunde");
                    Console.WriteLine("tast 8 for at slette en bil");
                    Console.WriteLine("tast 9 for at oprette værksteds besøg");
                    Console.WriteLine("tast 10 for at rette værksteds besøg");
                    Console.WriteLine("tast 11 for at slette værksteds besøg");
                    Console.WriteLine("tast 12 for at udskrive værkstedsbog");
                    tast = int.Parse(Console.ReadLine());

                    switch (tast)


                    {
                        case 1:

                            Console.WriteLine("Indtast navn");
                            navn = Console.ReadLine();
                            Console.WriteLine("Indtast adresse");
                            adr = Console.ReadLine();
                            Console.WriteLine("Indtast by");
                            by = Console.ReadLine();
                            Console.WriteLine("Indtast postnr");
                            postNr = int.Parse(Console.ReadLine());
                            Console.WriteLine("Indtast regNr");
                      
                            dato = DateTime.UtcNow;



                            opretKunde(navn, adr, by, postNr, dato);
                            sqlDB.Select("select * from kunder", "kunde");
                            break;



                        case 2:


                            sqlDB.Select("select * from kunder", "kunde");


                            Console.WriteLine("Indtast KundeId hvor køretøj skal vedhæftes");
                            KundeID = int.Parse(Console.ReadLine());

                            Console.WriteLine("Indtast regNr");

                            regNr = Console.ReadLine();
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


                            opretBil(KundeID, regNr, mærke, model, brændstofstype, årgang, km, dato);
                            sqlDB.Select("select * from biler", "bil");
                            break;


                        case 3:
                            sqlDB.Select("select * from kunder", "kunde");


                            break;

                        case 4:
                            sqlDB.Select("select * from biler", "biler");

                            break;

                        case 5:

                           

                            sqlDB.Select("select * from kunder", "kunde");
                            Console.WriteLine("vælg hvilket id der skal opdateres");

                            ID = int.Parse(Console.ReadLine());

                            Console.WriteLine("Indtast navn");
                            navn = Console.ReadLine();
                            Console.WriteLine("Indtast adresse");
                            adr = Console.ReadLine();
                            Console.WriteLine("Indtast by");
                            by = Console.ReadLine();
                            Console.WriteLine("Indtast postnr");
                            postNr = int.Parse(Console.ReadLine());



                            sqlDB.Update($"Update kunder set navn = '{navn}', adr = '{adr}', byNavn ='{by}', postNr = {postNr} where id = {ID}");
                            
                         
                            break;


                        case 6:

                          

                            sqlDB.Select("select * from biler", "biler");
                            Console.WriteLine("vælg hvilket BilID der skal opdateres");

                            ID = int.Parse(Console.ReadLine());

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

                            sqlDB.Update($"Update biler set regNr = '{regNr}', mærke = '{mærke}', model = '{model}', brændstofstype = '{brændstofstype}', årgang = {årgang}, km = {km} where BilID = {ID}");


                            
                        
                            
                            break;
                        case 7:

                            sqlDB.Select("select * from kunder", "kunde");
                            Console.WriteLine("vælg hvilket id der skal Slettes");

                            ID = int.Parse(Console.ReadLine());

                            sqlDB.Delete($"Delete from kunder where id = {ID}");


                            break;

                        case 8:

                            sqlDB.Select("select * from biler", "biler");
                            Console.WriteLine("vælg hvilket BilId der skal Slettes");

                            ID = int.Parse(Console.ReadLine());

                            sqlDB.Delete($"Delete from biler where BilId = {ID}");


                            break;



                        case 9:


                           
                  
                            sqlDB.Select("select * from biler", "biler");
                            

                            Console.WriteLine("Indtast BilID på bilen der skal oprettes:..");
                            BilID = int.Parse(Console.ReadLine());
                            Console.WriteLine("Skriv eventuelle Noter");
                            noter = Console.ReadLine(); 
                            Console.WriteLine("Indtast pris");
                            pris = int.Parse(Console.ReadLine());
                            dato = DateTime.UtcNow;

                            OpretVærkstedsBesøg(BilID, noter, pris, dato);
                            sqlDB.Select("select * from VærkstedsBesøg", "besøg");

                            break;



                        case 10:

                            sqlDB.Select("select * from biler", "biler");
                            Console.WriteLine("vælg hvilket BilID der skal opdateres");

                            BilID = int.Parse(Console.ReadLine());
                            Console.WriteLine("Skriv eventuelle Noter");
                            noter = Console.ReadLine();
                            Console.WriteLine("Indtast pris");
                            pris = int.Parse(Console.ReadLine());
                            dato = DateTime.UtcNow;

                            sqlDB.Update($"Update VærkstedsBesøg set noter = '{noter}', pris = '{pris}' where BilID = {BilID}");

                            break;


                        case 11:

                            sqlDB.Select("select * from VærkstedsBesøg", "besøg");
                            Console.WriteLine("vælg hvilket BesøgsID der skal Slettes");

                            BesøgsID = int.Parse(Console.ReadLine());

                            sqlDB.Delete($"Delete from VærkstedsBesøg where BesøgsID = {BesøgsID}");


                            break;


                        case 12:

                            sqlDB.Select("select * from VærkstedsBesøg", "besøg");


                            break;

                        default:

                            Console.WriteLine("Du har tastet forkert...");
                            Console.ReadKey();

                            Environment.Exit(0);

                            break;

                    }
                    Console.WriteLine("Press the ANY key to show menu");
                    Console.ReadKey();
                    // opretKunde(navn, adr, regNr, mærke, model, brændstofstype, årgang, km);
                    //sqlDB.Select("select * from kunder");
                }

                catch (FormatException)
                {
                    Console.WriteLine("Formatet er ikke korrekt.. Press the ANY key ro continue!..");
                    Console.ReadKey();

                }

                catch (NullReferenceException)
                {
                    Console.WriteLine("Indtastet er ikke eksisterende.. Press the ANY key to continue!..");
                    Console.ReadKey();
               
                }
                catch (Exception msg)
                {
                    Console.WriteLine("Noget gik galt, Press the ANY key to continue!..");
                    Console.WriteLine(msg.Message);
                    Console.ReadKey();
                }
      
                Console.Clear();

            }

        }



        private static void opretKunde(string nv, string adr, string by, int postNr, DateTime dato)
        {
            // string statement = "insert into Kunder values('Knud Andersen', ' telegrafvej 9', 45)";
            string statement = "insert into Kunder (navn, adr, byNavn, postNr) values('" + nv + "' , '" + adr + "' , '" + by + "' , '" + postNr + "' )";
            sqlDB.Insert(statement);
        }

        private static void opretBil(int KundeID, string regNr, string mærke, string model, string brændstofstype, int årgang, int km, DateTime dato)
        {
            string statement = "insert into biler (KundeID, regNr, Mærke, Model, brændstofstype, årgang, km) values ('" + KundeID + "','" + regNr + "', '" + mærke + "', '" + model + "', '" + brændstofstype + "', '" + årgang + "', '" + km + "')";
            sqlDB.Insert(statement);

        }

        private static void OpretVærkstedsBesøg(int BilID, string noter, decimal pris, DateTime dato)
        {
            string statement = "insert into VærkstedsBesøg (BilID, Noter, pris) values ('" + BilID + "', '" + noter + "', '" + pris + "')";
            sqlDB.Insert(statement);

        }
    }

}


