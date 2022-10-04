using Abstract_Factory.Interfaces.props;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Models.Types.Gender
{
    internal class Male : IType
    {
        public string Type()
        {
            return "Male";
        }

    }
}
