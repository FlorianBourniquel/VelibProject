using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bourniquel.ServiceReference1;
using Newtonsoft.Json;

namespace Bourniquel
{
    public partial class Form1 : Form
    {
        private bool async = false;
        private List<String> nomsStations;
        private List<Ville> villes;
        private IVelib velibService = new VelibClient();

        public Form1()
        {
            InitializeComponent();
            if (async)
            {
                Init();
            }
            else
            {
                try
                {
                    villes = velibService.GetVille(Convert.ToInt32(textBoxTime.Text)).ToList();
                    // Display the content. 
                    listBoxVille.Items.Clear();
                    foreach (var obj in villes) listBoxVille.Items.Add(obj.name);
                }
                catch (Exception exception)
                {
                    listBoxVille.Items.Add(exception.ToString());
                }
            }
        }

        private async void Init()
        {
            try
            {
                Task<Ville[]> task = velibService.GetVilleAsync(Convert.ToInt32(textBoxTime.Text));
                villes = (await task).ToList();
                // Display the content. 
                listBoxVille.Items.Clear();
                foreach (var obj in villes) listBoxVille.Items.Add(obj.name);
            }
            catch (Exception exception)
            {
                listBoxVille.Items.Add(exception.ToString());
            }
        }


        private async void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxStation.SelectedItem != null)
            {
                Station stationSelected;
                if (async)
                {
                    Task<Station> task = velibService.GetInformationStationAsync(listBoxVille.SelectedItem.ToString(),
                        listBoxStation.SelectedItem.ToString(),Convert.ToInt32(textBoxTime.Text));
                    stationSelected = await task;
                }
                else
                {
                    stationSelected = velibService.GetInformationStation(listBoxVille.SelectedItem.ToString(),
                        listBoxStation.SelectedItem.ToString(),Convert.ToInt32(textBoxTime.Text));
                }

                listBoxInfoStation.Items.Clear();
                var duration = new TimeSpan(stationSelected.last_update);
                var result = $"{duration.Days} days, {duration.Hours} hours, {duration.Minutes} minutes";
                listBoxInfoStation.Items.Add("Nom: " + stationSelected.name);
                listBoxInfoStation.Items.Add("Adresse: " + stationSelected.address);
                listBoxInfoStation.Items.Add("Position: " + stationSelected.position);
                listBoxInfoStation.Items.Add("Presence de bornes de paiement: " + stationSelected.banking);
                listBoxInfoStation.Items.Add("Bonus: " + stationSelected.bonus);
                listBoxInfoStation.Items.Add("Status: " + stationSelected.status);
                listBoxInfoStation.Items.Add("Nombre de points d'attache opérationnels: " +
                                             stationSelected.bike_stands);
                listBoxInfoStation.Items.Add("Nombre de points d'attache disponibles pour y ranger un vélo: " +
                                             stationSelected.available_bike_stands);
                listBoxInfoStation.Items.Add("Nombre de vélos disponibles: " + stationSelected.available_bikes);
                listBoxInfoStation.Items.Add("Derniere update: " + result);
            }
        }

        private async void listBoxVille_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (async)
                {
                    Task<string[]> task = velibService.GetNomStationParVilleAsync(listBoxVille.SelectedItem.ToString(),Convert.ToInt32(textBoxTime.Text));
                    nomsStations = (await task).ToList();
                }
                else
                {
                    nomsStations = velibService.GetNomStationParVille(listBoxVille.SelectedItem.ToString(),Convert.ToInt32(textBoxTime.Text)).ToList();
                }
               
                // Display the content. 
                listBoxStation.Items.Clear();
                foreach (var obj in nomsStations) listBoxStation.Items.Add(obj);
            }
            catch (Exception exception)
            {
                listBoxStation.Items.Add(exception.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            async = !async;
            button1.Text = async ? "ON" : "OFF";
        }

        private void textBoxTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))   
            {
                e.Handled = true;
            }
        }
    }
}