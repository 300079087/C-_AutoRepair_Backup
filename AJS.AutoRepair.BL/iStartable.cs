using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AJS.AutoRepair.BL
{
    public interface iStartable
    {
        bool IsRunning { get; }

        void Start();
    }
}
