namespace Traffic_fines
{
    partial class CfrmTraffic_Fines
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtinitialsSurname = new System.Windows.Forms.TextBox();
            this.txtIDNum = new System.Windows.Forms.TextBox();
            this.txtVehReg = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radSpeeding = new System.Windows.Forms.RadioButton();
            this.radOthers = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtVehReg);
            this.groupBox1.Controls.Add(this.txtIDNum);
            this.groupBox1.Controls.Add(this.txtinitialsSurname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 116);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driver";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Initials and Surname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vehicle Registration:";
            // 
            // txtinitialsSurname
            // 
            this.txtinitialsSurname.Location = new System.Drawing.Point(117, 26);
            this.txtinitialsSurname.Name = "txtinitialsSurname";
            this.txtinitialsSurname.Size = new System.Drawing.Size(163, 20);
            this.txtinitialsSurname.TabIndex = 3;
            // 
            // txtIDNum
            // 
            this.txtIDNum.Location = new System.Drawing.Point(117, 54);
            this.txtIDNum.Name = "txtIDNum";
            this.txtIDNum.Size = new System.Drawing.Size(163, 20);
            this.txtIDNum.TabIndex = 4;
            // 
            // txtVehReg
            // 
            this.txtVehReg.Location = new System.Drawing.Point(116, 83);
            this.txtVehReg.Name = "txtVehReg";
            this.txtVehReg.Size = new System.Drawing.Size(163, 20);
            this.txtVehReg.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radOthers);
            this.groupBox2.Controls.Add(this.radSpeeding);
            this.groupBox2.Location = new System.Drawing.Point(12, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(141, 78);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Offence";
            // 
            // radSpeeding
            // 
            this.radSpeeding.AutoSize = true;
            this.radSpeeding.Location = new System.Drawing.Point(9, 20);
            this.radSpeeding.Name = "radSpeeding";
            this.radSpeeding.Size = new System.Drawing.Size(70, 17);
            this.radSpeeding.TabIndex = 0;
            this.radSpeeding.TabStop = true;
            this.radSpeeding.Text = "Speeding";
            this.radSpeeding.UseVisualStyleBackColor = true;
            this.radSpeeding.Click += new System.EventHandler(this.radSpeeding_Click);
            // 
            // radOthers
            // 
            this.radOthers.AutoSize = true;
            this.radOthers.Location = new System.Drawing.Point(9, 43);
            this.radOthers.Name = "radOthers";
            this.radOthers.Size = new System.Drawing.Size(97, 17);
            this.radOthers.TabIndex = 1;
            this.radOthers.TabStop = true;
            this.radOthers.Text = "Other Offences";
            this.radOthers.UseVisualStyleBackColor = true;
            this.radOthers.Click += new System.EventHandler(this.radSpeeding_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnClose);
            this.groupBox3.Controls.Add(this.btnClear);
            this.groupBox3.Location = new System.Drawing.Point(159, 160);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(132, 78);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(6, 17);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 20);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(6, 52);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 20);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // CfrmTraffic_Fines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 282);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CfrmTraffic_Fines";
            this.Text = "Traffic Fines";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtVehReg;
        private System.Windows.Forms.TextBox txtIDNum;
        private System.Windows.Forms.TextBox txtinitialsSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radOthers;
        private System.Windows.Forms.RadioButton radSpeeding;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
    }
}

