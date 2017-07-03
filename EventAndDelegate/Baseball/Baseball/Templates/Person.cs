using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Baseball.GameItems;

namespace Baseball.Templates
{
    public abstract class Person
    {
        public ObservableCollection<string> PersonSaid;
        protected Person()
        {
            this.PersonSaid = new ObservableCollection<string>();
            this.PersonSaid.CollectionChanged += PersonSaid_CollectionChanged;
        }

        private void PersonSaid_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            Console.WriteLine(this.PersonSaid.Last());
        }

        protected Ball ball { get; set;}
        protected Bat bat { get; set; }

        public void  StartLookingAtBall()
        {
            if (ball != null)
            {
                this.ball.BallInPlay += this.BallInPlayEventHandler;
            }
            else
            {
                this.Said("I don't know about the ball");
            }
        }

        public void StartLookingAtBall(Ball ball)
        {
            this.ball = ball;
            this.ball.BallInPlay += this.BallInPlayEventHandler;
        }

        public void StopLookingAtBall()
        {
            if (ball != null)
            {
                this.ball.BallInPlay -= this.BallInPlayEventHandler;
            }
            else
            {
                this.Said("I don't know about the ball");
            }

        }

        public void StartWaitgingForHit(Bat bat)
        {
            this.bat = bat;
        }

        protected virtual void HitEventHandler(object sender, EventArgs eventArgs)
        {
            this.Said("Ball was hit!");
        }


        protected void Said(string said)
        {
            this.PersonSaid.Add($"{GetType().Name} said: {said}");
        }

        /// <summary>
        ///     This will be called whenever the ball status changes.
        /// </summary>
        protected virtual void BallInPlayEventHandler(object sender, EventArgs e)
        {
            Said("I see BallInPlay");
        }
    }
}