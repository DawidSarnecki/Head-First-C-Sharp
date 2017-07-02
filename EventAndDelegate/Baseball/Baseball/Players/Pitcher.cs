using System;
using Baseball.Tools;

namespace Baseball.Players
{
    class Pitcher : Player
    {
        public Pitcher(Ball ball) : base(ball)
        {
        }

         protected override void BallInPlayEventHandler(object sender, EventArgs e)
        {
            if (e is BallEventArgs)
            {
                BallEventArgs ballEventArgs = e as BallEventArgs;
                if (ballEventArgs.Angle < 45 && ballEventArgs.Distance < 300)
                {
                    this.CatchBall();
                }
                else
                {
                    this.ProtectFirstBase();
                }
                    
            }
        }

    }
}