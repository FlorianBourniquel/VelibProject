using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientConsole.ServiceReferenceVelib;

namespace ClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            IVelib referenceVelib = new VelibClient();
            Console.WriteLine("Tapez help pour avoir la liste des commande");
            string fullCommande = "";
            while (true)
            {
                int deltaSeconde = 0;
                fullCommande = Console.ReadLine();
                string[] commandeSplit = fullCommande.Split(' ');
                string commande = commandeSplit[0];
                if (commandeSplit.Length == 1)
                {
                    switch (commande)
                    {
                        case "help":
                            Console.WriteLine("Liste des commande : ");
                            Console.WriteLine("{deltaSeconde} indique le delta en seconde depuis la derniere mise à jour des données");
                            Console.WriteLine("ville {deltaSeconde}: Obtenir la liste des villes");
                            Console.WriteLine("NomStationParVille {NomVille} {deltaSeconde}: Obtenir la liste des noms des stations d'une ville");
                            Console.WriteLine("InfoStation {NomVille} {NomStation} {deltaSeconde}: Obtenir le nombre de velos disponible dans la station");
                            Console.WriteLine("quitter : quitter l'application");
                            break;
                        case "quitter":
                            return;
                        default:
                            Console.WriteLine("Commande inconue tapez help pour la liste des commandes disponibles");
                            break;
                    }
                }
                else if (commandeSplit.Length == 2)
                {
                    switch (commande)
                    {
                        case "ville":
                            try
                            {
                                deltaSeconde = Int32.Parse(commandeSplit[1]);
                            }
                            catch (FormatException e)
                            {
                                Console.WriteLine("{deltaSeconde} n'est pas un nombre");
                                break;
                            }
                            List<Ville> villes = referenceVelib.GetVille(deltaSeconde).ToList();
                            if (villes.Count == 0)
                            {
                                Console.WriteLine("Bad Request");
                                break;
                            }
                            foreach (var ville in villes)
                            {
                                Console.WriteLine(VilleToString(ville));
                            }

                            break;
                        case "help":
                            Console.WriteLine("Liste des commande : ");
                            Console.WriteLine("{deltaSeconde} indique le delta en seconde depuis la derniere mise à jour des données");
                            Console.WriteLine("ville {deltaSeconde}: Obtenir la liste des villes");
                            Console.WriteLine("NomStationParVille {NomVille} {deltaSeconde}: Obtenir la liste des noms des stations d'une ville");
                            Console.WriteLine("InfoStation {NomVille} {NomStation} {deltaSeconde}: Obtenir le nombre de velos disponible dans la station");
                            Console.WriteLine("quitter : quitter l'application");
                            break;
                        case "quitter":
                            return;
                        default:
                            Console.WriteLine("Commande inconue tapez help pour la liste des commandes disponibles");
                            break;
                    }
                }
                else if (commandeSplit.Length == 3)
                {
                    try
                    {
                        deltaSeconde = Int32.Parse(commandeSplit[2]);
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("{deltaSeconde} n'est pas un nombre");
                        break;
                    }
                    switch (commande)
                    {
                        case "NomStationParVille":
                            List<string> stations = referenceVelib.GetNomStationParVille(commandeSplit[1],deltaSeconde).ToList();
                            foreach (var station in stations)
                            {
                                Console.WriteLine(station);
                            }
                            break;
                        default:
                            Console.WriteLine("Commande inconue tapez help pour la liste des commandes disponibles");
                            break;
                    }
                }
                else if (commandeSplit.Length >= 4)
                {
                    try
                    {
                        deltaSeconde = Int32.Parse(commandeSplit[commandeSplit.Length-1]);
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("{deltaSeconde} n'est pas un nombre");
                        break;
                    }
                    switch (commande)
                    {
                        case "InfoStation":
                            Station station =
                                referenceVelib.GetInformationStation(commandeSplit[1], ReformatParam(commandeSplit),deltaSeconde);
                            if (station == null)
                            {
                                Console.WriteLine("Bad Request");
                                break;
                            }
                            Console.WriteLine("Nombre de velos disponibles dans la station : " + station.available_bikes);
                            break;
                        default:
                            Console.WriteLine("Commande inconue tapez help pour la liste des commandes disponibles");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Commande inconue tapez help pour la liste des commandes disponibles");
                }
            }
        }

        static string VilleToString(Ville ville)
        {
            return ville.name;
        }

        static string ReformatParam(string[] strings)
        {
            string resultat = "";
            for (int i = 2; i < strings.Length - 1; i++)
            {
                resultat = resultat + strings[i];
            }

            return resultat;
        }

       
    }
}