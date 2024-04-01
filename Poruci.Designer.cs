namespace Narudzbina
{
    partial class Poruci
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbReceiver = new System.Windows.Forms.TextBox();
            this.btnPoruci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbReceiver
            // 
            this.tbReceiver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.tbReceiver.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbReceiver.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbReceiver.ForeColor = System.Drawing.Color.White;
            this.tbReceiver.Location = new System.Drawing.Point(25, 50);
            this.tbReceiver.Name = "tbReceiver";
            this.tbReceiver.PlaceholderText = "Mail";
            this.tbReceiver.Size = new System.Drawing.Size(250, 20);
            this.tbReceiver.TabIndex = 0;
            // 
            // btnPoruci
            // 
            this.btnPoruci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.btnPoruci.FlatAppearance.BorderSize = 0;
            this.btnPoruci.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(125)))));
            this.btnPoruci.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.btnPoruci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPoruci.ForeColor = System.Drawing.Color.White;
            this.btnPoruci.Location = new System.Drawing.Point(75, 100);
            this.btnPoruci.Name = "btnPoruci";
            this.btnPoruci.Size = new System.Drawing.Size(150, 25);
            this.btnPoruci.TabIndex = 1;
            this.btnPoruci.Text = "Poruči";
            this.btnPoruci.UseVisualStyleBackColor = false;
            this.btnPoruci.Click += new System.EventHandler(this.btnPoruci_Click);
            // 
            // Poruci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(300, 175);
            this.Controls.Add(this.btnPoruci);
            this.Controls.Add(this.tbReceiver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Poruci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Poruci";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbReceiver;
        private Button btnPoruci;
    }
}