using Abstract_Factory.Interfaces;
using Abstract_Factory.Interfaces.props;
using Abstract_Factory.Models.Features;
using Abstract_Factory.Models.Items.Armor;
using Abstract_Factory.Models.Types.Gender;


namespace Abstract_Factory.Models.Bots.villager
{
    internal class Villager : IBotFactory
    {
        public IWeapon GetWeapon()
        {
            return new Shirt();
        }

        public IFeature GetFeature()
        {
            return new Speed();
        }

        IType IBotFactory.GetTyp()
        {
            return new Female();
        }
        public IBotName GetName()
        {
            return new BotNamesGenerator();
        }
    }
}
