using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideMethods_JewelerStory
{
    class Owner
    {
        private Jewels returnedContents;
        public void ReceiveContents(Jewels safeContents)
        {
            returnedContents = safeContents;
            Console.WriteLine("Thanks for bringing jewels " + safeContents.Sparkle() );
        }
    }
}
