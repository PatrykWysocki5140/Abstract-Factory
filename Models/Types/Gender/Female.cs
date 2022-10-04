using Abstract_Factory.Interfaces.props;


namespace Abstract_Factory.Models.Types.Gender
{
    internal class Female : IType
    {
        public string Type()
        {
            return "Male";
        }
    }
}
