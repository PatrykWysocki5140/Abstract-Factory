using Abstract_Factory.Interfaces.props;

namespace Abstract_Factory.Models.Items.Armor
{
    internal class Vest : IWeapon
    {
        public string Item()
        {
            return "Bullet vest";
        }
    }
}
