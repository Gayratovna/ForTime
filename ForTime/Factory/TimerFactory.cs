using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTime.Foctory
{
    public class TimerFactory
    {
        public Timer CreateTimer(string name, int second)
        {
            return new Timer(name, second);
        }

    }
}
