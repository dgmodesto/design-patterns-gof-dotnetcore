using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public abstract class NotaMusical : ICloneable
    {
        public NotaMusical Clone()
        {
            Object clone = null;
            try
            {
                clone = base.MemberwiseClone();
            }
            catch (Exception ex)
            {
                ex.InnerException.StackTrace.ToString();
            }
            return (NotaMusical)clone;
        }

        public abstract void desenha();

        object ICloneable.Clone()
        {
            throw new NotImplementedException();
        }
    }
}
