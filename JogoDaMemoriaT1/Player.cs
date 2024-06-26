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
            Name = name;
            _score = 0;
        }

        //Propriedade
        public string Name
        {
            set {
                if(!String.IsNullOrEmpty(value))
                    _name = value;
            }
            get { return _name; }
        }
        public int Score
        {
            set
            {
                if (value > 0)
                    _score = value;
            }
            get
            {
                return _score;
            }
        }
        public override string ToString()
        {
            return "Nome: " + Name +
                   "\nPontuação: " + Score;
        }
    }
}
