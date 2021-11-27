using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3_3_1204013
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rbKyeboard_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbmouse_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (rbmouse.Checked == true)
            { 
        tulis.Text = "Cocok! Ini adalah gambar mouse";
            }
       else
       {
      tulis.Text = "Tidak cocok! Anda memilih gambar yang salah/nIni adalah gambar mouse";
                 }
        }

        private void tsbkeyboard_Click(object sender, EventArgs e)
        {
            
    
}
        }
    
}
