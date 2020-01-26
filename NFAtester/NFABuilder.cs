using System;
using System.Collections.Generic;

namespace NFAtester
{
    class NFABuilder
    {
        // Given by user - NFA parameters
        private int numberOfStates;
        private List<string> alphabet;
        private string initialState;
        private List<string> finalState;
        private List<Transition> transitions;

        // Keep current state of NFA
        private string currentState;

        public NFABuilder(int numberOfStates, List<string> alphabet, String initialState, List<string> finalState, List<Transition> transitions)
        {
            this.numberOfStates = numberOfStates;
            this.alphabet = alphabet;
            this.initialState = initialState;
            this.finalState = finalState;
            this.transitions = transitions;
        }

        private bool SearchInAlphabet(string letter)
        {
            bool exist = false;

            foreach(string alphabetLetter in alphabet)
            {
                if(alphabetLetter == letter)
                {
                    exist = true;
                    break;
                }
            }

            return exist;
        }

        private string SearchInTransitions(string currentState, string letter)
        {
            string nextState = "";

            foreach (Transition transition in transitions)
            {

                if (transition.currentState == currentState && transition.letter == letter)
                {
                    nextState = transition.nextState;
                    break;
                }
            }

            return nextState;
        }

        public bool Test(string input)
        {
            bool accepted = false;
            bool allLettersPassed = true;
            currentState = initialState;

            // For every letter of input, check if exists in alphabet and there is a transition and make it.
            // Also, keep updated the current state.
            foreach (char letter in input.ToCharArray())
            {
                bool letterExists = SearchInAlphabet(letter.ToString());
                string nextState = SearchInTransitions(currentState, letter.ToString());

                if (letterExists && nextState != "")
                {
                    currentState = nextState;
                } else
                {
                    allLettersPassed = false;
                }
            }
            if (string.IsNullOrEmpty(input)) allLettersPassed = false;

            // Check if the last state is a final state and for all letters there was a transition
            foreach(string state in finalState)
            {
                if(currentState == state && allLettersPassed)
                {
                    accepted = true;
                }
            }

            return accepted;
        }
    }
}
