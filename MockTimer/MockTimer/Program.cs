using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using MockTimer.TimerService;

namespace MockTimer
{
    class Program
    {
        private static System.Timers.Timer timer;
        public static ITimer referenceTimer = new TimerClient();
        public static bool isON = false;

        static void Main(string[] args)
        {
            string fullCommande = "";
            int nbsecondes = 0;
            Console.WriteLine("Liste des commande : ");
            Console.WriteLine("On {nbsecondes} : declenche le StationUpdate evenement toutes les nbsecondes secondes");
            Console.WriteLine("Off : interompt le StationUpdate evenement");
            while (true)
            {
                fullCommande = Console.ReadLine();
                string[] commandeSplit = fullCommande.Split(' ');
                string commande = commandeSplit[0];

                if (commandeSplit.Length == 2)
                {
                    try
                    {
                        nbsecondes = Int32.Parse(commandeSplit[1]);
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("{nbsecondes} n'est pas un nombre");
                        break;
                    }
                    switch (commande)
                    {
                        case "On":
                            if (!isON)
                            {
                                timer = new System.Timers.Timer(10000);

                                // Hook up the Elapsed event for the timer.
                                timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);

                                // Set the Interval.
                                timer.Interval = nbsecondes*1000;
                                timer.Enabled = true;
                                isON = true;
                            }
                            break;
                        default:
                            Console.WriteLine("Commande inconue");
                            break;
                    }
                }
                else if (commandeSplit.Length == 1)
                {
                    switch (commande)
                    {
                        case "Off":
                            if (isON)
                            {
                                timer.Enabled = false;
                                isON = false;
                            }
                            break;
                        default:
                            Console.WriteLine("Commande inconue");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Commande inconue");
                }
            }
        }

        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            try
            {
                referenceTimer.TriggerUpdate();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            
        }
    }
}
