namespace EasyBank
{
    partial class MainForm
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
            this.labelHelp = new System.Windows.Forms.Label();
            this.labelShowInvestors = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // labelHelp
            // 
            this.labelHelp.BackColor = System.Drawing.Color.Transparent;
            this.labelHelp.Image = global::EasyBank.Properties.Resources.help1;
            this.labelHelp.Location = new System.Drawing.Point(12, 9);
            this.labelHelp.Name = "labelHelp";
            this.labelHelp.Size = new System.Drawing.Size(50, 39);
            this.labelHelp.TabIndex = 4;
            this.labelHelp.Click += new System.EventHandler(this.labelHelp_Click);
            // 
            // labelShowInvestors
            // 
            this.labelShowInvestors.BackColor = System.Drawing.Color.Transparent;
            this.labelShowInvestors.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelShowInvestors.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelShowInvestors.Location = new System.Drawing.Point(85, 268);
            this.labelShowInvestors.Name = "labelShowInvestors";
            this.labelShowInvestors.Size = new System.Drawing.Size(288, 91);
            this.labelShowInvestors.TabIndex = 6;
            this.labelShowInvestors.Text = "Активные вклады";
            this.labelShowInvestors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelShowInvestors.Click += new System.EventHandler(this.labelShowInvestors_Click);
            // 
            // labelName
            // 
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Image = global::EasyBank.Properties.Resources.nameIMG;
            this.labelName.Location = new System.Drawing.Point(0, 136);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(468, 118);
            this.labelName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(85, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 91);
            this.label1.TabIndex = 7;
            this.label1.Text = "Режим администратора";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(459, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 358);
            this.panel1.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EasyBank.Properties.Resources.mainFon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 442);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelShowInvestors);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelHelp);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "MainForm";
            this.Text = "Easy Bank";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelHelp;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelShowInvestors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}