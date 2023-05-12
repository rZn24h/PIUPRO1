
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiectPiu
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            MagazinJocuriVideo magazin = new MagazinJocuriVideo();
            bool continua = true;

            while (continua)
            {
                Console.Clear();
                Console.WriteLine("============================================================");
                Console.WriteLine("           GESTIONARE MAGAZIN JOCURI VIDEO");
                Console.WriteLine("============================================================");
                Console.WriteLine();
                Console.WriteLine("1. Adauga joc");
                Console.WriteLine("2. Afisare jocuri");
                Console.WriteLine("3. Salvare jocuri in fisier");
                Console.WriteLine("4. Stergere jocuri");
                Console.WriteLine("5. Adauga utilizator");
                Console.WriteLine("6. Afiseaza utilizator");
                Console.WriteLine("7. Salvare utilizator in fisier");
                Console.WriteLine("8. Stergere useri");
                Console.WriteLine();
                Console.Write("Selectati o optiune: ");
                string optiune = Console.ReadLine();

                switch (optiune)
                {
                    case "1":
                        Console.WriteLine("Ati selectat optiunea <<Adauga joc>>");
                        magazin.AdaugaJoc();
                        Console.ReadLine();
                        break;

                    case "2":
                        Console.WriteLine("Ati ales optiunea <<Afisare jocuri>>");                       
                        Console.WriteLine(string.Join("\n",magazin.GetJocuri()));
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine("Ati ales optiunea <<Salvare jocuri in fisier>>");
                        Console.WriteLine("Introduceti numele fisierului in care doriti sa salvati jocurile");
                        string nume_fisier = Console.ReadLine();
                        magazin.SalveazaJocuriInFisier(nume_fisier);
                        Console.WriteLine("Respectati forma: ID Nume Descriere Pret Stoc");
                        Console.ReadLine();
                        break;
                    case "4":
                        Console.WriteLine("Ati ales optiunea <<Stergere jocuri>>");
                        Console.WriteLine(string.Join("\n", magazin.GetJocuri()));
                        Console.WriteLine("Introduceti id-ul jocurilui care doriti sa fie sters");
                        int id_joc = Convert.ToInt32(Console.ReadLine());
                        for(int i = 0; i < magazin.GetJocuri().Count; i++)
                        {
                            if(id_joc == magazin.GetJocuri()[i].Id)
                            {
                                magazin.GetJocuri().RemoveAt(i);
                            }
                        }
                        break;
                    case "5":
                        Console.WriteLine("Ati ales optiunea <<Adauga utilizator>");
                        magazin.AdaugaUser();
                        Console.ReadLine();
                        break;
                    case "6":
                        Console.WriteLine("Ati ales optiunea <<Afisare utilizatori>>");
                        Console.WriteLine(string.Join("\n", magazin.GetUsers()));
                        Console.ReadLine();
                        break;
                    case "7":
                        Console.WriteLine("Ati ales optiunea <<Salvare useri in fisier>>");
                        Console.WriteLine("Introduceti numele fisierului in care doriti sa salvati utilizatorii");
                        string nume_fisier1 = Console.ReadLine();
                        magazin.SalveazauseriInFisier(nume_fisier1);
                        Console.WriteLine("Respectati forma: ID Nume Email Parola");
                        Console.ReadLine();
                        break;
                    case "8":
                        Console.WriteLine("Ati ales optiunea <<Stergere useri>>");
                        Console.WriteLine(string.Join("\n", magazin.GetJocuri()));
                        Console.WriteLine("Introduceti id-ul userului care doriti sa fie sters");
                        int id_user = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < magazin.GetUsers().Count; i++)
                        {
                            if (id_user == magazin.GetUsers()[i].Id)
                            {
                                magazin.GetUsers().RemoveAt(i);
                            }
                        }
                        break;

                }

            }
        }
    }
}
