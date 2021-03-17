using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferma
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck duck = new Duck() { Height = 189};
            duck.Fly();
            duck.Move();

            IFly fly = duck;
            fly.Move();

            (duck as ISwim).Move(); // ISwim.Move

            Duck mDuck = new MandarinDuck();
            mDuck.Fly(); // Duck.Fly()
            (mDuck as MandarinDuck).Fly();

        }
    }
}
