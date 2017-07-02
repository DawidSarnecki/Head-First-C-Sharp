using System;

namespace Baseball
{
    public class BallEventArgs : EventArgs
    {
        public int Angle { get; private set; }
        public int Distance { get; private set;}

        public BallEventArgs(int angle, int distanace)
        {
            this.Angle = angle;
            this.Distance = distanace;
        }
    }
}
