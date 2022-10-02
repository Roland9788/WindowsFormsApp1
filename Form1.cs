using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Кнопка : Form
    {
        public Кнопка()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Aqua;
            button1.Text = "Поймал!";
        }

        private void button1_Move(object sender, EventArgs e)
        {
            Random r = new Random();
            button1.Left = r.Next(0, this.Size.Width - button1.Width);
            button1.Top = r.Next(0, this.Size.Height - button1.Height);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
