using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTime.Foctory
{
    public class NotfyTimerFactory
    {

        public NotfyTimer CreatNotfyTimer(Timer timer)
        {
            return new NotfyTimer(timer);
        }
    }
}
