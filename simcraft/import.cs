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
    public partial class import : Form
    {
        menedzerEq menedzer;
        public import(ref menedzerEq menedzerRef)
        {
            InitializeComponent();
            menedzer = menedzerRef;

        }

        private void importBtn_Click(object sender, EventArgs e)
        {
            importBtn.Enabled = false;
            importBtn.Text = "Importuję...";
            foreach(string linia in ImportTextBox.Lines)
            {
                menedzer.dodajPrzedmiot(linia);
                
            }
            Close();
        }
    }
}
