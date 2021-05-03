
namespace DifficultySettings1
{
    partial class Form1
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
            this.HeroName = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.DifficultySelect = new System.Windows.Forms.Label();
            this.EasyButton = new System.Windows.Forms.Button();
            this.MeduimButton = new System.Windows.Forms.Button();
            this.HardButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // HeroName
            // 
            this.HeroName.AutoSize = true;
            this.HeroName.BackColor = System.Drawing.Color.Black;
            this.HeroName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeroName.ForeColor = System.Drawing.Color.White;
            this.HeroName.Location = new System.Drawing.Point(23, 41);
            this.HeroName.Name = "HeroName";
            this.HeroName.Size = new System.Drawing.Size(386, 37);
            this.HeroName.TabIndex = 0;
            this.HeroName.Text = "What Is Your Name Hero:";
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(428, 47);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(300, 31);
            this.TextBox1.TabIndex = 1;
            // 
            // DifficultySelect
            // 
            this.DifficultySelect.AutoSize = true;
            this.DifficultySelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DifficultySelect.ForeColor = System.Drawing.Color.White;
            this.DifficultySelect.Location = new System.Drawing.Point(164, 159);
            this.DifficultySelect.Name = "DifficultySelect";
            this.DifficultySelect.Size = new System.Drawing.Size(403, 37);
            this.DifficultySelect.TabIndex = 3;
            this.DifficultySelect.Text = "Select Your Difficulty Level:";
            // 
            // EasyButton
            // 
            this.EasyButton.BackColor = System.Drawing.Color.Black;
            this.EasyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.EasyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.EasyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EasyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EasyButton.ForeColor = System.Drawing.Color.White;
            this.EasyButton.Location = new System.Drawing.Point(59, 258);
            this.EasyButton.Name = "EasyButton";
            this.EasyButton.Size = new System.Drawing.Size(133, 58);
            this.EasyButton.TabIndex = 4;
            this.EasyButton.Text = "Easy";
            this.EasyButton.UseVisualStyleBackColor = false;
            this.EasyButton.Click += new System.EventHandler(this.EasyButton_Click);
            // 
            // MeduimButton
            // 
            this.MeduimButton.BackColor = System.Drawing.Color.Black;
            this.MeduimButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.MeduimButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.MeduimButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MeduimButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeduimButton.ForeColor = System.Drawing.Color.White;
            this.MeduimButton.Location = new System.Drawing.Point(303, 258);
            this.MeduimButton.Name = "MeduimButton";
            this.MeduimButton.Size = new System.Drawing.Size(138, 58);
            this.MeduimButton.TabIndex = 5;
            this.MeduimButton.Text = "Meduim ";
            this.MeduimButton.UseVisualStyleBackColor = false;
            this.MeduimButton.Click += new System.EventHandler(this.MeduimButton_Click);
            // 
            // HardButton
            // 
            this.HardButton.BackColor = System.Drawing.Color.Black;
            this.HardButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.HardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.HardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HardButton.ForeColor = System.Drawing.Color.White;
            this.HardButton.Location = new System.Drawing.Point(555, 258);
            this.HardButton.Name = "HardButton";
            this.HardButton.Size = new System.Drawing.Size(138, 58);
            this.HardButton.TabIndex = 6;
            this.HardButton.Text = "Hard";
            this.HardButton.UseVisualStyleBackColor = false;
            this.HardButton.Click += new System.EventHandler(this.HardButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.Color.Black;
            this.PlayButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.PlayButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayButton.ForeColor = System.Drawing.Color.White;
            this.PlayButton.Location = new System.Drawing.Point(259, 379);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(200, 75);
            this.PlayButton.TabIndex = 7;
            this.PlayButton.Text = "Begin";
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // TextBox2
            // 
            this.TextBox2.BackColor = System.Drawing.Color.Black;
            this.TextBox2.ForeColor = System.Drawing.Color.White;
            this.TextBox2.Location = new System.Drawing.Point(150, 516);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(500, 31);
            this.TextBox2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(788, 573);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.HardButton);
            this.Controls.Add(this.MeduimButton);
            this.Controls.Add(this.EasyButton);
            this.Controls.Add(this.DifficultySelect);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.HeroName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeroName;
        private System.Windows.Forms.MaskedTextBox TextBox1;
        private System.Windows.Forms.Label DifficultySelect;
        private System.Windows.Forms.Button EasyButton;
        private System.Windows.Forms.Button MeduimButton;
        private System.Windows.Forms.Button HardButton;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.TextBox TextBox2;
    }
}

