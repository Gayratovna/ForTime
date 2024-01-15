
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTime
{
    public class NotfyTimer
    {
        private Timer _timer;

        public NotfyTimer(Timer timer)
        {
            this._timer = timer;
        }

        public void Initialize(Action<string, int> start, Action<string, int> second, Action<string> stop)
        {
            this._timer.Start += start;
            this._timer.Second += second;
            this._timer.Stop += stop;

        }
        public void NotfyRun()
        {
            this._timer.Run();
        }
    }
}
