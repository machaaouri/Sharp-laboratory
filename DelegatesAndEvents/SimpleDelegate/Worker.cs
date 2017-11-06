using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDelegate
{
    public class Worker
    {
        //OneWay delegate
        public delegate void MyDelegate(int hours, WorkType workType);

        //Define an event
        public event MyDelegate WorkPerformed;

        //Define an event using the built-in .net delegate
        public event EventHandler WorkCompleted;

        public void Dowork(int hours,WorkType workType)
        {
            for (int i = 0; i < hours;i++ )
            {
                OnWorkPerformed(i+1, workType);
            }

            OnWorkCompleted();
        }

        protected virtual void OnWorkPerformed(int hours, WorkType workType)
        {

            //if(WorkPerformed != null)
            //{
            //    WorkPerformed(hours, workType);
            //}

            var  del = WorkPerformed as MyDelegate; // cast the event as the delegate
            if(del != null) // check if there are any listeners attached
            {
                del(hours, workType);
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
