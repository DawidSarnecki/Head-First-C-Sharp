using System;
using System.Linq;
using System.Text;

namespace Baseball.GameItems
{
    delegate void BatCallBack(BallEventArgs e);
    public class Bat
    {
        // Using private accessor I assure that only one specific ball will be hitte 
        private BatCallBack hitBallCallback;

        internal Bat(BatCallBack callBackDelegate)
        {                          
            // I use operator '=' instaed of '=+' becouse I want to inform only one ball
            this.hitBallCallback  = callBackDelegate;
        }
        public void HitTheBall(BallEventArgs e)
        {
            if (hitBallCallback != null)
            {
                StringBuilder listeners = new StringBuilder();
                listeners.Append($"\n HitTheBallEvent listeners: {hitBallCallback.GetInvocationList().Length}");

                foreach (var element in hitBallCallback.GetInvocationList())
                {
                    listeners.Append($"\n {element.Target.GetType().Name}");
                }
                Console.WriteLine(listeners);
                
                hitBallCallback(e);
            }
            else
            {
                Console.WriteLine("Delegate hitBallCallback have not listeners");
            }
        }
       
    }
}