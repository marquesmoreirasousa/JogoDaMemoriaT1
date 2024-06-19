using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaMemoriaT1
{
    internal class Player
    {
        //Atributos
        private string _name;
        private int _score;

        //Métodos
        public Player(string name)
        {
            _name = name;
        }

        public string Name
        {
            get { return _name; }
        }

    }
}
