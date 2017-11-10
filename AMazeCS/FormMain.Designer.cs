namespace AMazeCS
{
    partial class FormMain
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
            this.Panel_Game = new System.Windows.Forms.Panel();
            this.Button_Generate = new System.Windows.Forms.Button();
            this.Button_Solve = new System.Windows.Forms.Button();
            this.Button_SolveUsingFromTo = new System.Windows.Forms.Button();
            this.TextBox_FromX = new System.Windows.Forms.TextBox();
            this.TextBox_FromY = new System.Windows.Forms.TextBox();
            this.TextBox_ToY = new System.Windows.Forms.TextBox();
            this.TextBox_ToX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Panel_Game
            // 
            this.Panel_Game.Location = new System.Drawing.Point(12, 12);
            this.Panel_Game.Name = "Panel_Game";
            this.Panel_Game.Size = new System.Drawing.Size(700, 700);
            this.Panel_Game.TabIndex = 0;
            this.Panel_Game.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Game_Paint);
            // 
            // Button_Generate
            // 
            this.Button_Generate.Location = new System.Drawing.Point(718, 12);
            this.Button_Generate.Name = "Button_Generate";
            this.Button_Generate.Size = new System.Drawing.Size(107, 45);
            this.Button_Generate.TabIndex = 1;
            this.Button_Generate.Text = "生成地图";
            this.Button_Generate.UseVisualStyleBackColor = true;
            this.Button_Generate.Click += new System.EventHandler(this.Button_Generate_Click);
            // 
            // Button_Solve
            // 
            this.Button_Solve.Location = new System.Drawing.Point(718, 63);
            this.Button_Solve.Name = "Button_Solve";
            this.Button_Solve.Size = new System.Drawing.Size(107, 44);
            this.Button_Solve.TabIndex = 2;
            this.Button_Solve.Text = "解题";
            this.Button_Solve.UseVisualStyleBackColor = true;
            this.Button_Solve.Click += new System.EventHandler(this.Button_Solve_Click);
            // 
            // Button_SolveUsingFromTo
            // 
            this.Button_SolveUsingFromTo.Location = new System.Drawing.Point(718, 298);
            this.Button_SolveUsingFromTo.Name = "Button_SolveUsingFromTo";
            this.Button_SolveUsingFromTo.Size = new System.Drawing.Size(107, 44);
            this.Button_SolveUsingFromTo.TabIndex = 3;
            this.Button_SolveUsingFromTo.Text = "按标定点求解";
            this.Button_SolveUsingFromTo.UseVisualStyleBackColor = true;
            this.Button_SolveUsingFromTo.Click += new System.EventHandler(this.Button_SolveUsingFromTo_Click);
            // 
            // TextBox_FromX
            // 
            this.TextBox_FromX.Location = new System.Drawing.Point(718, 177);
            this.TextBox_FromX.Name = "TextBox_FromX";
            this.TextBox_FromX.Size = new System.Drawing.Size(35, 22);
            this.TextBox_FromX.TabIndex = 4;
            // 
            // TextBox_FromY
            // 
            this.TextBox_FromY.Location = new System.Drawing.Point(781, 177);
            this.TextBox_FromY.Name = "TextBox_FromY";
            this.TextBox_FromY.Size = new System.Drawing.Size(35, 22);
            this.TextBox_FromY.TabIndex = 5;
            // 
            // TextBox_ToY
            // 
            this.TextBox_ToY.Location = new System.Drawing.Point(781, 243);
            this.TextBox_ToY.Name = "TextBox_ToY";
            this.TextBox_ToY.Size = new System.Drawing.Size(35, 22);
            this.TextBox_ToY.TabIndex = 7;
            // 
            // TextBox_ToX
            // 
            this.TextBox_ToX.Location = new System.Drawing.Point(718, 243);
            this.TextBox_ToX.Name = "TextBox_ToX";
            this.TextBox_ToX.Size = new System.Drawing.Size(35, 22);
            this.TextBox_ToX.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(718, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "从：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(727, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(790, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(790, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(727, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(718, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "到：";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 719);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBox_ToY);
            this.Controls.Add(this.TextBox_ToX);
            this.Controls.Add(this.TextBox_FromY);
            this.Controls.Add(this.TextBox_FromX);
            this.Controls.Add(this.Button_SolveUsingFromTo);
            this.Controls.Add(this.Button_Solve);
            this.Controls.Add(this.Button_Generate);
            this.Controls.Add(this.Panel_Game);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "AMaze";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Game;
        private System.Windows.Forms.Button Button_Generate;
        private System.Windows.Forms.Button Button_Solve;
        private System.Windows.Forms.Button Button_SolveUsingFromTo;
        private System.Windows.Forms.TextBox TextBox_FromX;
        private System.Windows.Forms.TextBox TextBox_FromY;
        private System.Windows.Forms.TextBox TextBox_ToY;
        private System.Windows.Forms.TextBox TextBox_ToX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

