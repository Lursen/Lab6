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
    public partial class EditForm : Form
    {
        private MainForm refForm;
        private Airline airline;
        private AbstractAircraft aircraft;

        public EditForm()
        {
            InitializeComponent();
        }

        public EditForm(MainForm refForm, Airline airline, AbstractAircraft aircraft)
        {
            InitializeComponent();
            this.refForm = refForm;
            this.airline = airline;
            this.aircraft = aircraft;
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            if (aircraft is PassengerAirliner)
            {
                PassengerAirliner PasAir = (PassengerAirliner) aircraft;
                ClassLabel.Text = "Passenger Airliner";
                NameBox.Text = aircraft.Name;
                PasCapBox.Text = aircraft.PasCap.ToString();
                VarLabel.Text = "Staff Capacity";
                VarBox.Text = PasAir.StaffCap.ToString();
            }
            else if (aircraft is CargoPlane)
            {
                CargoPlane CargoAir = (CargoPlane)aircraft;
                ClassLabel.Text = "Cargo Plane";
                NameBox.Text = CargoAir.Name;
                PasCapBox.Text = CargoAir.PasCap.ToString();
                VarLabel.Text = "Load Capacity, kg";
                VarBox.Text = CargoAir.LoadCap.ToString();
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (aircraft is PassengerAirliner)
                {
                    PassengerAirliner PasAir = (PassengerAirliner)aircraft;
                    PasAir.Name = NameBox.Text;
                    if (Convert.ToInt32(PasCapBox.Text) >= 0 && Convert.ToInt32(VarBox.Text) >= 0)
                    {
                        PasAir.PasCap = Convert.ToInt32(PasCapBox.Text);
                        PasAir.StaffCap = Convert.ToInt32(VarBox.Text);
                    }
                    else
                    {
                        MessageBox.Show("Введены некорректные данные");
                    }
                }
                else if (aircraft is CargoPlane)
                {
                    CargoPlane CargoAir = (CargoPlane)aircraft;
                    CargoAir.Name = NameBox.Text;
                    if (Convert.ToInt32(PasCapBox.Text) >= 0 && Convert.ToInt32(VarBox.Text) >= 0)
                    {
                        CargoAir.PasCap = Convert.ToInt32(PasCapBox.Text);
                        CargoAir.LoadCap = Convert.ToInt32(VarBox.Text);
                    }
                    else
                    {
                        MessageBox.Show("Введены некорректные данные");
                    }
                }   
                refForm.Refresh(airline);
                Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены некорректные данные");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            refForm.Refresh(airline);
            Close();
        }
    }
}
