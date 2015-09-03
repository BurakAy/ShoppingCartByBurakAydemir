using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace burakAydemirFinalProject
{
    public partial class frmItemImage : Form
    {
        Image item;

        public frmItemImage()
        {
            InitializeComponent();
        }

        public frmItemImage(Image i)
        {
            item = i;
            InitializeComponent();
        }

        private void ItemImage_Load(object sender, EventArgs e)
        {
            pbItem.Image = item;       
        }

    }//end class
}
