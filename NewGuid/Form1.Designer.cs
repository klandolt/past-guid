namespace NewGuid
{
    partial class Form1
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
            this.getnewGuid = new System.Windows.Forms.Button();
            this.guidTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // getnewGuid
            // 
            this.getnewGuid.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.getnewGuid.Location = new System.Drawing.Point(6, 18);
            this.getnewGuid.Name = "getnewGuid";
            this.getnewGuid.Size = new System.Drawing.Size(340, 70);
            this.getnewGuid.TabIndex = 0;
            this.getnewGuid.Text = "Get New Guid";
            this.getnewGuid.UseVisualStyleBackColor = true;
            this.getnewGuid.Click += new System.EventHandler(this.getnewGuid_Click);
            // 
            // guidTextBox
            // 
            this.guidTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guidTextBox.Location = new System.Drawing.Point(6, 153);
            this.guidTextBox.Name = "guidTextBox";
            this.guidTextBox.Size = new System.Drawing.Size(340, 26);
            this.guidTextBox.TabIndex = 1;
            this.guidTextBox.Text = "Push the Button for new GUID";
            this.guidTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Über den Button oder CTRL + G wird eine GUID erzeugt und in der Zwischenablage ab" +
    "gelegt!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 201);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guidTextBox);
            this.Controls.Add(this.getnewGuid);
            this.Name = "Form1";
            this.Text = "New Guid";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getnewGuid;
        private System.Windows.Forms.TextBox guidTextBox;
        private System.Windows.Forms.Label label1;
    }
}

