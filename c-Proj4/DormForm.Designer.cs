using System.ComponentModel;

namespace Project4
{
    partial class DormForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.dormGroup = new System.Windows.Forms.GroupBox();
            this.dormLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.lblOak = new System.Windows.Forms.Label();
            this.lblTrustee = new System.Windows.Forms.Label();
            this.lblWapello = new System.Windows.Forms.Label();
            this.lblAppanoose = new System.Windows.Forms.Label();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.lblMahaska = new System.Windows.Forms.Label();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.mealGroup = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblBasic = new System.Windows.Forms.Label();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.lblMedium = new System.Windows.Forms.Label();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.lblHigh = new System.Windows.Forms.Label();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dormGroup.SuspendLayout();
            this.dormLayout.SuspendLayout();
            this.mealGroup.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.Location = new System.Drawing.Point(20, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(8, 8);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.Location = new System.Drawing.Point(20, 26);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(8, 8);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.Location = new System.Drawing.Point(20, 49);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(8, 8);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // dormGroup
            // 
            this.dormGroup.Controls.Add(this.dormLayout);
            this.dormGroup.Location = new System.Drawing.Point(38, 174);
            this.dormGroup.Name = "dormGroup";
            this.dormGroup.Size = new System.Drawing.Size(143, 147);
            this.dormGroup.TabIndex = 3;
            this.dormGroup.TabStop = false;
            this.dormGroup.Text = "Dorm";
            // 
            // dormLayout
            // 
            this.dormLayout.Controls.Add(this.lblOak);
            this.dormLayout.Controls.Add(this.radioButton1);
            this.dormLayout.Controls.Add(this.lblTrustee);
            this.dormLayout.Controls.Add(this.radioButton2);
            this.dormLayout.Controls.Add(this.lblWapello);
            this.dormLayout.Controls.Add(this.radioButton3);
            this.dormLayout.Controls.Add(this.lblAppanoose);
            this.dormLayout.Controls.Add(this.radioButton4);
            this.dormLayout.Controls.Add(this.lblMahaska);
            this.dormLayout.Controls.Add(this.radioButton5);
            this.dormLayout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dormLayout.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.dormLayout.Location = new System.Drawing.Point(3, 25);
            this.dormLayout.Name = "dormLayout";
            this.dormLayout.Size = new System.Drawing.Size(137, 119);
            this.dormLayout.TabIndex = 0;
            // 
            // lblOak
            // 
            this.lblOak.Location = new System.Drawing.Point(34, 0);
            this.lblOak.Name = "lblOak";
            this.lblOak.Size = new System.Drawing.Size(100, 23);
            this.lblOak.TabIndex = 5;
            this.lblOak.Text = "Oak";
            // 
            // lblTrustee
            // 
            this.lblTrustee.Location = new System.Drawing.Point(34, 23);
            this.lblTrustee.Name = "lblTrustee";
            this.lblTrustee.Size = new System.Drawing.Size(100, 23);
            this.lblTrustee.TabIndex = 6;
            this.lblTrustee.Text = "Trustee";
            // 
            // lblWapello
            // 
            this.lblWapello.Location = new System.Drawing.Point(34, 46);
            this.lblWapello.Name = "lblWapello";
            this.lblWapello.Size = new System.Drawing.Size(100, 23);
            this.lblWapello.TabIndex = 7;
            this.lblWapello.Text = "Wapello";
            // 
            // lblAppanoose
            // 
            this.lblAppanoose.Location = new System.Drawing.Point(34, 69);
            this.lblAppanoose.Name = "lblAppanoose";
            this.lblAppanoose.Size = new System.Drawing.Size(100, 23);
            this.lblAppanoose.TabIndex = 8;
            this.lblAppanoose.Text = "Appanoose";
            // 
            // radioButton4
            // 
            this.radioButton4.Location = new System.Drawing.Point(20, 72);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(8, 8);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // lblMahaska
            // 
            this.lblMahaska.Location = new System.Drawing.Point(34, 92);
            this.lblMahaska.Name = "lblMahaska";
            this.lblMahaska.Size = new System.Drawing.Size(100, 23);
            this.lblMahaska.TabIndex = 9;
            this.lblMahaska.Text = "Mahaska";
            // 
            // radioButton5
            // 
            this.radioButton5.Location = new System.Drawing.Point(20, 95);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(8, 8);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "radioButton5";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // mealGroup
            // 
            this.mealGroup.Controls.Add(this.flowLayoutPanel1);
            this.mealGroup.Location = new System.Drawing.Point(215, 174);
            this.mealGroup.Name = "mealGroup";
            this.mealGroup.Size = new System.Drawing.Size(146, 96);
            this.mealGroup.TabIndex = 4;
            this.mealGroup.TabStop = false;
            this.mealGroup.Text = "Meal Plan";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblBasic);
            this.flowLayoutPanel1.Controls.Add(this.radioButton10);
            this.flowLayoutPanel1.Controls.Add(this.lblMedium);
            this.flowLayoutPanel1.Controls.Add(this.radioButton9);
            this.flowLayoutPanel1.Controls.Add(this.lblHigh);
            this.flowLayoutPanel1.Controls.Add(this.radioButton8);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 24);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(140, 69);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lblBasic
            // 
            this.lblBasic.Location = new System.Drawing.Point(37, 0);
            this.lblBasic.Name = "lblBasic";
            this.lblBasic.Size = new System.Drawing.Size(100, 23);
            this.lblBasic.TabIndex = 5;
            this.lblBasic.Text = "Basic";
            // 
            // radioButton10
            // 
            this.radioButton10.Location = new System.Drawing.Point(23, 3);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(8, 8);
            this.radioButton10.TabIndex = 0;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "radioButton10";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // lblMedium
            // 
            this.lblMedium.Location = new System.Drawing.Point(37, 23);
            this.lblMedium.Name = "lblMedium";
            this.lblMedium.Size = new System.Drawing.Size(100, 23);
            this.lblMedium.TabIndex = 6;
            this.lblMedium.Text = "Medium";
            // 
            // radioButton9
            // 
            this.radioButton9.Location = new System.Drawing.Point(23, 26);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(8, 8);
            this.radioButton9.TabIndex = 1;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "radioButton9";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // lblHigh
            // 
            this.lblHigh.Location = new System.Drawing.Point(37, 46);
            this.lblHigh.Name = "lblHigh";
            this.lblHigh.Size = new System.Drawing.Size(100, 23);
            this.lblHigh.TabIndex = 7;
            this.lblHigh.Text = "High";
            // 
            // radioButton8
            // 
            this.radioButton8.Location = new System.Drawing.Point(23, 49);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(8, 8);
            this.radioButton8.TabIndex = 2;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "radioButton8";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(404, 58);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(96, 24);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(404, 103);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(96, 24);
            this.btnMenu.TabIndex = 6;
            this.btnMenu.Text = "Main Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(168, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 23);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(168, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 23);
            this.textBox2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student ID:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(38, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 116);
            this.panel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(20, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student Name:";
            // 
            // studentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 376);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.mealGroup);
            this.Controls.Add(this.dormGroup);
            this.Name = "studentForm";
            this.Text = "Student Form";
            this.Load += new System.EventHandler(this.DormForm_Load);
            this.dormGroup.ResumeLayout(false);
            this.dormLayout.ResumeLayout(false);
            this.mealGroup.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Label lblTrustee;
        private System.Windows.Forms.Label lblWapello;
        private System.Windows.Forms.Label lblOak;
        private System.Windows.Forms.Label lblAppanoose;
        private System.Windows.Forms.Label lblMahaska;
        private System.Windows.Forms.FlowLayoutPanel dormLayout;
        private System.Windows.Forms.GroupBox dormGroup;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.Label lblBasic;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.Label lblMedium;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.Label lblHigh;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox mealGroup;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}