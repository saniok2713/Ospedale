using System;
using System.Collections.Generic;

namespace Ospedale
{

    class Program
    {

        public const int BAD = -1;
        static void Main(string[] args)
        {
            int scelta, matricola = 0, index_m = 0, index_p = 0;
            string cognome, nome, cf, risposta;

            List<Medico> medici = new List<Medico>();
            List<Paziente> pazienti = new List<Paziente>();


            do
            {
                Console.WriteLine("1: Nuovo Medico");
                Console.WriteLine("2: Nuovo paziente");
                Console.WriteLine("3: Assegna medico al paziente");
                Console.WriteLine("4: Visualizza medici");
                Console.WriteLine("5: Scheda paziente");
                Console.WriteLine("0: Esci");
                Console.Write("Scelta: ");
                scelta = Convert.ToInt32(Console.ReadLine());
                switch (scelta)
                {
                    case 0:
                        Console.WriteLine("Uscita!\n");
                        break;
                    case 1:
                        inserisci_medico();
                        break;
                    case 2:
                        inserisci_paziente();
                        break;
                    case 3:
                        assegna_paziente();
                        break;
                    case 4:
                        visualizza_medici();
                        break;
                    case 5:
                        scheda_paziente();
                        break;
                    default:
                        Console.WriteLine("Numero non valido!\n");
                        break;
                }

            } while (scelta != 0);

            void inserisci_medico()
            {
                Console.Write("Inserisci cognome: ");
                cognome = Console.ReadLine();
                Console.Write("Inserisci nome: ");
                nome = Console.ReadLine();
                Console.WriteLine();
                matricola++;
                medici.Add(new Medico(cognome, nome, matricola));
            }

            void inserisci_paziente()
            {
                Console.Write("Inserisci cognome: ");
                cognome = Console.ReadLine();
                Console.Write("Inserisci nome: ");
                nome = Console.ReadLine();
                Console.Write("Inserisci CF: ");
                cf = Console.ReadLine();
                Console.WriteLine();
                pazienti.Add(new Paziente(cognome, nome, cf));
            }

            void assegna_paziente()
            {
                Console.Write("Inserisci la matricola del medico: ");
                matricola = Convert.ToInt32(Console.ReadLine());
                index_m = medici.FindIndex(medico => medico.Matricola == matricola);
                if (index_m == BAD)
                {
                    Console.WriteLine("Medico non trovato!\n");
                }
                else
                {
                    Console.Write("Inserisci il CF del paziente: ");
                    cf = Console.ReadLine();
                    index_p = pazienti.FindIndex(p => p.CF == cf);
                    if (index_p == BAD)
                    {
                        Console.WriteLine("Paziente non trovato!\n");
                    }
                    else
                    {
                        if (medici[index_m].Num_pazienti >= 500)
                        {
                            Console.Write("Il medico non puo avere piu di 500 pazienti!\n: ");
                        }
                        else
                        {
                            Console.WriteLine("Cognome: {0} Nome: {1}", medici[index_m].Cognome, medici[index_m].Nome);
                            Console.WriteLine("Cognome: {0} Nome: {1}", pazienti[index_p].Cognome, pazienti[index_p].Nome);
                            Console.Write("Vuoi assegnare il paziente al medico? (si/no) ");
                            risposta = Console.ReadLine();
                            if (risposta == "no")
                            {
                                Console.WriteLine("Cancellato!\n");
                            }
                            else
                            {
                                pazienti[index_p].Medico_Assegnato = matricola;
                                medici[index_m].Num_pazienti++;
                                Console.WriteLine("Medico assegnato!\n");
                            }

                        }
                    }
                }
            }

            void visualizza_medici()
            {
                foreach (Medico medico in medici)
                {
                    Console.WriteLine("Matricola: {0} Cognome: {1} Nome: {2}", medico.Matricola, medico.Cognome, medico.Nome);
                    Console.WriteLine();
                }
            }

            void scheda_paziente()
            {
                Console.Write("Inserisci il CF del paziente: ");
                cf = Console.ReadLine();
                index_p = pazienti.FindIndex(p => p.CF == cf);
                if (index_p == BAD)
                {
                    Console.WriteLine("Paziente non trovato!\n");
                }
                else
                {
                    Console.WriteLine("Cognome: {0} Nome: {1}", pazienti[index_p].Cognome, pazienti[index_p].Nome);
                    Console.WriteLine("Medico di base:");
                    foreach (Medico medico in medici)
                    {
                        if (pazienti[index_p].Medico_Assegnato == medico.Matricola)
                        {
                            Console.WriteLine("Cognome: {0} Nome: {1}", medico.Cognome, medico.Nome);
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
    }
}
