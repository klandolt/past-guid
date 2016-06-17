using System;
using System.Windows.Forms;
// ReSharper disable UnusedMember.Local
// ReSharper disable UnusedVariable

namespace NewGuid
{
    public partial class Form1 : Form
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

        public Form1()
        {
            InitializeComponent();

            int id = 0;     // The id of the hotkey. 
            RegisterHotKey(Handle, id, (int)KeyModifier.Control, Keys.G.GetHashCode());  

           

        }

        private void getnewGuid_Click(object sender, EventArgs e)
        {
            GetNewGuid();
        }


        private void GetNewGuid()
        {
            // Create and display the value of two GUIDs.
            var g = Guid.NewGuid();

            guidTextBox.Text = g.ToString();
            Clipboard.SetText(g.ToString());
            
        }

       
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == 0x0312)
            {
                /* Note that the three lines below are not needed if you only want to register one hotkey.
                 * The below lines are useful in case you want to register multiple keys, which you can use a switch with the id as argument, or if you want to know which key/modifier was pressed for some particular reason. */

                Keys key = (Keys)(((int)m.LParam >> 16) & 0xFFFF);                  // The key of the hotkey that was pressed.
                KeyModifier modifier = (KeyModifier)((int)m.LParam & 0xFFFF);       // The modifier of the hotkey that was pressed.
                int id = m.WParam.ToInt32();                                        // The id of the hotkey that was pressed.

                if(id == 0 )
                {
                    GetNewGuid();
                    SendKeys.Send("^{v}");
                }

            }
        }
       

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            UnregisterHotKey(Handle, 0);   
        } 

    }
}
