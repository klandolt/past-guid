namespace NewGuid
{
    partial class PastGuid
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PastGuid));
            this.getnewGuidButton = new System.Windows.Forms.Button();
            this.guidTextBox = new System.Windows.Forms.TextBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusBarLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // getnewGuidButton
            // 
            this.getnewGuidButton.AutoSize = true;
            this.getnewGuidButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.getnewGuidButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getnewGuidButton.Location = new System.Drawing.Point(12, 12);
            this.getnewGuidButton.Name = "getnewGuidButton";
            this.getnewGuidButton.Size = new System.Drawing.Size(340, 70);
            this.getnewGuidButton.TabIndex = 0;
            this.getnewGuidButton.Text = "Get New Guid";
            this.getnewGuidButton.UseVisualStyleBackColor = true;
            this.getnewGuidButton.Click += new System.EventHandler(this.getnewGuid_Click);
            // 
            // guidTextBox
            // 
            this.guidTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guidTextBox.Location = new System.Drawing.Point(12, 130);
            this.guidTextBox.Name = "guidTextBox";
            this.guidTextBox.Size = new System.Drawing.Size(340, 26);
            this.guidTextBox.TabIndex = 1;
            this.guidTextBox.Text = "Push the Button for new GUID";
            this.guidTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // infoLabel
            // 
            this.infoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(5, 93);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(351, 26);
            this.infoLabel.TabIndex = 2;
            this.infoLabel.Text = "Über den Button oder die Tastenkombination (CTRL + G) wird eine GUID\r\nerzeugt und" +
    " in der Zwischenablage abgelegt bzw. ausgegeben!";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 171);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(363, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusBarLabel
            // 
            this.statusBarLabel.Name = "statusBarLabel";
            this.statusBarLabel.Size = new System.Drawing.Size(297, 17);
            this.statusBarLabel.Text = "SourceCode on https://github.com/klandolt/past-guid";
            // 
            // PastGuid
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(363, 193);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.guidTextBox);
            this.Controls.Add(this.getnewGuidButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PastGuid";
            this.Text = "Past Guid by klandolt";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getnewGuidButton;
        private System.Windows.Forms.TextBox guidTextBox;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.ToolStripStatusLabel statusBarLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}

