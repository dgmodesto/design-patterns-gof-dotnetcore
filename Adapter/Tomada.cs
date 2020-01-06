

namespace Adapter
{
    public abstract class Tomada<T>
    {
        public abstract string conecta(T plug);
        public abstract string getNomeRede();
    }
}
