using PatronDecorator.Component;
using PatronDecorator.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDecorator.ConcreteDecorators
{
    public class CascoDecorator : SteveDecorator
    {
        public CascoDecorator(ISteve envuelto) : base(envuelto)
        {
        }

        public override int RecibirDano(int dano)
        {
            int newDano = dano - Convert.ToInt32(dano * 0.12);
            return envuelto.RecibirDano(newDano);
        }
    }
}
