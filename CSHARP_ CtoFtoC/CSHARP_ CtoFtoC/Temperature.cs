using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Temperature
{
    public static float CtoF(float temp)
    {
        return (temp * 9 / 5) + 32;
    }
    public static float FtoC(float temp)
    {
        return (temp - 32) * 5 / 9;
    }
}
