using Abstract_Factory.Interfaces.props;

namespace Abstract_Factory.Models.Items.Additional
{
    internal class Lighter : IWeapon
    {
        public string Item()
        {
            return "Cigarette lighter";
        }
    }
}
