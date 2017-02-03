using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceAndAbstractClass_Let_sBuildAHouse
{
    abstract class Location
    {
        // constructor
        public Location(string name)
        {
            Name = name;
        }

        public Location[] Exits; //array of references Lecation
        public string Name { get; private set; }
        
        public virtual string Description
        {
            get
            {
                string description = "You are in the "
                    + Name
                    + ". You can see exits to following locations: ";
                for (int i = 0; i < Exits.Length; i++)
                {
                    description += " " + Exits[i].Name;
                    if (i != Exits.Length - 1)
                    {
                        description += ",";
                    }
                    description += ".";
                }
                return description; 
            }
        }
    }

    class Room : Location
    {
        private string decoration;
        
        public Room (string name, string decoration) : base(name)
        {
            this.decoration = decoration;
        }

        public override string Description
        {
            get
            {
                return base.Description + "You can see there " + decoration + ".";
            }
        }
    }

    class Outside : Location
    {
        private bool hot { get; set; }

        public Outside (string name, bool hot) : base(name)
        {
            this.hot = hot;
        }
    }

    interface IHasExteriorDoor
    {
        string DoorDescription { get; }
        Location DoorLocation { get; set; }
    }

    class OutsideWithDoor : Outside, IHasExteriorDoor
    {
        public string DoorDescription { get; private set; }
        public Location DoorLocation { get; set; }

        public OutsideWithDoor
            (string name, 
            bool hot, 
            string doorDescription, 
            string doorLocation) : base (name, hot)
        {
            this.DoorDescription = doorDescription;
        }
    }


    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
