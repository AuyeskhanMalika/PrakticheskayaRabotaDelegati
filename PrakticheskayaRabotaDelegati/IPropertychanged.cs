using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrakticheskayaRabotaDelegati
{
    interface IPropertychanged
    {
        event PropertyeventHandler Propertychanged;
    }
}
