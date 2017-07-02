using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplacingTheRightMethodByDelegate
{

    delegate string ConvertToString(int numberToConvert);

    delegate string ConvertToInt(string numberToConvert);
}
