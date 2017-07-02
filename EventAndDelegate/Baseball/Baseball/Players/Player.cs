using System;
using Baseball.Templates;

namespace Baseball.Players
{
     class Player : Person
    {
        public Player(Ball ball)
        {
            this.ball = ball;
            this.StartLookingAtBall();
        }

        /// <summary>
        /// </summary>
        protected void CatchBall()
        {
            Said("I Catched the Ball");
        }

        protected void ProtectFirstBase()
        {
            Said("I Protect First Base");
        }

        

       
    }
}