using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;


namespace EmguCv_tutorial_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if(ofd.ShowDialog()==DialogResult.OK)
                    {
                    Image<Bgr, byte> imgInput = new Image<Bgr, byte>(ofd.FileName);

                    picOpen.Image = imgInput.Bitmap;
                    }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
