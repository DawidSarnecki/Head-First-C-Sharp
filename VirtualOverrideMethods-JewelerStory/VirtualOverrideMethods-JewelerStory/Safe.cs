using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideMethods_JewelerStory
{
    
    class Safe
    {
        private Jewels contents = new Jewels();
        private string safeSecretCode = "12345";

        // this method returns Jewel if given code is correct.
        public Jewels Open (string code)
        {
            string x;
            x= code;
            if (code == safeSecretCode)
                return contents;
            else
                //return null;
                return contents;
        }

        public void PickLock(Locksmith lockpicker)
        {
            lockpicker.WriteDownCode(safeSecretCode);
        }
    }
}
