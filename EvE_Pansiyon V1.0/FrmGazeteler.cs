using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvE_Pansiyon_V1._0
{
    public partial class FrmGazeteler : Form
    {
        public FrmGazeteler()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.hurriyet.com.tr/");
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.milliyet.com.tr/");
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.sozcu.com.tr/");
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.haberturk.com/");
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.fanatik.com.tr/");
            webBrowser1.ScriptErrorsSuppressed = true;
        }
    }
}
