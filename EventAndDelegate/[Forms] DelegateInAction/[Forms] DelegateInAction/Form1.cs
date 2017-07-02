using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Forms__DelegateInAction
{
    public partial class Form1 : Form
    {
        GetSecretInfo secretMethod = null;
        private Alice alice = new Alice();
        private Jane jane = new Jane();

        public Form1()
        {
            InitializeComponent();
          
        }

        private void GetComponent_Click(object sender, EventArgs e)
        {
            if (secretMethod != null)
            {
                MessageBox.Show($"I will added {secretMethod((int)numericUpDown1.Value)}");
            }
            else
            {
                MessageBox.Show("Component does not exist.");
            }


        }

        private void UseJaneDelegate_Click(object sender, EventArgs e)
        {
            secretMethod = new GetSecretInfo(jane.MySecret);

        }

        private void UseAliceDelegate_Click(object sender, EventArgs e)
        {
            secretMethod = new GetSecretInfo(alice.MySecret);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
