using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CheckBTN_Click(object sender, EventArgs e)
        {
            var result = int.TryParse(AgeTextBox.Text, out var age);
            if (!result || string.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                ResultLabel.ForeColor = Color.Red;
                ResultLabel.Text = "Niepoprawny wiek lub brak imienia!";
            }
            else if(age > 17)
            {
                ResultLabel.ForeColor = Color.Green;
                ResultLabel.Text = string.Format("{0}! Proszę oto twoje piwo!", NameTextBox.Text);
            }
            else
            {
                ResultLabel.ForeColor = Color.Red;
                ResultLabel.Text = $"{NameTextBox.Text}! Nie mogę podać Ci piwa jesteś niepełnoletni.";
            }
        }
    }
}
