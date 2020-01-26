namespace NFAtester
{
    partial class NFAtesterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NFAParametersGroupBox = new System.Windows.Forms.GroupBox();
            this.transitionTextBox = new System.Windows.Forms.TextBox();
            this.transitionLabel = new System.Windows.Forms.Label();
            this.finalStateTextBox = new System.Windows.Forms.TextBox();
            this.finalStateLabel = new System.Windows.Forms.Label();
            this.initialStateTextBox = new System.Windows.Forms.TextBox();
            this.initialStateLabel = new System.Windows.Forms.Label();
            this.alphabetTextBox = new System.Windows.Forms.TextBox();
            this.alphabetLabel = new System.Windows.Forms.Label();
            this.numberOfStatesTextBox = new System.Windows.Forms.TextBox();
            this.numberOfStatesLabel = new System.Windows.Forms.Label();
            this.TestInputGroupBox = new System.Windows.Forms.GroupBox();
            this.testButton = new System.Windows.Forms.Button();
            this.testInputTextBox = new System.Windows.Forms.TextBox();
            this.testInputLabel = new System.Windows.Forms.Label();
            this.ResultGroupBox = new System.Windows.Forms.GroupBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.NFAParametersGroupBox.SuspendLayout();
            this.TestInputGroupBox.SuspendLayout();
            this.ResultGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NFAParametersGroupBox
            // 
            this.NFAParametersGroupBox.Controls.Add(this.transitionTextBox);
            this.NFAParametersGroupBox.Controls.Add(this.transitionLabel);
            this.NFAParametersGroupBox.Controls.Add(this.finalStateTextBox);
            this.NFAParametersGroupBox.Controls.Add(this.finalStateLabel);
            this.NFAParametersGroupBox.Controls.Add(this.initialStateTextBox);
            this.NFAParametersGroupBox.Controls.Add(this.initialStateLabel);
            this.NFAParametersGroupBox.Controls.Add(this.alphabetTextBox);
            this.NFAParametersGroupBox.Controls.Add(this.alphabetLabel);
            this.NFAParametersGroupBox.Controls.Add(this.numberOfStatesTextBox);
            this.NFAParametersGroupBox.Controls.Add(this.numberOfStatesLabel);
            this.NFAParametersGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.NFAParametersGroupBox.Location = new System.Drawing.Point(12, 12);
            this.NFAParametersGroupBox.Name = "NFAParametersGroupBox";
            this.NFAParametersGroupBox.Size = new System.Drawing.Size(243, 477);
            this.NFAParametersGroupBox.TabIndex = 0;
            this.NFAParametersGroupBox.TabStop = false;
            this.NFAParametersGroupBox.Text = "NFA Parameters";
            // 
            // transitionTextBox
            // 
            this.transitionTextBox.Location = new System.Drawing.Point(9, 273);
            this.transitionTextBox.Multiline = true;
            this.transitionTextBox.Name = "transitionTextBox";
            this.transitionTextBox.Size = new System.Drawing.Size(88, 198);
            this.transitionTextBox.TabIndex = 9;
            // 
            // transitionLabel
            // 
            this.transitionLabel.AutoSize = true;
            this.transitionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.transitionLabel.Location = new System.Drawing.Point(6, 246);
            this.transitionLabel.Name = "transitionLabel";
            this.transitionLabel.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.transitionLabel.Size = new System.Drawing.Size(91, 24);
            this.transitionLabel.TabIndex = 8;
            this.transitionLabel.Text = "Transition(s)";
            // 
            // finalStateTextBox
            // 
            this.finalStateTextBox.Location = new System.Drawing.Point(9, 217);
            this.finalStateTextBox.MaxLength = 19;
            this.finalStateTextBox.Name = "finalStateTextBox";
            this.finalStateTextBox.Size = new System.Drawing.Size(226, 26);
            this.finalStateTextBox.TabIndex = 7;
            // 
            // finalStateLabel
            // 
            this.finalStateLabel.AutoSize = true;
            this.finalStateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.finalStateLabel.Location = new System.Drawing.Point(6, 190);
            this.finalStateLabel.Name = "finalStateLabel";
            this.finalStateLabel.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.finalStateLabel.Size = new System.Drawing.Size(93, 24);
            this.finalStateLabel.TabIndex = 6;
            this.finalStateLabel.Text = "Final state(s)";
            // 
            // initialStateTextBox
            // 
            this.initialStateTextBox.Location = new System.Drawing.Point(9, 161);
            this.initialStateTextBox.MaxLength = 1;
            this.initialStateTextBox.Name = "initialStateTextBox";
            this.initialStateTextBox.Size = new System.Drawing.Size(226, 26);
            this.initialStateTextBox.TabIndex = 5;
            // 
            // initialStateLabel
            // 
            this.initialStateLabel.AutoSize = true;
            this.initialStateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.initialStateLabel.Location = new System.Drawing.Point(6, 134);
            this.initialStateLabel.Name = "initialStateLabel";
            this.initialStateLabel.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.initialStateLabel.Size = new System.Drawing.Size(76, 24);
            this.initialStateLabel.TabIndex = 4;
            this.initialStateLabel.Text = "Initial state";
            // 
            // alphabetTextBox
            // 
            this.alphabetTextBox.Location = new System.Drawing.Point(9, 105);
            this.alphabetTextBox.MaxLength = 19;
            this.alphabetTextBox.Name = "alphabetTextBox";
            this.alphabetTextBox.Size = new System.Drawing.Size(226, 26);
            this.alphabetTextBox.TabIndex = 3;
            // 
            // alphabetLabel
            // 
            this.alphabetLabel.AutoSize = true;
            this.alphabetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.alphabetLabel.Location = new System.Drawing.Point(6, 78);
            this.alphabetLabel.Name = "alphabetLabel";
            this.alphabetLabel.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.alphabetLabel.Size = new System.Drawing.Size(64, 24);
            this.alphabetLabel.TabIndex = 2;
            this.alphabetLabel.Text = "Alphabet";
            // 
            // numberOfStatesTextBox
            // 
            this.numberOfStatesTextBox.Location = new System.Drawing.Point(9, 49);
            this.numberOfStatesTextBox.MaxLength = 2;
            this.numberOfStatesTextBox.Name = "numberOfStatesTextBox";
            this.numberOfStatesTextBox.Size = new System.Drawing.Size(226, 26);
            this.numberOfStatesTextBox.TabIndex = 1;
            // 
            // numberOfStatesLabel
            // 
            this.numberOfStatesLabel.AutoSize = true;
            this.numberOfStatesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.numberOfStatesLabel.Location = new System.Drawing.Point(6, 22);
            this.numberOfStatesLabel.Name = "numberOfStatesLabel";
            this.numberOfStatesLabel.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.numberOfStatesLabel.Size = new System.Drawing.Size(122, 24);
            this.numberOfStatesLabel.TabIndex = 0;
            this.numberOfStatesLabel.Text = "Number of states";
            // 
            // TestInputGroupBox
            // 
            this.TestInputGroupBox.Controls.Add(this.testButton);
            this.TestInputGroupBox.Controls.Add(this.testInputTextBox);
            this.TestInputGroupBox.Controls.Add(this.testInputLabel);
            this.TestInputGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.TestInputGroupBox.Location = new System.Drawing.Point(263, 12);
            this.TestInputGroupBox.Name = "TestInputGroupBox";
            this.TestInputGroupBox.Size = new System.Drawing.Size(243, 138);
            this.TestInputGroupBox.TabIndex = 1;
            this.TestInputGroupBox.TabStop = false;
            this.TestInputGroupBox.Text = "Test Input";
            // 
            // testButton
            // 
            this.testButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.testButton.Location = new System.Drawing.Point(9, 105);
            this.testButton.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(227, 26);
            this.testButton.TabIndex = 2;
            this.testButton.Text = "Test";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // testInputTextBox
            // 
            this.testInputTextBox.Location = new System.Drawing.Point(9, 49);
            this.testInputTextBox.Name = "testInputTextBox";
            this.testInputTextBox.Size = new System.Drawing.Size(227, 26);
            this.testInputTextBox.TabIndex = 1;
            // 
            // testInputLabel
            // 
            this.testInputLabel.AutoSize = true;
            this.testInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.testInputLabel.Location = new System.Drawing.Point(6, 22);
            this.testInputLabel.Name = "testInputLabel";
            this.testInputLabel.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.testInputLabel.Size = new System.Drawing.Size(39, 24);
            this.testInputLabel.TabIndex = 0;
            this.testInputLabel.Text = "Input";
            // 
            // ResultGroupBox
            // 
            this.ResultGroupBox.Controls.Add(this.resultLabel);
            this.ResultGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ResultGroupBox.Location = new System.Drawing.Point(263, 157);
            this.ResultGroupBox.Name = "ResultGroupBox";
            this.ResultGroupBox.Size = new System.Drawing.Size(243, 51);
            this.ResultGroupBox.TabIndex = 2;
            this.ResultGroupBox.TabStop = false;
            this.ResultGroupBox.Text = "Result";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.ForeColor = System.Drawing.Color.Black;
            this.resultLabel.Location = new System.Drawing.Point(6, 28);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 20);
            this.resultLabel.TabIndex = 0;
            // 
            // NFAtesterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 501);
            this.Controls.Add(this.ResultGroupBox);
            this.Controls.Add(this.TestInputGroupBox);
            this.Controls.Add(this.NFAParametersGroupBox);
            this.Name = "NFAtesterForm";
            this.Text = "NFAtester";
            this.NFAParametersGroupBox.ResumeLayout(false);
            this.NFAParametersGroupBox.PerformLayout();
            this.TestInputGroupBox.ResumeLayout(false);
            this.TestInputGroupBox.PerformLayout();
            this.ResultGroupBox.ResumeLayout(false);
            this.ResultGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox NFAParametersGroupBox;
        private System.Windows.Forms.TextBox transitionTextBox;
        private System.Windows.Forms.Label transitionLabel;
        private System.Windows.Forms.TextBox finalStateTextBox;
        private System.Windows.Forms.Label finalStateLabel;
        private System.Windows.Forms.TextBox initialStateTextBox;
        private System.Windows.Forms.Label initialStateLabel;
        private System.Windows.Forms.TextBox alphabetTextBox;
        private System.Windows.Forms.Label alphabetLabel;
        private System.Windows.Forms.TextBox numberOfStatesTextBox;
        private System.Windows.Forms.Label numberOfStatesLabel;
        private System.Windows.Forms.GroupBox TestInputGroupBox;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.TextBox testInputTextBox;
        private System.Windows.Forms.Label testInputLabel;
        private System.Windows.Forms.GroupBox ResultGroupBox;
        private System.Windows.Forms.Label resultLabel;
    }
}

