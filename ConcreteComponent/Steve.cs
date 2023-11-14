using PatronDecorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PatronDecorator.ConcreteComponent
{
    public class Steve : ISteve
    {
        public int _vida = 20;
        public int RecibirDano(int dano)
        {
            return _vida - dano < 0 ? 0 : _vida - dano;
        }
    }
}
