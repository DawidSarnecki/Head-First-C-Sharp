using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Baseball.GameItems;
using Baseball.Players;

namespace Baseball
{
    /// <summary />
    public class Ball
    {
        //Using method GetNewBat() and delegate I give the reference to the method OnBallInPlay
        public Bat GetNewBat()
        {
            return new Bat(this.OnBallInPlay);
        }


        /// <summary>
        /// </summary>
        protected void OnBallInPlay(BallEventArgs e)
        {
            EventHandler ballInPlay = BallInPlay;
           
            if (ballInPlay != null)
            {
                StringBuilder info = new StringBuilder(
                    $"BallInPlay event params:[ angle: { e.Angle}; distance: {e.Distance} cm] \nEvent listeners: {ballInPlay.GetInvocationList().Length}");
                foreach (var element in ballInPlay.GetInvocationList())
                {
                    info.Append($"\n\t {element.Target.GetType().Name}");
                }
                Console.WriteLine(info);
            
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