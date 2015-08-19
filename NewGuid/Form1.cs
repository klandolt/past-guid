using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewGuid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getnewGuid_Click(object sender, EventArgs e)
        {
            Guid g;
            // Create and display the value of two GUIDs.
            g = Guid.NewGuid();

            guidTextBox.Text = g.ToString();
            System.Windows.Forms.Clipboard.SetText(g.ToString());

        }
    }
}
