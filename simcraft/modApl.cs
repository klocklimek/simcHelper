using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simcraft
{
    public partial class modApl : Form
    {
        menedzerEq menedzer;
        public modApl(ref menedzerEq menedzerRef)
        {
            InitializeComponent();
            menedzer = menedzerRef;
            richTextBox1.Text = menedzer.apl;
        }

        private void btn_Zapisz_Click(object sender, EventArgs e)
        {
            menedzer.apl = richTextBox1.Text;
            Close();
            
        }
    }
}
