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
    public partial class AddForm : Form
    {
        private MainForm mainForm;
        private Airline airline;

        public AddForm()
        {
            InitializeComponent();
        }

        public AddForm (MainForm mainForm, Airline airline)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.airline = airline;
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            ClassSelectComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            label4.Visible = false;
            VarBox.Visible = false;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            mainForm.Refresh(airline);
            Close();
        }

        private void ClassSelectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ClassSelectComboBox.SelectedIndex == 0)
            {
                NameBox.Text = "";
                PasCapBox.Text = "";
                label4.Text = "Staff Capacity";
                label4.Visible = true;
                VarBox.Visible = true;
            }

            else if (ClassSelectComboBox.SelectedIndex == 1)
            {
                NameBox.Text = "";
                PasCapBox.Text = "";
                label4.Text = "Load Capacity, kg";
                label4.Visible = true;
                VarBox.Visible = true;
            }

        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (ClassSelectComboBox.SelectedItem == null)
            {
                MessageBox.Show("Класс самолёта не выбран");
            }
            else
            {
                try
                {
                    if (ClassSelectComboBox.SelectedIndex == 0)
                    {
                        PassengerAirliner pasAir = new PassengerAirliner();
                        pasAir.Name = NameBox.Text;
                        if (Convert.ToInt32(PasCapBox.Text) >= 0 && Convert.ToInt32(VarBox.Text) >= 0)
                        {
                            pasAir.PasCap = Convert.ToInt32(PasCapBox.Text);
                            pasAir.StaffCap = Convert.ToInt32(VarBox.Text);
                            airline.AddPlane(pasAir);
                        }
                        else
                        {
                            MessageBox.Show("Некорректные данные");
                        }
                        mainForm.Refresh(airline);
                        Close();
                    }
                    else if (ClassSelectComboBox.SelectedIndex == 1)
                    {
                        CargoPlane cargoAir = new CargoPlane();
                        cargoAir.Name = NameBox.Text;
                        if (Convert.ToInt32(PasCapBox.Text) >= 0 && Convert.ToInt32(VarBox.Text) >= 0)
                        {
                            cargoAir.PasCap = Convert.ToInt32(PasCapBox.Text);
                            cargoAir.LoadCap = Convert.ToDouble(VarBox.Text);
                            airline.AddPlane(cargoAir);
                        }
                        else
                        {
                            MessageBox.Show("Некорректные данные");
                        }
                        mainForm.Refresh(airline);
                        Close();
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Некорректные данные");
                }
            }

        }
    }
}
