using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.IO;

namespace MiniPress_
{
    public partial class MiniPress : MetroFramework.Forms.MetroForm
    {
        String name;

        public MiniPress()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.StyleManager = metroStyleManager1;
        }
        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.ShowDialog();
            String name = Path.GetFileName(dialog.FileName);
            File.Copy(dialog.FileName, Path.Combine("htdoc", "img", Path.GetFileName(dialog.FileName)));
        }

        private void Light_Click(object sender, EventArgs e)
        {
            metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
        }

        private void Dark_Click(object sender, EventArgs e)
        {
            metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi Your File Name is " + name);
        }
    }
}
