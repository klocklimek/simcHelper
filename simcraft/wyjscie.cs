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
    public partial class wyjscie : Form
    {
        string zawartosc = "";
        public wyjscie(string zawartosc)
        {
            this.zawartosc = zawartosc;
            InitializeComponent();
            this.richTextBox1.Text = zawartosc;
            this.richTextBox1.SelectAll();
        }
    }
}
