using System;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;
// ReSharper disable SuggestVarOrType_SimpleTypes


// ReSharper disable UnusedMember.Local
// ReSharper disable UnusedVariable

namespace NewGuid
{
    public partial class PastGuid : Form
    {

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        /// <summary>
        /// Enum von möglichen Keys
        /// </summary>
        enum KeyModifier
        {
            None = 0,
            Alt = 1,
            Control = 2,
            Shift = 4,
            WinKey = 8
        }

        public PastGuid()
        {
            InitializeComponent();

            int id = 0; // The id of the hotkey. 
            RegisterHotKey(Handle, id, (int) KeyModifier.Control, Keys.G.GetHashCode());
        }

        private void getnewGuid_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(GetNewGuid());
        }


        private string GetNewGuid()
        {
            // Create and display the value of two GUIDs.
            var output = String.Empty;
            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                var g = Guid.NewGuid();
                output = output + g.ToString();

                // Zwischen trennzeichen einfügen
                if (radioButtonNoGuidSeparator.Checked)
                {
                    //Kein Trennzeichen einfügen
                }
                else if (radioButtonWhitespace.Checked)
                {
                    output = output + " ";
                }
                else if (radioButtonNewLine.Checked)
                {
                    output = output + Environment.NewLine;
                }

            }


            if (checkBoxSeparator.Checked)
            {
                output = output.Replace("-", "");
            }
            guidTextBox.Text = output;
            statusBarLabel.Text = @"Update Guid: " + DateTime.Now.ToString("dd.mm.yyyy HH:mm:ss.FFF");
            return output;
        }


        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == 0x0312)
            {
                /* Note that the three lines below are not needed if you only want to register one hotkey.
                 * The below lines are useful in case you want to register multiple keys, which you can use a switch with the id as argument, or if you want to know which key/modifier was pressed for some particular reason. */

                Keys key = (Keys) (((int) m.LParam >> 16) & 0xFFFF); // The key of the hotkey that was pressed.
                KeyModifier modifier = (KeyModifier) ((int) m.LParam & 0xFFFF);
                    // The modifier of the hotkey that was pressed.
                int id = m.WParam.ToInt32(); // The id of the hotkey that was pressed.

                if (id == 0)
                {
                    Clipboard.SetText(GetNewGuid());
                    SendKeys.Send("^{v}");
                }

            }
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            UnregisterHotKey(Handle, 0);
        }

        private void BtnFillExcel_Click(object sender, EventArgs e)
        {
            Application instance;
            try
            {
                instance = (Application) System.Runtime.InteropServices.Marshal.GetActiveObject("Excel.Application");
            }
            catch (System.Runtime.InteropServices.COMException ex)
            {
                MessageBox.Show(@"No Excel instance found!", @"No Excel", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk,
                    MessageBoxDefaultButton.Button1, (MessageBoxOptions)0x40000);
                return;
            }

            if (instance?.ActiveCell == null)
            {
                MessageBox.Show(@"No Excel instance found!", @"No Excel", MessageBoxButtons.OK, MessageBoxIcon.Asterisk,
                    MessageBoxDefaultButton.Button1, (MessageBoxOptions) 0x40000); // MB_TOPMOST
                return;
            }

            instance.Visible = true;
            Range selectedRange =
                instance.Selection as Range;

            if (selectedRange == null)
            {
                MessageBox.Show(@"No Selected Excel Cells Found!", @"No Cells in Excel", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk,
                    MessageBoxDefaultButton.Button1, (MessageBoxOptions) 0x40000);
                return;
            }

            try
            {
                foreach (Range c in selectedRange.Cells)
                {
                    c.Value2 = GetNewGuid();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Problem Past Guid!: " + exception, @"Excel-Guid", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk,
                    MessageBoxDefaultButton.Button1, (MessageBoxOptions)0x40000);
            }
            finally
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(instance);
            }


        }
    }
}
