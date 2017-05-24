using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary__FootballStars
{
    public partial class Form1 : Form
    {
        Dictionary<int, JerseyNumber> retiredNumbers = new Dictionary<int, JerseyNumber>()
        {
            { 3, new JerseyNumber("First player",1948)},
            { 4, new JerseyNumber("Second Player", 1939)},
            { 5, new JerseyNumber("Third Player", 1969)},
            { 7, new JerseyNumber("Fourth", 1970) },
            { 8, new JerseyNumber("First player",1948)},
            { 10, new JerseyNumber("Second Player", 1939)},
            { 23, new JerseyNumber("Third Player", 1969)},
            { 42, new JerseyNumber("Fourth", 1970) }
        };

        public Form1()
        {
            InitializeComponent();
            foreach (int key in retiredNumbers.Keys)
                comboBox1.Items.Add(key);   
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            JerseyNumber jerseyNumber = retiredNumbers[(int)number.SelectedItem];
            nameLabel.Text = jerseyNumber.Player;
            yearLabel.Text = jerseyNumber.YearRetired.ToString();

           

        }
    }
}
