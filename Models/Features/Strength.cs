using Abstract_Factory.Interfaces.props;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Models.Features
{
    internal class Strength : IFeature
    {
        public string Feature()
        {
            return "Strength";
        }
    }
}
