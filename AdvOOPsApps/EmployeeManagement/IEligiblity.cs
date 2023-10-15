using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public interface IEligiblity
    {
        public bool Eligiblity(int hscCutOff, int ugCutOff);
    }
}