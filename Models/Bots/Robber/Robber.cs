using Abstract_Factory.Interfaces;
using Abstract_Factory.Interfaces.props;
using Abstract_Factory.Models.Features;
using Abstract_Factory.Models.Items.Arms;
using Abstract_Factory.Models.Types.Gender;

namespace Abstract_Factory.Models.Bots.robber
{
    internal class Robber : IBotFactory
    {
        public IWeapon GetWeapon()
        {
            return new Knife();
        }

        public IFeature GetFeature()
        {
            return new Strength();
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
