using Abstract_Factory.Interfaces;
using Abstract_Factory.Interfaces.props;
using Abstract_Factory.Models.Bots;
using Abstract_Factory.Models.Features;
using Abstract_Factory.Models.Items.Additional;
using Abstract_Factory.Models.Types.Gender;

namespace Abstract_Factory.Models.bots.citizen
{
    internal class Citizen : IBotFactory
    {
        public IWeapon GetWeapon()
        {
            return new Lighter();
        }

        public IFeature GetFeature()
        {
            return new Speed();
        }

        IType IBotFactory.GetTyp()
        {
            return new Male();
        }
        public IBotName GetName()
        {
            return new BotNamesGenerator();
        }
    }
}
