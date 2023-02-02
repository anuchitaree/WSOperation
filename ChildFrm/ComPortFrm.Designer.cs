namespace WSOperation.ChildFrm
{
    partial class ComPortFrm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnReload = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.CmbDatDirection = new System.Windows.Forms.ComboBox();
            this.CmbStopBit = new System.Windows.Forms.ComboBox();
            this.CmbDatalength = new System.Windows.Forms.ComboBox();
            this.CmbParity = new System.Windows.Forms.ComboBox();
            this.CmbBaudRate = new System.Windows.Forms.ComboBox();
            this.CmbCom = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TbTrial = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.BtnReload);
            this.panel1.Controls.Add(this.BtnSave);
            this.panel1.Controls.Add(this.CmbDatDirection);
            this.panel1.Controls.Add(this.CmbStopBit);
            this.panel1.Controls.Add(this.CmbDatalength);
            this.panel1.Controls.Add(this.CmbParity);
            this.panel1.Controls.Add(this.CmbBaudRate);
            this.panel1.Controls.Add(this.CmbCom);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(35, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 357);
            this.panel1.TabIndex = 0;
            // 
            // BtnReload
            // 
            this.BtnReload.Location = new System.Drawing.Point(120, 260);
            this.BtnReload.Name = "BtnReload";
            this.BtnReload.Size = new System.Drawing.Size(83, 32);
            this.BtnReload.TabIndex = 17;
            this.BtnReload.Text = "Reload";
            this.BtnReload.UseVisualStyleBackColor = true;
            this.BtnReload.Click += new System.EventHandler(this.BtnReload_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(209, 260);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(83, 32);
            this.BtnSave.TabIndex = 16;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // CmbDatDirection
            // 
            this.CmbDatDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDatDirection.FormattingEnabled = true;
            this.CmbDatDirection.Location = new System.Drawing.Point(171, 225);
            this.CmbDatDirection.Name = "CmbDatDirection";
            this.CmbDatDirection.Size = new System.Drawing.Size(121, 23);
            this.CmbDatDirection.TabIndex = 10;
            this.CmbDatDirection.Visible = false;
            // 
            // CmbStopBit
            // 
            this.CmbStopBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbStopBit.FormattingEnabled = true;
            this.CmbStopBit.Location = new System.Drawing.Point(171, 183);
            this.CmbStopBit.Name = "CmbStopBit";
            this.CmbStopBit.Size = new System.Drawing.Size(121, 23);
            this.CmbStopBit.TabIndex = 11;
            // 
            // CmbDatalength
            // 
            this.CmbDatalength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDatalength.FormattingEnabled = true;
            this.CmbDatalength.Location = new System.Drawing.Point(171, 151);
            this.CmbDatalength.Name = "CmbDatalength";
            this.CmbDatalength.Size = new System.Drawing.Size(121, 23);
            this.CmbDatalength.TabIndex = 12;
            // 
            // CmbParity
            // 
            this.CmbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbParity.FormattingEnabled = true;
            this.CmbParity.Location = new System.Drawing.Point(171, 114);
            this.CmbParity.Name = "CmbParity";
            this.CmbParity.Size = new System.Drawing.Size(121, 23);
            this.CmbParity.TabIndex = 13;
            // 
            // CmbBaudRate
            // 
            this.CmbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBaudRate.FormattingEnabled = true;
            this.CmbBaudRate.Location = new System.Drawing.Point(171, 80);
            this.CmbBaudRate.Name = "CmbBaudRate";
            this.CmbBaudRate.Size = new System.Drawing.Size(121, 23);
            this.CmbBaudRate.TabIndex = 14;
            // 
            // CmbCom
            // 
            this.CmbCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCom.FormattingEnabled = true;
            this.CmbCom.Location = new System.Drawing.Point(171, 46);
            this.CmbCom.Name = "CmbCom";
            this.CmbCom.Size = new System.Drawing.Size(121, 23);
            this.CmbCom.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Data direction";
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Stop bit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data length";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Parity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Buad rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "COM Port";
            // 
            // TbTrial
            // 
            this.TbTrial.Location = new System.Drawing.Point(25, 402);
            this.TbTrial.Name = "TbTrial";
            this.TbTrial.Size = new System.Drawing.Size(703, 23);
            this.TbTrial.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Communication port for Scanner ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 384);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Reading message from scanner";
            // 
            // ComPortFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TbTrial);
            this.Controls.Add(this.panel1);
            this.Name = "ComPortFrm";
            this.Text = "OperationFrm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OperationFrm_FormClosing);
            this.Load += new System.EventHandler(this.OperationFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button BtnReload;
        private Button BtnSave;
        private ComboBox CmbDatDirection;
        private ComboBox CmbStopBit;
        private ComboBox CmbDatalength;
        private ComboBox CmbParity;
        private ComboBox CmbBaudRate;
        private ComboBox CmbCom;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox TbTrial;
        private System.Windows.Forms.Timer timer1;
        private Label label7;
        private Label label8;
    }
}