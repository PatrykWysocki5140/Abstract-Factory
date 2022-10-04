using Abstract_Factory.Interfaces.props;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Interfaces
{
    interface IBotFactory
    {
        IWeapon GetWeapon();
        IFeature GetFeature();
        IType GetTyp();
        IBotName GetName();
    }
}
