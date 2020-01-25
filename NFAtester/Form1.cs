using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NFAtester
{
    public partial class NFAtesterForm : Form
    {
        public NFAtesterForm()
        {
            InitializeComponent();
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            #region Gather form input

            int numberOfStates = 0;
            if (!String.IsNullOrEmpty(numberOfStatesTextBox.Text))
            {
                numberOfStates = int.Parse(numberOfStatesTextBox.Text);
            }

            List<string> alphabet = new List<string>();
            if (!String.IsNullOrEmpty(alphabetTextBox.Text))
            {
                foreach(string letter in alphabetTextBox.Text.Split(' '))
                {
                    alphabet.Add(letter);
                }
            }

            string initialState = "";
            if (!String.IsNullOrEmpty(initialStateTextBox.Text))
            {
                initialState = initialStateTextBox.Text;
            }

            List<string> finalState = new List<string>();
            if (!String.IsNullOrEmpty(finalStateTextBox.Text))
            {
                foreach (string state in finalStateTextBox.Text.Split(' '))
                {
                    finalState.Add(state);
                }
            }

            List<Transition> transitions = new List<Transition>();
            if (!String.IsNullOrEmpty(transitionTextBox.Text))
            {
                string[] transitionLines = transitionTextBox.Text.Split(
                    new[] { Environment.NewLine },
                    StringSplitOptions.None
                );
                foreach (string transitionLine in transitionLines)
                {
                    string[] transitionParams = transitionLine.Split(' ');
                    if (transitionParams.Length == 3)
                    {
                        transitions.Add(new Transition(
                            transitionParams[0],
                            transitionParams[1],
                            transitionParams[2])
                        );
                    }
                }
            }

            string testInput = "";
            if (!String.IsNullOrEmpty(testInputTextBox.Text))
            {
                testInput = testInputTextBox.Text;
            }

            #endregion

            #region Initialize and run NFA Builder

            NFABuilder nfa = new NFABuilder(
                numberOfStates,
                alphabet,
                initialState,
                finalState,
                transitions);

            bool flag = nfa.Test(testInput);

            // Display result
            if(flag)
            {
                resultLabel.Text = "Accepted input";
                resultLabel.ForeColor = System.Drawing.Color.Green;
            } else
            {
                resultLabel.Text = "Not accepted input";
                resultLabel.ForeColor = System.Drawing.Color.Red;
            }

            #endregion
        }
    }
}
