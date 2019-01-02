namespace EasyBank
{
    partial class AdminForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelHelp = new System.Windows.Forms.Label();
            this.tabC = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAddDep = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAddMan = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonChange = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbFIO = new System.Windows.Forms.TextBox();
            this.cbAdmin = new System.Windows.Forms.CheckBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelCheck = new System.Windows.Forms.Label();
            this.labelFIO = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonRemove2 = new System.Windows.Forms.Button();
            this.buttonSave2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbYear = new System.Windows.Forms.CheckBox();
            this.cbMonth = new System.Windows.Forms.CheckBox();
            this.tbMaxSum = new System.Windows.Forms.TextBox();
            this.tbPerc = new System.Windows.Forms.TextBox();
            this.tbMinSum = new System.Windows.Forms.TextBox();
            this.tbMinT = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabC.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::EasyBank.Properties.Resources.back1;
            this.pictureBox1.Location = new System.Drawing.Point(14, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelHelp
            // 
            this.labelHelp.BackColor = System.Drawing.Color.Transparent;
            this.labelHelp.Image = global::EasyBank.Properties.Resources.help1;
            this.labelHelp.Location = new System.Drawing.Point(793, 1);
            this.labelHelp.Name = "labelHelp";
            this.labelHelp.Size = new System.Drawing.Size(58, 45);
            this.labelHelp.TabIndex = 18;
            this.labelHelp.Click += new System.EventHandler(this.labelHelp_Click);
            // 
            // tabC
            // 
            this.tabC.Controls.Add(this.tabPage1);
            this.tabC.Controls.Add(this.tabPage2);
            this.tabC.Controls.Add(this.tabPage3);
            this.tabC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabC.Location = new System.Drawing.Point(62, 14);
            this.tabC.Name = "tabC";
            this.tabC.SelectedIndex = 0;
            this.tabC.Size = new System.Drawing.Size(349, 416);
            this.tabC.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.btnAddDep);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(341, 390);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Депозиты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAddDep
            // 
            this.btnAddDep.Location = new System.Drawing.Point(104, 17);
            this.btnAddDep.Name = "btnAddDep";
            this.btnAddDep.Size = new System.Drawing.Size(139, 27);
            this.btnAddDep.TabIndex = 0;
            this.btnAddDep.Text = "Добавить депозит";
            this.btnAddDep.UseVisualStyleBackColor = true;
            this.btnAddDep.Click += new System.EventHandler(this.btnAddDep_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.btnAddMan);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(341, 390);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Сотрудники";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAddMan
            // 
            this.btnAddMan.Location = new System.Drawing.Point(101, 17);
            this.btnAddMan.Name = "btnAddMan";
            this.btnAddMan.Size = new System.Drawing.Size(139, 27);
            this.btnAddMan.TabIndex = 1;
            this.btnAddMan.Text = "Добавить сотрудника";
            this.btnAddMan.UseVisualStyleBackColor = true;
            this.btnAddMan.Click += new System.EventHandler(this.btnAddMan_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonChange);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(341, 390);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Файлы";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(95, 50);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(141, 41);
            this.buttonChange.TabIndex = 0;
            this.buttonChange.Text = "Изменить директорию базы данных";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.buttonRemove);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.tbLogin);
            this.panel1.Controls.Add(this.tbPassword);
            this.panel1.Controls.Add(this.tbFIO);
            this.panel1.Controls.Add(this.cbAdmin);
            this.panel1.Controls.Add(this.labelLogin);
            this.panel1.Controls.Add(this.labelPassword);
            this.panel1.Controls.Add(this.labelCheck);
            this.panel1.Controls.Add(this.labelFIO);
            this.panel1.Location = new System.Drawing.Point(439, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 321);
            this.panel1.TabIndex = 21;
            this.panel1.Visible = false;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemove.Location = new System.Drawing.Point(61, 170);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 23;
            this.buttonRemove.Text = "Удалить";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(236, 170);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbLogin
            // 
            this.tbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLogin.Location = new System.Drawing.Point(92, 50);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(260, 20);
            this.tbLogin.TabIndex = 7;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPassword.Location = new System.Drawing.Point(92, 79);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(260, 20);
            this.tbPassword.TabIndex = 6;
            // 
            // tbFIO
            // 
            this.tbFIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFIO.Location = new System.Drawing.Point(92, 21);
            this.tbFIO.Name = "tbFIO";
            this.tbFIO.Size = new System.Drawing.Size(260, 20);
            this.tbFIO.TabIndex = 5;
            // 
            // cbAdmin
            // 
            this.cbAdmin.AutoSize = true;
            this.cbAdmin.Location = new System.Drawing.Point(212, 125);
            this.cbAdmin.Name = "cbAdmin";
            this.cbAdmin.Size = new System.Drawing.Size(15, 14);
            this.cbAdmin.TabIndex = 4;
            this.cbAdmin.UseVisualStyleBackColor = true;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.BackColor = System.Drawing.Color.Transparent;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(26, 52);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(53, 16);
            this.labelLogin.TabIndex = 3;
            this.labelLogin.Text = "Логин: ";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.Location = new System.Drawing.Point(26, 81);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(60, 16);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Пароль:";
            // 
            // labelCheck
            // 
            this.labelCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCheck.Location = new System.Drawing.Point(26, 113);
            this.labelCheck.Name = "labelCheck";
            this.labelCheck.Size = new System.Drawing.Size(184, 42);
            this.labelCheck.TabIndex = 1;
            this.labelCheck.Text = "Разрешить доступ к режиму администратора";
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.BackColor = System.Drawing.Color.Transparent;
            this.labelFIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFIO.Location = new System.Drawing.Point(26, 23);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(45, 16);
            this.labelFIO.TabIndex = 0;
            this.labelFIO.Text = "ФИО: ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.buttonRemove2);
            this.panel2.Controls.Add(this.buttonSave2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cbYear);
            this.panel2.Controls.Add(this.cbMonth);
            this.panel2.Controls.Add(this.tbMaxSum);
            this.panel2.Controls.Add(this.tbPerc);
            this.panel2.Controls.Add(this.tbMinSum);
            this.panel2.Controls.Add(this.tbMinT);
            this.panel2.Controls.Add(this.tbName);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(439, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(378, 322);
            this.panel2.TabIndex = 22;
            this.panel2.Visible = false;
            // 
            // buttonRemove2
            // 
            this.buttonRemove2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemove2.Location = new System.Drawing.Point(58, 243);
            this.buttonRemove2.Name = "buttonRemove2";
            this.buttonRemove2.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove2.TabIndex = 15;
            this.buttonRemove2.Text = "Удалить";
            this.buttonRemove2.UseVisualStyleBackColor = true;
            this.buttonRemove2.Click += new System.EventHandler(this.buttonRemove2_Click);
            // 
            // buttonSave2
            // 
            this.buttonSave2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave2.Location = new System.Drawing.Point(233, 243);
            this.buttonSave2.Name = "buttonSave2";
            this.buttonSave2.Size = new System.Drawing.Size(75, 23);
            this.buttonSave2.TabIndex = 14;
            this.buttonSave2.Text = "Сохранить";
            this.buttonSave2.UseVisualStyleBackColor = true;
            this.buttonSave2.Click += new System.EventHandler(this.buttonSave2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(335, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "(дней)";
            // 
            // cbYear
            // 
            this.cbYear.AutoSize = true;
            this.cbYear.BackColor = System.Drawing.Color.Transparent;
            this.cbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbYear.Location = new System.Drawing.Point(286, 101);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(43, 17);
            this.cbYear.TabIndex = 12;
            this.cbYear.Text = "год";
            this.cbYear.UseVisualStyleBackColor = false;
            this.cbYear.Click += new System.EventHandler(this.cbYear_Click);
            // 
            // cbMonth
            // 
            this.cbMonth.AutoSize = true;
            this.cbMonth.BackColor = System.Drawing.Color.Transparent;
            this.cbMonth.Checked = true;
            this.cbMonth.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbMonth.Location = new System.Drawing.Point(212, 101);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(58, 17);
            this.cbMonth.TabIndex = 11;
            this.cbMonth.Text = "месяц";
            this.cbMonth.UseVisualStyleBackColor = false;
            this.cbMonth.Click += new System.EventHandler(this.cbMonth_Click);
            // 
            // tbMaxSum
            // 
            this.tbMaxSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMaxSum.Location = new System.Drawing.Point(165, 184);
            this.tbMaxSum.MaxLength = 16;
            this.tbMaxSum.Name = "tbMaxSum";
            this.tbMaxSum.Size = new System.Drawing.Size(164, 20);
            this.tbMaxSum.TabIndex = 10;
            this.tbMaxSum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMaxSum_KeyPress);
            // 
            // tbPerc
            // 
            this.tbPerc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPerc.Location = new System.Drawing.Point(127, 69);
            this.tbPerc.MaxLength = 5;
            this.tbPerc.Name = "tbPerc";
            this.tbPerc.Size = new System.Drawing.Size(202, 20);
            this.tbPerc.TabIndex = 9;
            this.tbPerc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPerc_KeyPress);
            // 
            // tbMinSum
            // 
            this.tbMinSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMinSum.Location = new System.Drawing.Point(165, 156);
            this.tbMinSum.MaxLength = 10;
            this.tbMinSum.Name = "tbMinSum";
            this.tbMinSum.Size = new System.Drawing.Size(164, 20);
            this.tbMinSum.TabIndex = 8;
            this.tbMinSum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMinSum_KeyPress);
            // 
            // tbMinT
            // 
            this.tbMinT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMinT.Location = new System.Drawing.Point(253, 127);
            this.tbMinT.MaxLength = 4;
            this.tbMinT.Name = "tbMinT";
            this.tbMinT.Size = new System.Drawing.Size(76, 20);
            this.tbMinT.TabIndex = 7;
            this.tbMinT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMinT_KeyPress);
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.Location = new System.Drawing.Point(127, 37);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(202, 20);
            this.tbName.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(41, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Процент:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(41, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Период начисления процента:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(41, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Минимальное время изменения счета:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(41, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Минимальная сумма:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(41, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Максимальная сумма:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(41, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название:";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EasyBank.Properties.Resources.mainFon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(844, 442);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tabC);
            this.Controls.Add(this.labelHelp);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EasyBank";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabC.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelHelp;
        private System.Windows.Forms.TabControl tabC;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.TextBox tbFIO;
        private System.Windows.Forms.CheckBox cbAdmin;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelCheck;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbYear;
        private System.Windows.Forms.CheckBox cbMonth;
        private System.Windows.Forms.TextBox tbMaxSum;
        private System.Windows.Forms.TextBox tbPerc;
        private System.Windows.Forms.TextBox tbMinSum;
        private System.Windows.Forms.TextBox tbMinT;
        private System.Windows.Forms.Button buttonSave2;
        private System.Windows.Forms.Button btnAddDep;
        private System.Windows.Forms.Button btnAddMan;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonRemove2;
    }
}