using System;
using Baseball.Templates;

namespace Baseball
{
    /// <summary />
    /// 
    internal class Umpire : Person
    {
        public Umpire(Ball ball)
        {
            this.ball = ball;
            this.ball.BallInPlayTest += Ball_BallInPlayTest;
        }

        private void Ball_BallInPlayTest(object sender, BallEventArgs e)
        {
            this.Said("[BallInPlayTest]");
        }
    }
}