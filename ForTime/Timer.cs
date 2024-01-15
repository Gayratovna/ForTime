using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTime
{
    public class Timer
    {
        public event Action<string, int> Start;
        public event Action<string> Stop;
        public event Action<string, int> Second;

        private string name;
        private int second;
        public Timer(string name, int? second)
        {

            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.second = second ?? throw new ArgumentNullException(nameof(second));
        }

        public void Run()
        {
            this.Start(name, second);

            for (int i = 0; i < this.second; i++)
            {
                this.Second(name, i);
            }
            this.Stop(name);

        }

    }
}