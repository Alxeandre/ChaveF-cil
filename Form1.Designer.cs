namespace ChaveFacil
{
    partial class FrmChaveFacil
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
            this.btnRtrS1 = new System.Windows.Forms.Button();
            this.btnDvlrS1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblS1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRtrS1
            // 
            this.btnRtrS1.Location = new System.Drawing.Point(11, 74);
            this.btnRtrS1.Name = "btnRtrS1";
            this.btnRtrS1.Size = new System.Drawing.Size(75, 23);
            this.btnRtrS1.TabIndex = 0;
            this.btnRtrS1.Text = "RETIRAR";
            this.btnRtrS1.UseVisualStyleBackColor = true;
            this.btnRtrS1.Click += new System.EventHandler(this.btnRtrS1_Click);
            // 
            // btnDvlrS1
            // 
            this.btnDvlrS1.Enabled = false;
            this.btnDvlrS1.Location = new System.Drawing.Point(91, 73);
            this.btnDvlrS1.Name = "btnDvlrS1";
            this.btnDvlrS1.Size = new System.Drawing.Size(75, 23);
            this.btnDvlrS1.TabIndex = 1;
            this.btnDvlrS1.Text = "DEVOLVER";
            this.btnDvlrS1.UseVisualStyleBackColor = true;
            this.btnDvlrS1.Click += new System.EventHandler(this.btnDvlrS1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.Controls.Add(this.lblS1);
            this.panel1.Controls.Add(this.btnRtrS1);
            this.panel1.Controls.Add(this.btnDvlrS1);
            this.panel1.Location = new System.Drawing.Point(34, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 108);
            this.panel1.TabIndex = 2;
            // 
            // lblS1
            // 
            this.lblS1.AutoSize = true;
            this.lblS1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblS1.Location = new System.Drawing.Point(57, 14);
            this.lblS1.Name = "lblS1";
            this.lblS1.Size = new System.Drawing.Size(70, 17);
            this.lblS1.TabIndex = 2;
            this.lblS1.Text = "SALA 01";
            // 
            // FrmChaveFacil
            // 
            this.ClientSize = new System.Drawing.Size(918, 436);
            this.Controls.Add(this.panel1);
            this.Name = "FrmChaveFacil";
            this.Text = "ChaveFacil";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Button btnRtrS1;
        private System.Windows.Forms.Button btnDvlrS1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblS1;
    }
}

