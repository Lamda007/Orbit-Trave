using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orbits
{
    public class clsBLL
    {

        public string Calculate(int Orbit1, int Orbit2, string weather)
        {
            int BikeTopSpeed = 10;
            if (weather.ToLower() == "sunny")
            {
                if (Orbit1 > Orbit2 )
                {
                    return ("Please use Tuk Tuk on Orbit 1");
                }
                else if (Orbit1 == Orbit2)
                {
                    return ("Please use Tuk Tuk on Orbit 1");
                }
                else 
                {
                    return ("Please use Car on Orbit 2");
                }
            }
            else if(weather.ToLower() == "windy")
            {
                if (Orbit1 > Orbit2 )
                {
                    return ("Please use Tuk Tuk on Orbit 1");
                }
                else if (Orbit1 < Orbit2 && Orbit2< BikeTopSpeed)
                {
                    return ("Please use Bike on Orbit 2");
                }
                else if (Orbit1 == Orbit2)
                {
                    return ("Please use Bike on Orbit 1");
                }
                else
                {
                    return ("Please use Car on Orbit 2");
                }
            }
            else if (weather.ToLower() == "rainy")
            {
                if (Orbit1 > Orbit2)
                {
                    return ("Please use Tuk Tuk on Orbit 1");
                }
                else if (Orbit1 == Orbit2)
                {
                    return ("Please use Tuk Tuk on Orbit 1");
                }
                else
                {
                    return ("Please use Car on Orbit 2");
                }
            }
            else
            {
                return ("Something went wrong please recheck input data");
            }
        }
    }
}