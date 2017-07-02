using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Baseball.GameItems;

namespace Baseball
{
    /// <summary />
    public class Ball
    {
        private Bat bat;
        public void StartWaitgingForHit(Bat bat)
        {
            this.bat = bat;
            this.bat.HitEventHandler += HitEventHandler;
        }

        private void HitEventHandler(object sender, EventArgs eventArgs)
        {
            Console.WriteLine("Ball was hit");
        }

        /// <summary>
        /// </summary>
        public void OnBallInPlay(BallEventArgs e)
        {
            EventHandler ballInPlay = BallInPlay;
           
            if (ballInPlay != null)
            {
                
                Console.WriteLine("BallInPlay event params:[ angle: {0}; distance: {1} cm] \nEvent listeners: {2}", e.Angle, e.Distance,
                                  ballInPlay.GetInvocationList().Length);
                ballInPlay(this, e);
            }
            else
            {
                Console.WriteLine("Event BallInPlay have not listeners");
            }

        }

        /// <summary>
        /// </summary>
        public void OnBallInPlayTest(BallEventArgs e)
        {
            EventHandler<BallEventArgs> ballInPlay = BallInPlayTest;

            if (ballInPlay != null)
            {

                Console.WriteLine("BallInPlayTest event params:[ angle: {0}; distance: {1} cm] \nEvent listeners: {2}", e.Angle, e.Distance,
                                  ballInPlay.GetInvocationList().Length);
                ballInPlay(this, e);
            }
            else
            {
                Console.WriteLine("Event BallInPlay have not listeners");
            }

        }
        /// <summary>
        ///  An event that clients can use to be notified whenever the
        ///  ball will be in play.
        /// </summary>
        public event EventHandler BallInPlay;

        /// <summary>
        ///  An event that clients can use to be notified whenever the
        ///  ball will be in play.
        /// </summary>
        public event EventHandler<BallEventArgs> BallInPlayTest;

    }
}