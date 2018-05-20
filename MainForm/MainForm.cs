using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project;

namespace Interface
{
    public partial class MainForm : Form
    {
        Airline airline = new Airline();
        TotalPasCapCalculator calculator = new TotalPasCapCalculator();

        public MainForm()
        {
            InitializeComponent();
        }
        public void Refresh(Airline airline)
        {
            airlineListBox.Items.Clear();
            EditButton.Enabled = false;
            DeleteButton.Enabled = false;
            foreach (AbstractAircraft aircraft in airline.AircraftList)
            {
                airlineListBox.Items.Add(aircraft.Name);
            }
                TotalCapLabel.Text = Convert.ToString(calculator.GetTotalPasCap(airline));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            airline = AirlineFactory.CreateAirline();
            Refresh(airline);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm(this, airline);
            addForm.ShowDialog();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            EditForm EditForm = new EditForm(this, airline, airline.AircraftList[airlineListBox.SelectedIndex]);
            EditForm.ShowDialog();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            airline.AircraftList.RemoveAt(airlineListBox.SelectedIndex);
            Refresh(airline);
        }

        private void airlineListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (airlineListBox.SelectedItem != null)
            {
                EditButton.Enabled = true;
                DeleteButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("Выберете элемент из списка");
            }
        }
    }
}
