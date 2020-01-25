using System;

namespace NFAtester
{
    class Transition
    {
        public string currentState;
        public string letter;
        public string nextState;

        public Transition(string currentState, string letter, string nextState)
        {
            this.currentState = currentState;
            this.letter = letter;
            this.nextState = nextState;
        }
    }
}
