using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageViewer
{
    public partial class FormViewer : Form
    {
        public FormViewer()
        {
            InitializeComponent();
        }
        public Image ImageBox
        {
            set
            {
                this.pictureBox1.Image = value;
                this.pictureBox1.Size = value.Size;
            }
        }

        private void FormViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(pictureBox1 != null)
            {
                pictureBox1.Dispose();
            }
        }
    }
}
