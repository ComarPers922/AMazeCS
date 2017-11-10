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
            this.Button_Generate.Location = new System.Drawing.Point(727, 12);
            this.Button_Generate.Name = "Button_Generate";
            this.Button_Generate.Size = new System.Drawing.Size(98, 45);
            this.Button_Generate.TabIndex = 1;
            this.Button_Generate.Text = "生成地图";
            this.Button_Generate.UseVisualStyleBackColor = true;
            this.Button_Generate.Click += new System.EventHandler(this.Button_Generate_Click);
            // 
            // Button_Solve
            // 
            this.Button_Solve.Location = new System.Drawing.Point(727, 63);
            this.Button_Solve.Name = "Button_Solve";
            this.Button_Solve.Size = new System.Drawing.Size(98, 44);
            this.Button_Solve.TabIndex = 2;
            this.Button_Solve.Text = "解题";
            this.Button_Solve.UseVisualStyleBackColor = true;
            this.Button_Solve.Click += new System.EventHandler(this.Button_Solve_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 719);
            this.Controls.Add(this.Button_Solve);
            this.Controls.Add(this.Button_Generate);
            this.Controls.Add(this.Panel_Game);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "AMaze";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Game;
        private System.Windows.Forms.Button Button_Generate;
        private System.Windows.Forms.Button Button_Solve;
    }
}

