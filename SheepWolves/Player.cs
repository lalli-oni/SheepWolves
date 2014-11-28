using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

enum State
{
    Alive,
    Dead
}

enum Animal
{
    Sheep,
    Wolf
}

namespace SheepWolves
{
    class Player
    {
        private string _name;
        private State _state;
        private Animal _sheep;


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public State State
        {
            get { return _state; }
            set { _state = value; }
        }

        public Animal Sheep
        {
            get { return _sheep; }
            set { _sheep = value; }
        }
    }
}
