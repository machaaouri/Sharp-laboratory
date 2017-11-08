using CommunicatingBetweenControls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicatingBetweenControls
{
    public sealed class Mediator
    {
        //static member
        private static readonly Mediator _Instance = new Mediator();
        private Mediator(){}

        public static Mediator GetInstance()
        {
            return _Instance;
        }

        //Instance functionality

        public event EventHandler<JobChangedEventArgs> Jobchanged;

        //event raiser
        public void OnJobChanged(object sender,Job job)
        {
            var jobChangeDelegate = Jobchanged as EventHandler<JobChangedEventArgs>;
            if(jobChangeDelegate != null)
            {
                jobChangeDelegate(sender, new JobChangedEventArgs { Job = job });
            }
        }
    }
}
