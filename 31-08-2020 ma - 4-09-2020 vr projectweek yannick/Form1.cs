using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _31_08_2020_ma___4_09_2020_vr_projectweek_yannick
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void FolderMakenPlusLoonstrokenAfdrukken()
        {
            string Folder = Environment.CurrentDirectory + $"\\LOONBRIEVEN {DateTime.Now.ToString("MMMM yyyy")}\\";
            if (!Directory.Exists(Folder))
            {
                Directory.CreateDirectory(Folder);
            }

            foreach (var werknemer in Werknemers)
            {
                werknemer.Loonstroken(Folder);
            }
        }
    }
}
