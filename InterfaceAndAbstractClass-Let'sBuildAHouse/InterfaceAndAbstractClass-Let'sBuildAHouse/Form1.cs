using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceAndAbstractClass_Let_sBuildAHouse
{
    public partial class Form1 : Form
    {
        Location curretLocation;

        RoomWithDoor livingRomm;
        Room diningRoom;
        RoomWithDoor kitchen;

        OutsideWithDoor frontYard;
        OutsideWithDoor backYard;
        Outside garden;

        public Form1()
        {
            InitializeComponent();

        }

        private void BuildHause()
        {
            livingRomm = new RoomWithDoor("Living romm", "antique carpet", "drzwi sosnowe");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
