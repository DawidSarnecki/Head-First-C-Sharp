using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideMethods_JewelerStory
{
    class JewelThief : Locksmith
    {
        private Jewels stolenJewels = null;

        // new keyword overrides patrimonial ReturnContents method
        public override void ReturnContents(Jewels safeContents, Owner owner)
        {
            stolenJewels = safeContents;
            Console.WriteLine("I'm steal the contents of the safe!" + stolenJewels.Sparkle());
        }
    }
}
