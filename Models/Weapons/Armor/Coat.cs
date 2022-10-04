using Abstract_Factory.Interfaces.props;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Models.Items.Armor
{
    internal class Coat : IWeapon
    {
        public string Item()
        {
            return "White coat";
        }
    }
}
