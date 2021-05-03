using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DifficultySettings1
{
    
    public partial class Form1 : Form
    {
        string heroName;
        string difficultyLevel;

        public Form1()
        {
            InitializeComponent();
        }

        private void EasyButton_Click(object sender, EventArgs e)
        {
            heroName = TextBox1.Text;
            difficultyLevel = "easy";

         


        }

        
       
        private void PlayButton_Click(object sender, EventArgs e)
        {
            TextBox2.Text = $"Your difficulty is {difficultyLevel} {heroName}";
        }

        private void MeduimButton_Click(object sender, EventArgs e)
        {
            heroName = TextBox1.Text;
            difficultyLevel = "Meduim";
        }

        private void HardButton_Click(object sender, EventArgs e)
        {
            heroName = TextBox1.Text;
            difficultyLevel = "Hard";
        }
    }
}
