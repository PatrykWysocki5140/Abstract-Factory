using Abstract_Factory.Interfaces.props;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Models.Features
{
    internal class Speed : IFeature
    {
        public string Feature()
        {
            return "Speed";
        }
    }
}
