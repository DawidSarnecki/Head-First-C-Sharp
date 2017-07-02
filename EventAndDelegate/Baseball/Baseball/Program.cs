using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Baseball.Players;
using Baseball.Fans;
using Baseball.GameItems;
using Baseball.Templates;

namespace Baseball
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Start");
            Ball ball = new Ball();
            Bat bat = new Bat();

            Pitcher pitcher = new Pitcher(ball);
            Catcher cathcer = new Catcher(ball);
            Batter batter = new Batter(ball); 
            FirstBaseman firstBaseman = new FirstBaseman(ball);
            SecondBaseman secondBaseman = new SecondBaseman(ball);
            ThirdBaseman thirdBaseman = new ThirdBaseman(ball);
            Fan energeticFan = new Fan(ball);
            Umpire goodUmpire = new Umpire(ball);

           
            //int[][] parmas = new int[][];
            ball.OnBallInPlayTest(new BallEventArgs(50, 80));
            ball.OnBallInPlay(new BallEventArgs(40, 200));
            Console.WriteLine();

            //Add listener many times:
            goodUmpire.StartLookingAtBall(ball);
            goodUmpire.StartLookingAtBall(ball);
            ball.OnBallInPlay(new BallEventArgs(30, 910));

            Console.WriteLine();
            goodUmpire.StopLookingAtBall();
            ball.OnBallInPlay(new BallEventArgs(30, 910));
            goodUmpire.StopLookingAtBall();
            goodUmpire.StopLookingAtBall();
            goodUmpire.StopLookingAtBall();
            goodUmpire.StopLookingAtBall();
            goodUmpire.StopLookingAtBall();
            goodUmpire.StopLookingAtBall();

            Console.WriteLine();
           
            ball.OnBallInPlay(new BallEventArgs(50, 80));
            Console.WriteLine();

            goodUmpire.StartWaitgingForHit(bat);
            goodUmpire.StartWaitgingForHit(bat);
            ball.OnBallInPlay(new BallEventArgs(50, 80));
             ball.StartWaitgingForHit(bat);
            bat.OnHitTheBall(new EventArgs());
            

            Console.ReadKey();
        }

    }
}