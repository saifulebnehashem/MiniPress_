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
        string fileName;

        public MiniPress()
        {
            InitializeComponent();
            StyleManager = metroStyleManager1;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            fileName = Path.GetFileName(dialog.FileName);
            Directory.CreateDirectory(Path.Combine("htdoc", "img"));
            File.Copy(dialog.FileName, Path.Combine("htdoc", "img", Path.GetFileName(dialog.FileName)),true);
        }

        private void Theme_Click(object sender, EventArgs e)
        {
            StyleManager.Theme = (StyleManager.Theme == MetroFramework.MetroThemeStyle.Light) ?
                MetroFramework.MetroThemeStyle.Dark : MetroFramework.MetroThemeStyle.Light;
            ThemeBtn.Text = (StyleManager.Theme == MetroFramework.MetroThemeStyle.Light) ?
                "Dark" : "Light";
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Hi Your File Name is {fileName}");
        }
    }
}
