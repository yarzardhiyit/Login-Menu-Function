namespace Login_Menu_Function
{
    partial class frmMain
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
            this.lblNth = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNth
            // 
            this.lblNth.AutoSize = true;
            this.lblNth.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNth.Location = new System.Drawing.Point(317, 190);
            this.lblNth.Name = "lblNth";
            this.lblNth.Size = new System.Drawing.Size(169, 33);
            this.lblNth.TabIndex = 0;
            this.lblNth.Text = "Nothing Here!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "I\'ve already add Application.Exit(); in FormClosing";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 413);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNth);
            this.MaximumSize = new System.Drawing.Size(820, 460);
            this.MinimumSize = new System.Drawing.Size(820, 460);
            this.Name = "frmMain";
            this.Text = "Hello World";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNth;
        private System.Windows.Forms.Label label1;
    }
}

