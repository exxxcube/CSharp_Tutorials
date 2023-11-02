using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DataStructuresAndAlgorithm
{
    
    public class CountdownTimer
    {
        private TimeSpan targetDuration;
        private DateTime targetTime;
        private Timer timer;

        public event EventHandler<TimeSpan> CountdownTick;
        public event EventHandler CountdownFinished;

        public CountdownTimer()
        {
            targetDuration = TimeSpan.FromMinutes(55); // 24 hours duration
            targetTime = DateTime.Now.Add(targetDuration); // Calculate target time
        }

        public void Start()
        {
            timer = new Timer(TimerCallback, null, TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(1)); // Update every second
        }

        private void TimerCallback(object state)
        {
            TimeSpan remaining = targetTime - DateTime.Now;

            CountdownTick?.Invoke(this, remaining);

            if (remaining <= TimeSpan.Zero)
            {
                timer.Dispose();
                CountdownFinished?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
