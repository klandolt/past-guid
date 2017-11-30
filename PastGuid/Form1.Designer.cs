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
            this.checkBoxSeparator = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonNewLine = new System.Windows.Forms.RadioButton();
            this.radioButtonWhitespace = new System.Windows.Forms.RadioButton();
            this.radioButtonNoGuidSeparator = new System.Windows.Forms.RadioButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelCount = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 301);
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
            // checkBoxSeparator
            // 
            this.checkBoxSeparator.AutoSize = true;
            this.checkBoxSeparator.Location = new System.Drawing.Point(12, 281);
            this.checkBoxSeparator.Name = "checkBoxSeparator";
            this.checkBoxSeparator.Size = new System.Drawing.Size(198, 17);
            this.checkBoxSeparator.TabIndex = 4;
            this.checkBoxSeparator.Text = "Keine Trennzeichen / No separators";
            this.checkBoxSeparator.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonNewLine);
            this.groupBox1.Controls.Add(this.radioButtonWhitespace);
            this.groupBox1.Controls.Add(this.radioButtonNoGuidSeparator);
            this.groupBox1.Location = new System.Drawing.Point(13, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 88);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zwischenzeichen / Guid separator";
            // 
            // radioButtonNewLine
            // 
            this.radioButtonNewLine.AutoSize = true;
            this.radioButtonNewLine.Location = new System.Drawing.Point(7, 65);
            this.radioButtonNewLine.Name = "radioButtonNewLine";
            this.radioButtonNewLine.Size = new System.Drawing.Size(224, 17);
            this.radioButtonNewLine.TabIndex = 2;
            this.radioButtonNewLine.Text = "Absatz Trennzeichen / New line separator";
            this.radioButtonNewLine.UseVisualStyleBackColor = true;
            // 
            // radioButtonWhitespace
            // 
            this.radioButtonWhitespace.AutoSize = true;
            this.radioButtonWhitespace.Location = new System.Drawing.Point(7, 44);
            this.radioButtonWhitespace.Name = "radioButtonWhitespace";
            this.radioButtonWhitespace.Size = new System.Drawing.Size(271, 17);
            this.radioButtonWhitespace.TabIndex = 1;
            this.radioButtonWhitespace.Text = "Leerzeichen zwischen Guid\'s / Whitspace separator";
            this.radioButtonWhitespace.UseVisualStyleBackColor = true;
            // 
            // radioButtonNoGuidSeparator
            // 
            this.radioButtonNoGuidSeparator.AutoSize = true;
            this.radioButtonNoGuidSeparator.Checked = true;
            this.radioButtonNoGuidSeparator.Location = new System.Drawing.Point(7, 20);
            this.radioButtonNoGuidSeparator.Name = "radioButtonNoGuidSeparator";
            this.radioButtonNoGuidSeparator.Size = new System.Drawing.Size(114, 17);
            this.radioButtonNoGuidSeparator.TabIndex = 0;
            this.radioButtonNoGuidSeparator.TabStop = true;
            this.radioButtonNoGuidSeparator.Text = "Kein Trennzeichen";
            this.radioButtonNoGuidSeparator.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(13, 163);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(58, 20);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(77, 165);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(127, 13);
            this.labelCount.TabIndex = 7;
            this.labelCount.Text = "Anzahl Guid / Guid count";
            // 
            // PastGuid
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(363, 323);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBoxSeparator);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getnewGuidButton;
        private System.Windows.Forms.TextBox guidTextBox;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.ToolStripStatusLabel statusBarLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.CheckBox checkBoxSeparator;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonNewLine;
        private System.Windows.Forms.RadioButton radioButtonWhitespace;
        private System.Windows.Forms.RadioButton radioButtonNoGuidSeparator;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label labelCount;
    }
}

