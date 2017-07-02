using System;

namespace Baseball.GameItems
{
    delegate void BatCallBack(BallEventArgs e);
    class Bat
    {
        public Bat(BatCallBack callBackDelegate)
        {
            this.hitBallCallback  = new BatCallBack(callBackDelegate);
        }

        private BatCallBack hitBallCallback;

        private EventHandler HitEventHandler;

        public void OnHitTheBall(EventArgs e)
        {
            var hitTheBall = HitEventHandler;

            if (hitTheBall != null)
            {
                Console.WriteLine("\n HitTheBallEvent listeners: {0}", hitTheBall.GetInvocationList().Length);
                hitTheBall(this, e);
            }
            else
            {
                Console.WriteLine("Event hitTheBall have not listeners");
            }
        }
    }
}