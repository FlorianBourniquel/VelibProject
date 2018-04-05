using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibraryVelib
{
    class Timer : ITimer
    {
        public void TriggerUpdate()
        {
            new Event().TriggerUpdate();
        }
    }
}
