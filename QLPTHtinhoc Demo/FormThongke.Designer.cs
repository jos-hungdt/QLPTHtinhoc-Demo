namespace QLPTHtinhoc_Demo
{
    partial class FormThongke
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThongke));
            this.dtgvData = new System.Windows.Forms.DataGridView();
            this.btnclose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLop = new System.Windows.Forms.Button();
            this.btnGV = new System.Windows.Forms.Button();
            this.tbnTime = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbKhoi = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbGV = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.timeEnd = new System.Windows.Forms.DateTimePicker();
            this.timestart = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvData)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvData
            // 
            this.dtgvData.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvData.Location = new System.Drawing.Point(3, 80);
            this.dtgvData.Name = "dtgvData";
            this.dtgvData.Size = new System.Drawing.Size(1257, 677);
            this.dtgvData.TabIndex = 0;
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(1177, 12);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 27);
            this.btnclose.TabIndex = 1;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(175, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "TK theo khối";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLop
            // 
            this.btnLop.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLop.Location = new System.Drawing.Point(175, 3);
            this.btnLop.Name = "btnLop";
            this.btnLop.Size = new System.Drawing.Size(110, 27);
            this.btnLop.TabIndex = 3;
            this.btnLop.Text = "TK theo lớp";
            this.btnLop.UseVisualStyleBackColor = true;
            this.btnLop.Click += new System.EventHandler(this.btnLop_Click);
            // 
            // btnGV
            // 
            this.btnGV.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGV.Location = new System.Drawing.Point(174, 3);
            this.btnGV.Name = "btnGV";
            this.btnGV.Size = new System.Drawing.Size(112, 27);
            this.btnGV.TabIndex = 4;
            this.btnGV.Text = "TK theo GV";
            this.btnGV.UseVisualStyleBackColor = true;
            this.btnGV.Click += new System.EventHandler(this.btnGV_Click);
            // 
            // tbnTime
            // 
            this.tbnTime.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnTime.Location = new System.Drawing.Point(346, 20);
            this.tbnTime.Name = "tbnTime";
            this.tbnTime.Size = new System.Drawing.Size(112, 27);
            this.tbnTime.TabIndex = 5;
            this.tbnTime.Text = "TK theo Thời gian";
            this.tbnTime.UseVisualStyleBackColor = true;
            this.tbnTime.Click += new System.EventHandler(this.tbnTime_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbKhoi);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(3, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 33);
            this.panel1.TabIndex = 6;
            // 
            // cbKhoi
            // 
            this.cbKhoi.FormattingEnabled = true;
            this.cbKhoi.Location = new System.Drawing.Point(4, 7);
            this.cbKhoi.Name = "cbKhoi";
            this.cbKhoi.Size = new System.Drawing.Size(165, 21);
            this.cbKhoi.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbLop);
            this.panel2.Controls.Add(this.btnLop);
            this.panel2.Location = new System.Drawing.Point(295, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 33);
            this.panel2.TabIndex = 7;
            // 
            // cbLop
            // 
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(4, 7);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(165, 21);
            this.cbLop.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbGV);
            this.panel3.Controls.Add(this.btnGV);
            this.panel3.Location = new System.Drawing.Point(3, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(289, 33);
            this.panel3.TabIndex = 8;
            // 
            // cbGV
            // 
            this.cbGV.FormattingEnabled = true;
            this.cbGV.Location = new System.Drawing.Point(4, 7);
            this.cbGV.Name = "cbGV";
            this.cbGV.Size = new System.Drawing.Size(165, 21);
            this.cbGV.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.comboBox4);
            this.panel4.Controls.Add(this.button5);
            this.panel4.Location = new System.Drawing.Point(295, 45);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(289, 33);
            this.panel4.TabIndex = 9;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(4, 7);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(165, 21);
            this.comboBox4.TabIndex = 3;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(175, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(111, 27);
            this.button5.TabIndex = 2;
            this.button5.Text = "TK theo Môn";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.timeEnd);
            this.panel5.Controls.Add(this.timestart);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.tbnTime);
            this.panel5.Location = new System.Drawing.Point(590, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(461, 72);
            this.panel5.TabIndex = 10;
            // 
            // timeEnd
            // 
            this.timeEnd.Location = new System.Drawing.Point(45, 43);
            this.timeEnd.Name = "timeEnd";
            this.timeEnd.Size = new System.Drawing.Size(295, 20);
            this.timeEnd.TabIndex = 3;
            // 
            // timestart
            // 
            this.timestart.Location = new System.Drawing.Point(45, 6);
            this.timestart.Name = "timestart";
            this.timestart.Size = new System.Drawing.Size(295, 20);
            this.timestart.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đến :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ :";
            // 
            // FormThongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.dtgvData);
            this.Name = "FormThongke";
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.FormThongke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvData;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLop;
        private System.Windows.Forms.Button btnGV;
        private System.Windows.Forms.Button tbnTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbKhoi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbGV;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DateTimePicker timeEnd;
        private System.Windows.Forms.DateTimePicker timestart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}