using System;
using Baseball.Templates;

namespace Baseball.Fans
{
    class Fan : Person
    {
        public Fan(Ball ball)
        {
            this.ball = ball;
            this.StartLookingAtBall();
        }

        protected override void BallInPlayEventHandler(object sender, EventArgs e)
        {
            Said("I see BallInPlay");
            if (e is BallEventArgs)
            {
                var flightParams = e as BallEventArgs;
                if (flightParams.Angle > 40 && flightParams.Distance < 100)
                {
                    this.CatchBall();
                }
                else
                {
                    this.Said("Ole... Ole... OleOleOle");
                }

            }

        }

        /// <summary>
        /// </summary>
        protected void CatchBall()
        {
            Said("I Catched the Ball");
        }

    }
}