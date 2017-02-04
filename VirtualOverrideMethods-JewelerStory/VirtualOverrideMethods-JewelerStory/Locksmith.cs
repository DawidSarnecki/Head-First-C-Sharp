using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideMethods_JewelerStory
{
    class Locksmith
    {  
        public void OpenSafe(Safe safe, Owner owner)
        {
            safe.PickLock(this);
            Jewels safeContents = safe.Open(givenCode);
            ReturnContents(safeContents, owner);           
        }

        private string givenCode = null;
        public void WriteDownCode(string code)
        {
            givenCode = code;
        }

        public virtual void ReturnContents(Jewels safeContents, Owner owner)
        {
            owner.ReceiveContents(safeContents);
        }

    }
}
