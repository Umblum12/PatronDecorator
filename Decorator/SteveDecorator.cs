using PatronDecorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDecorator.Decorator
{
    public abstract class SteveDecorator : ISteve
    {
        protected ISteve envuelto;

        public SteveDecorator(ISteve envuelto)
        {
            this.envuelto = envuelto;
        }
        public abstract int RecibirDano(int dano);
    }
}
