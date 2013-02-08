namespace Visual_N_Queens_Solver
{
    partial class InputForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.solveButton = new System.Windows.Forms.Button();
            this.nQueensInput = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.solutionsList = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of Queens:";
            // 
            // solveButton
            // 
            this.solveButton.Location = new System.Drawing.Point(197, 29);
            this.solveButton.Name = "solveButton";
            this.solveButton.Size = new System.Drawing.Size(75, 23);
            this.solveButton.TabIndex = 2;
            this.solveButton.Text = "Solve!";
            this.solveButton.UseVisualStyleBackColor = true;
            this.solveButton.Click += new System.EventHandler(this.solveButton_Click);
            // 
            // nQueensInput
            // 
            this.nQueensInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.nQueensInput.Location = new System.Drawing.Point(117, 19);
            this.nQueensInput.MaxLength = 2;
            this.nQueensInput.Name = "nQueensInput";
            this.nQueensInput.Size = new System.Drawing.Size(69, 44);
            this.nQueensInput.TabIndex = 3;
            this.nQueensInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nQueensInput_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.solutionsList);
            this.groupBox1.Location = new System.Drawing.Point(12, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 242);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Solutions";
            // 
            // solutionsList
            // 
            this.solutionsList.FormattingEnabled = true;
            this.solutionsList.Location = new System.Drawing.Point(6, 17);
            this.solutionsList.Name = "solutionsList";
            this.solutionsList.Size = new System.Drawing.Size(248, 212);
            this.solutionsList.TabIndex = 0;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 323);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nQueensInput);
            this.Controls.Add(this.solveButton);
            this.Controls.Add(this.label1);
            this.Name = "InputForm";
            this.Text = "N-Queens Solver";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button solveButton;
        private System.Windows.Forms.TextBox nQueensInput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox solutionsList;
    }
}

