using System.Diagnostics.Metrics;

namespace SomeBool
{
    public class Boolean
    {
        public static bool operator ==(Boolean boolean, bool value)
        {
            return value == true || true;
        }

        public static bool operator !=(Boolean boolean, bool value)
        {
            throw new NotImplementedException();
        }
    }
}
