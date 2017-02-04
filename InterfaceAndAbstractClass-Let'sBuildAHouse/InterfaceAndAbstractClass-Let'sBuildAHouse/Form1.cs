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
            BuildHause();
            MoveToNewLocation(livingRomm);
        }

        private void BuildHause()
        {
            livingRomm = new RoomWithDoor("Living romm", "antique carpet", "pine doors");
            diningRoom = new Room("Dining room", "crystal chandelier");
            kitchen = new RoomWithDoor("Kitchen", "stainless steel cutlery", "sliding doors");

            frontYard = new OutsideWithDoor("Front yard", true, "white doors");
            backYard = new OutsideWithDoor("Back yard", false, "black and sliding doors");
            garden = new Outside("Garden", false);

            diningRoom.Exits = new Location[] { livingRomm, kitchen };
            livingRomm.Exits = new Location[] { diningRoom };
            kitchen.Exits = new Location[] { diningRoom };

            frontYard.Exits = new Location[] { backYard, garden };
            backYard.Exits = new Location[] { frontYard, garden };
            garden.Exits = new Location[] { backYard, frontYard };

            livingRomm.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRomm;

            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;  

        }

        private void MoveToNewLocation(Location newlocation)
        {
            curretLocation = newlocation;

            // display and change combobox list
            exitsList.Items.Clear();
            for (int i = 0; i < curretLocation.Exits.Length ; i++)
            {
                exitsList.Items.Add(curretLocation.Exits[i].Name);
            }
            exitsList.SelectedIndex = 0;

            // display location's description
            descriptionWindow.Text = curretLocation.Description;

            // change visibility of the "Go Through The Door" button 
            if (curretLocation is IHasExteriorDoor)
                GoThroughTheDoor.Visible = true;
            else
                GoThroughTheDoor.Visible = false;     
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void goHere_Click(object sender, EventArgs e)
        {
            MoveToNewLocation(curretLocation.Exits[exitsList.SelectedIndex]);
        }

        private void GoThroughTheDoor_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor hasDoor = curretLocation as IHasExteriorDoor;
            MoveToNewLocation(hasDoor.DoorLocation);
        }
    }
}
