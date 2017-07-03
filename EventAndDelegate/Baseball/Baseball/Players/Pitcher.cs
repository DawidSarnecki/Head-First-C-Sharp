using System;
using Baseball.GameItems;
using Baseball.Tools;

namespace Baseball.Players
{
    class Pitcher : Player
    {
        public Pitcher(Ball ball) : base(ball)
        {
        }

        // Using private accessor I assure that only one specific ball will be hitte 
        private BatCallBack hitBallCallback;

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