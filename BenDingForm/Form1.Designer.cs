﻿namespace BenDingForm
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.签到测试 = new System.Windows.Forms.Button();
            this.btn_read_Card = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.btn_icd10 = new System.Windows.Forms.Button();
            this.btn_datacode = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnQueryCognizance = new System.Windows.Forms.Button();
            this.btnQuerySpecialDiseases = new System.Windows.Forms.Button();
            this.btnCancelUpload = new System.Windows.Forms.Button();
            this.btnCognizance = new System.Windows.Forms.Button();
            this.btnSettlement = new System.Windows.Forms.Button();
            this.btn_model = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Register = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(435, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "挂号";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(532, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "明细上传";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(613, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "结算";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(703, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "结算回退";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(273, 19);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "医院信息上传";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.签到测试);
            this.panel1.Controls.Add(this.btn_read_Card);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 73);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(31, 48);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(585, 21);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "C:\\Program Files\\Microsoft\\本鼎医保插件\\xmlData";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(354, 19);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 6;
            this.button8.Text = "取消签到";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // 签到测试
            // 
            this.签到测试.Location = new System.Drawing.Point(106, 19);
            this.签到测试.Name = "签到测试";
            this.签到测试.Size = new System.Drawing.Size(75, 23);
            this.签到测试.TabIndex = 6;
            this.签到测试.Text = "签到";
            this.签到测试.UseVisualStyleBackColor = true;
            this.签到测试.Click += new System.EventHandler(this.button7_Click);
            // 
            // btn_read_Card
            // 
            this.btn_read_Card.Location = new System.Drawing.Point(187, 19);
            this.btn_read_Card.Name = "btn_read_Card";
            this.btn_read_Card.Size = new System.Drawing.Size(75, 23);
            this.btn_read_Card.TabIndex = 5;
            this.btn_read_Card.Text = "读卡";
            this.btn_read_Card.UseVisualStyleBackColor = true;
            this.btn_read_Card.Click += new System.EventHandler(this.btn_read_Card_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(14, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "初始化";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(490, 91);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 6;
            this.button9.Text = "服务项目目录获取";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(12, 91);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(131, 23);
            this.button11.TabIndex = 7;
            this.button11.Text = "查询不确定的交易";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(175, 91);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 8;
            this.button12.Text = "取消交易";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(256, 91);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 9;
            this.button13.Text = "确认交易";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(337, 91);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(147, 23);
            this.button10.TabIndex = 10;
            this.button10.Text = "医院信息获取";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click_1);
            // 
            // btn_icd10
            // 
            this.btn_icd10.Location = new System.Drawing.Point(584, 91);
            this.btn_icd10.Name = "btn_icd10";
            this.btn_icd10.Size = new System.Drawing.Size(75, 23);
            this.btn_icd10.TabIndex = 11;
            this.btn_icd10.Text = "icd10";
            this.btn_icd10.UseVisualStyleBackColor = true;
            this.btn_icd10.Click += new System.EventHandler(this.btn_icd10_Click);
            // 
            // btn_datacode
            // 
            this.btn_datacode.Location = new System.Drawing.Point(665, 91);
            this.btn_datacode.Name = "btn_datacode";
            this.btn_datacode.Size = new System.Drawing.Size(75, 23);
            this.btn_datacode.TabIndex = 12;
            this.btn_datacode.Text = "获取码表";
            this.btn_datacode.UseVisualStyleBackColor = true;
            this.btn_datacode.Click += new System.EventHandler(this.btn_datacode_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button17);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.btnQueryCognizance);
            this.groupBox1.Controls.Add(this.btnQuerySpecialDiseases);
            this.groupBox1.Controls.Add(this.btnCancelUpload);
            this.groupBox1.Controls.Add(this.btnCognizance);
            this.groupBox1.Controls.Add(this.btnSettlement);
            this.groupBox1.Controls.Add(this.btn_model);
            this.groupBox1.Controls.Add(this.btn_Cancel);
            this.groupBox1.Controls.Add(this.btn_Register);
            this.groupBox1.Location = new System.Drawing.Point(12, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(778, 305);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "住院";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 78);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(766, 167);
            this.textBox3.TabIndex = 26;
            // 
            // btnQueryCognizance
            // 
            this.btnQueryCognizance.Location = new System.Drawing.Point(509, 20);
            this.btnQueryCognizance.Name = "btnQueryCognizance";
            this.btnQueryCognizance.Size = new System.Drawing.Size(75, 23);
            this.btnQueryCognizance.TabIndex = 25;
            this.btnQueryCognizance.Text = "认定查询";
            this.btnQueryCognizance.UseVisualStyleBackColor = true;
            this.btnQueryCognizance.Click += new System.EventHandler(this.btnQueryCognizance_Click);
            // 
            // btnQuerySpecialDiseases
            // 
            this.btnQuerySpecialDiseases.Location = new System.Drawing.Point(118, 49);
            this.btnQuerySpecialDiseases.Name = "btnQuerySpecialDiseases";
            this.btnQuerySpecialDiseases.Size = new System.Drawing.Size(75, 23);
            this.btnQuerySpecialDiseases.TabIndex = 24;
            this.btnQuerySpecialDiseases.Text = "门特申请查询";
            this.btnQuerySpecialDiseases.UseVisualStyleBackColor = true;
            this.btnQuerySpecialDiseases.Click += new System.EventHandler(this.btnQuerySpecialDiseases_Click);
            // 
            // btnCancelUpload
            // 
            this.btnCancelUpload.Location = new System.Drawing.Point(6, 49);
            this.btnCancelUpload.Name = "btnCancelUpload";
            this.btnCancelUpload.Size = new System.Drawing.Size(106, 23);
            this.btnCancelUpload.TabIndex = 23;
            this.btnCancelUpload.Text = "取消明细上传";
            this.btnCancelUpload.UseVisualStyleBackColor = true;
            this.btnCancelUpload.Click += new System.EventHandler(this.btnCancelUpload_Click);
            // 
            // btnCognizance
            // 
            this.btnCognizance.Location = new System.Drawing.Point(417, 20);
            this.btnCognizance.Name = "btnCognizance";
            this.btnCognizance.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCognizance.Size = new System.Drawing.Size(75, 23);
            this.btnCognizance.TabIndex = 22;
            this.btnCognizance.Text = "特殊疾病认定";
            this.btnCognizance.UseVisualStyleBackColor = true;
            this.btnCognizance.Click += new System.EventHandler(this.btnCognizance_Click);
            // 
            // btnSettlement
            // 
            this.btnSettlement.Location = new System.Drawing.Point(308, 20);
            this.btnSettlement.Name = "btnSettlement";
            this.btnSettlement.Size = new System.Drawing.Size(75, 23);
            this.btnSettlement.TabIndex = 21;
            this.btnSettlement.Text = "住院结算";
            this.btnSettlement.UseVisualStyleBackColor = true;
            this.btnSettlement.Click += new System.EventHandler(this.btnSettlement_Click);
            // 
            // btn_model
            // 
            this.btn_model.Location = new System.Drawing.Point(106, 20);
            this.btn_model.Name = "btn_model";
            this.btn_model.Size = new System.Drawing.Size(75, 23);
            this.btn_model.TabIndex = 20;
            this.btn_model.Text = "修改入院登记";
            this.btn_model.UseVisualStyleBackColor = true;
            this.btn_model.Click += new System.EventHandler(this.btn_model_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(203, 20);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "取消入院登记";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Register
            // 
            this.btn_Register.Location = new System.Drawing.Point(14, 20);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(75, 23);
            this.btn_Register.TabIndex = 0;
            this.btn_Register.Text = "入院登记";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(203, 49);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(75, 23);
            this.button17.TabIndex = 20;
            this.button17.Text = "sqllite";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 456);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_datacode);
            this.Controls.Add(this.btn_icd10);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btn_read_Card;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button 签到测试;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btn_icd10;
        private System.Windows.Forms.Button btn_datacode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_model;
        private System.Windows.Forms.Button btnSettlement;
        private System.Windows.Forms.Button btnCognizance;
        private System.Windows.Forms.Button btnCancelUpload;
        private System.Windows.Forms.Button btnQuerySpecialDiseases;
        private System.Windows.Forms.Button btnQueryCognizance;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button17;
    }
}

