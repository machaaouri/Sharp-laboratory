using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDelegate
{
    public class Worker
    {

        public event EventHandler<WorkPerformedEventArgs> WorkPerformed;

        public event EventHandler<WorkPerformedEventArgs> WorkStarted;

        public event EventHandler WorkCompleted;

        public void Dowork(int hours,WorkType workType)
        {
            OnWorkStarted(hours,workType);

            for (int i = 0; i < hours;i++ )
            {
                OnWorkPerformed(i+1, workType);
            }

            OnWorkCompleted();
        }


        protected virtual void OnWorkStarted(int hours, WorkType workType)
        {
            var del = WorkStarted as EventHandler<WorkPerformedEventArgs>;

            if(del != null)
            {
                del(this, new WorkPerformedEventArgs(hours, workType));
            }
        }

        protected virtual void OnWorkPerformed(int hours, WorkType workType)
        {

            //if(WorkPerformed != null)
            //{
            //    WorkPerformed(hours, workType);
            //}

            var del = WorkPerformed as EventHandler<WorkPerformedEventArgs>; // cast the event as the delegate
            if(del != null) // check if there are any listeners attached
            {
                del(this,new WorkPerformedEventArgs(hours,workType));
            }
        }

        protected virtual void OnWorkCompleted()
        {
            var del = WorkCompleted as EventHandler; // cast the event as the delegate
            if (del != null) // check if there are any listeners attached
            {
                del(this, EventArgs.Empty);
            }
        }
    }
}
