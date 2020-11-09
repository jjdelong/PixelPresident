using System.Drawing;
using System.Windows.Forms;

namespace Actions
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.progressBar10 = new System.Windows.Forms.ProgressBar();
            this.progressBar9 = new System.Windows.Forms.ProgressBar();
            this.Independentslabel = new System.Windows.Forms.Label();
            this.progressBar8 = new System.Windows.Forms.ProgressBar();
            this.progressBar7 = new System.Windows.Forms.ProgressBar();
            this.progressBar6 = new System.Windows.Forms.ProgressBar();
            this.Libertarian = new System.Windows.Forms.Label();
            this.GreenPartylabel = new System.Windows.Forms.Label();
            this.Republicianslabel = new System.Windows.Forms.Label();
            this.Democratslabel = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.TimeMangementlabel = new System.Windows.Forms.Label();
            this.Economicslabel = new System.Windows.Forms.Label();
            this.ForiegnPolicylabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PublicSpeakinglabel = new System.Windows.Forms.Label();
            this.ForeignRelationslabel = new System.Windows.Forms.TabPage();
            this.FederalFundslabel = new System.Windows.Forms.Label();
            this.EmptyActionsAllowed = new System.Windows.Forms.Label();
            this.ActionsLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ManageRelationslabel = new System.Windows.Forms.Label();
            this.PolicyPolicylabel = new System.Windows.Forms.Label();
            this.Speechlabel = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.EmptyRace = new System.Windows.Forms.Label();
            this.EmptyGender = new System.Windows.Forms.Label();
            this.EmptyAge = new System.Windows.Forms.Label();
            this.EmptyName = new System.Windows.Forms.Label();
            this.Racelabel = new System.Windows.Forms.Label();
            this.Genderlabel = new System.Windows.Forms.Label();
            this.Agelabel = new System.Windows.Forms.Label();
            this.Namelabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.ForeignRelationslabel.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.ForeignRelationslabel);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Font = new System.Drawing.Font("Constantia", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.ItemSize = new System.Drawing.Size(150, 60);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 4;
            this.tabControl1.Size = new System.Drawing.Size(799, 454);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 64);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(791, 386);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Events";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.progressBar10);
            this.tabPage2.Controls.Add(this.progressBar9);
            this.tabPage2.Controls.Add(this.Independentslabel);
            this.tabPage2.Controls.Add(this.progressBar8);
            this.tabPage2.Controls.Add(this.progressBar7);
            this.tabPage2.Controls.Add(this.progressBar6);
            this.tabPage2.Controls.Add(this.Libertarian);
            this.tabPage2.Controls.Add(this.GreenPartylabel);
            this.tabPage2.Controls.Add(this.Republicianslabel);
            this.tabPage2.Controls.Add(this.Democratslabel);
            this.tabPage2.Location = new System.Drawing.Point(4, 64);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(791, 386);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Popularity";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // progressBar10
            // 
            this.progressBar10.Location = new System.Drawing.Point(280, 306);
            this.progressBar10.Name = "progressBar10";
            this.progressBar10.Size = new System.Drawing.Size(231, 38);
            this.progressBar10.TabIndex = 4;
            // 
            // progressBar9
            // 
            this.progressBar9.Location = new System.Drawing.Point(280, 100);
            this.progressBar9.Name = "progressBar9";
            this.progressBar9.Size = new System.Drawing.Size(231, 38);
            this.progressBar9.TabIndex = 4;
            // 
            // Independentslabel
            // 
            this.Independentslabel.AutoSize = true;
            this.Independentslabel.Location = new System.Drawing.Point(72, 297);
            this.Independentslabel.Name = "Independentslabel";
            this.Independentslabel.Size = new System.Drawing.Size(204, 38);
            this.Independentslabel.TabIndex = 3;
            this.Independentslabel.Text = "Independents";
            // 
            // progressBar8
            // 
            this.progressBar8.Location = new System.Drawing.Point(281, 235);
            this.progressBar8.Name = "progressBar8";
            this.progressBar8.Size = new System.Drawing.Size(231, 38);
            this.progressBar8.TabIndex = 4;
            // 
            // progressBar7
            // 
            this.progressBar7.Location = new System.Drawing.Point(280, 174);
            this.progressBar7.Name = "progressBar7";
            this.progressBar7.Size = new System.Drawing.Size(231, 38);
            this.progressBar7.TabIndex = 4;
            // 
            // progressBar6
            // 
            this.progressBar6.Location = new System.Drawing.Point(281, 31);
            this.progressBar6.Name = "progressBar6";
            this.progressBar6.Size = new System.Drawing.Size(231, 38);
            this.progressBar6.TabIndex = 4;
            // 
            // Libertarian
            // 
            this.Libertarian.AutoSize = true;
            this.Libertarian.Location = new System.Drawing.Point(85, 232);
            this.Libertarian.Name = "Libertarian";
            this.Libertarian.Size = new System.Drawing.Size(180, 38);
            this.Libertarian.TabIndex = 3;
            this.Libertarian.Text = "Libertarians";
            // 
            // GreenPartylabel
            // 
            this.GreenPartylabel.AutoSize = true;
            this.GreenPartylabel.Location = new System.Drawing.Point(85, 163);
            this.GreenPartylabel.Name = "GreenPartylabel";
            this.GreenPartylabel.Size = new System.Drawing.Size(178, 38);
            this.GreenPartylabel.TabIndex = 2;
            this.GreenPartylabel.Text = "Green Party";
            // 
            // Republicianslabel
            // 
            this.Republicianslabel.AutoSize = true;
            this.Republicianslabel.Location = new System.Drawing.Point(85, 100);
            this.Republicianslabel.Name = "Republicianslabel";
            this.Republicianslabel.Size = new System.Drawing.Size(191, 38);
            this.Republicianslabel.TabIndex = 1;
            this.Republicianslabel.Text = "Republicians";
            // 
            // Democratslabel
            // 
            this.Democratslabel.AutoSize = true;
            this.Democratslabel.Location = new System.Drawing.Point(102, 31);
            this.Democratslabel.Name = "Democratslabel";
            this.Democratslabel.Size = new System.Drawing.Size(163, 38);
            this.Democratslabel.TabIndex = 0;
            this.Democratslabel.Text = "Democrats";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.progressBar5);
            this.tabPage3.Controls.Add(this.progressBar4);
            this.tabPage3.Controls.Add(this.progressBar3);
            this.tabPage3.Controls.Add(this.progressBar2);
            this.tabPage3.Controls.Add(this.progressBar1);
            this.tabPage3.Controls.Add(this.TimeMangementlabel);
            this.tabPage3.Controls.Add(this.Economicslabel);
            this.tabPage3.Controls.Add(this.ForiegnPolicylabel);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.PublicSpeakinglabel);
            this.tabPage3.Location = new System.Drawing.Point(4, 64);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(791, 386);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Skills";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // progressBar5
            // 
            this.progressBar5.Location = new System.Drawing.Point(261, 279);
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(315, 38);
            this.progressBar5.TabIndex = 5;
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(261, 29);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(315, 38);
            this.progressBar4.TabIndex = 5;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(261, 220);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(315, 38);
            this.progressBar3.TabIndex = 5;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(261, 154);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(315, 38);
            this.progressBar2.TabIndex = 5;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(261, 96);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(315, 38);
            this.progressBar1.TabIndex = 5;
            // 
            // TimeMangementlabel
            // 
            this.TimeMangementlabel.AutoSize = true;
            this.TimeMangementlabel.Location = new System.Drawing.Point(8, 279);
            this.TimeMangementlabel.Name = "TimeMangementlabel";
            this.TimeMangementlabel.Size = new System.Drawing.Size(256, 38);
            this.TimeMangementlabel.TabIndex = 4;
            this.TimeMangementlabel.Text = "Time Mangement";
            // 
            // Economicslabel
            // 
            this.Economicslabel.AutoSize = true;
            this.Economicslabel.Location = new System.Drawing.Point(80, 220);
            this.Economicslabel.Name = "Economicslabel";
            this.Economicslabel.Size = new System.Drawing.Size(163, 38);
            this.Economicslabel.TabIndex = 3;
            this.Economicslabel.Text = "Economics";
            // 
            // ForiegnPolicylabel
            // 
            this.ForiegnPolicylabel.AutoSize = true;
            this.ForiegnPolicylabel.Location = new System.Drawing.Point(46, 154);
            this.ForiegnPolicylabel.Name = "ForiegnPolicylabel";
            this.ForiegnPolicylabel.Size = new System.Drawing.Size(209, 38);
            this.ForiegnPolicylabel.TabIndex = 2;
            this.ForiegnPolicylabel.Text = "Foriegn Policy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Policy Creation";
            // 
            // PublicSpeakinglabel
            // 
            this.PublicSpeakinglabel.AutoSize = true;
            this.PublicSpeakinglabel.Location = new System.Drawing.Point(23, 29);
            this.PublicSpeakinglabel.Name = "PublicSpeakinglabel";
            this.PublicSpeakinglabel.Size = new System.Drawing.Size(232, 38);
            this.PublicSpeakinglabel.TabIndex = 0;
            this.PublicSpeakinglabel.Text = "Public Speaking";
            // 
            // ForeignRelationslabel
            // 
            this.ForeignRelationslabel.Controls.Add(this.FederalFundslabel);
            this.ForeignRelationslabel.Controls.Add(this.EmptyActionsAllowed);
            this.ForeignRelationslabel.Controls.Add(this.ActionsLabel);
            this.ForeignRelationslabel.Controls.Add(this.label4);
            this.ForeignRelationslabel.Controls.Add(this.ManageRelationslabel);
            this.ForeignRelationslabel.Controls.Add(this.PolicyPolicylabel);
            this.ForeignRelationslabel.Controls.Add(this.Speechlabel);
            this.ForeignRelationslabel.Location = new System.Drawing.Point(4, 64);
            this.ForeignRelationslabel.Name = "ForeignRelationslabel";
            this.ForeignRelationslabel.Padding = new System.Windows.Forms.Padding(3);
            this.ForeignRelationslabel.Size = new System.Drawing.Size(791, 386);
            this.ForeignRelationslabel.TabIndex = 3;
            this.ForeignRelationslabel.Text = "Actions";
            this.ForeignRelationslabel.UseVisualStyleBackColor = true;
            // 
            // FederalFundslabel
            // 
            this.FederalFundslabel.AutoSize = true;
            this.FederalFundslabel.Location = new System.Drawing.Point(249, 302);
            this.FederalFundslabel.Name = "FederalFundslabel";
            this.FederalFundslabel.Size = new System.Drawing.Size(321, 38);
            this.FederalFundslabel.TabIndex = 6;
            this.FederalFundslabel.Text = "Manage Federal Funds";
            // 
            // EmptyActionsAllowed
            // 
            this.EmptyActionsAllowed.AutoSize = true;
            this.EmptyActionsAllowed.Location = new System.Drawing.Point(295, 16);
            this.EmptyActionsAllowed.Name = "EmptyActionsAllowed";
            this.EmptyActionsAllowed.Size = new System.Drawing.Size(145, 38);
            this.EmptyActionsAllowed.TabIndex = 5;
            this.EmptyActionsAllowed.Text = "EmptyInt";
            // 
            // ActionsLabel
            // 
            this.ActionsLabel.AutoSize = true;
            this.ActionsLabel.Location = new System.Drawing.Point(44, 16);
            this.ActionsLabel.Name = "ActionsLabel";
            this.ActionsLabel.Size = new System.Drawing.Size(245, 38);
            this.ActionsLabel.TabIndex = 4;
            this.ActionsLabel.Text = "Actions Allowed:";
            this.ActionsLabel.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 38);
            this.label4.TabIndex = 3;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ManageRelationslabel
            // 
            this.ManageRelationslabel.AutoSize = true;
            this.ManageRelationslabel.Location = new System.Drawing.Point(249, 222);
            this.ManageRelationslabel.Name = "ManageRelationslabel";
            this.ManageRelationslabel.Size = new System.Drawing.Size(368, 38);
            this.ManageRelationslabel.TabIndex = 2;
            this.ManageRelationslabel.Text = "Manage Foreign Relations";
            // 
            // PolicyPolicylabel
            // 
            this.PolicyPolicylabel.AutoSize = true;
            this.PolicyPolicylabel.Location = new System.Drawing.Point(249, 154);
            this.PolicyPolicylabel.Name = "PolicyPolicylabel";
            this.PolicyPolicylabel.Size = new System.Drawing.Size(282, 38);
            this.PolicyPolicylabel.TabIndex = 1;
            this.PolicyPolicylabel.Text = "Create a New Policy";
            // 
            // Speechlabel
            // 
            this.Speechlabel.AutoSize = true;
            this.Speechlabel.Location = new System.Drawing.Point(249, 85);
            this.Speechlabel.Name = "Speechlabel";
            this.Speechlabel.Size = new System.Drawing.Size(200, 38);
            this.Speechlabel.TabIndex = 0;
            this.Speechlabel.Text = "Give a Speech";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.EmptyRace);
            this.tabPage5.Controls.Add(this.EmptyGender);
            this.tabPage5.Controls.Add(this.EmptyAge);
            this.tabPage5.Controls.Add(this.EmptyName);
            this.tabPage5.Controls.Add(this.Racelabel);
            this.tabPage5.Controls.Add(this.Genderlabel);
            this.tabPage5.Controls.Add(this.Agelabel);
            this.tabPage5.Controls.Add(this.Namelabel);
            this.tabPage5.Location = new System.Drawing.Point(4, 64);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(791, 386);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Bio";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // EmptyRace
            // 
            this.EmptyRace.AutoSize = true;
            this.EmptyRace.Location = new System.Drawing.Point(432, 216);
            this.EmptyRace.Name = "EmptyRace";
            this.EmptyRace.Size = new System.Drawing.Size(168, 38);
            this.EmptyRace.TabIndex = 7;
            this.EmptyRace.Text = "EmptyRace";
            // 
            // EmptyGender
            // 
            this.EmptyGender.AutoSize = true;
            this.EmptyGender.Location = new System.Drawing.Point(450, 151);
            this.EmptyGender.Name = "EmptyGender";
            this.EmptyGender.Size = new System.Drawing.Size(205, 38);
            this.EmptyGender.TabIndex = 6;
            this.EmptyGender.Text = "EmptyGender";
            // 
            // EmptyAge
            // 
            this.EmptyAge.AutoSize = true;
            this.EmptyAge.Location = new System.Drawing.Point(400, 92);
            this.EmptyAge.Name = "EmptyAge";
            this.EmptyAge.Size = new System.Drawing.Size(156, 38);
            this.EmptyAge.TabIndex = 5;
            this.EmptyAge.Text = "EmptyAge";
            this.EmptyAge.Click += new System.EventHandler(this.label6_Click);
            // 
            // EmptyName
            // 
            this.EmptyName.AutoSize = true;
            this.EmptyName.Location = new System.Drawing.Point(432, 29);
            this.EmptyName.Name = "EmptyName";
            this.EmptyName.Size = new System.Drawing.Size(184, 38);
            this.EmptyName.TabIndex = 4;
            this.EmptyName.Text = "EmptyName";
            // 
            // Racelabel
            // 
            this.Racelabel.AutoSize = true;
            this.Racelabel.Location = new System.Drawing.Point(339, 216);
            this.Racelabel.Name = "Racelabel";
            this.Racelabel.Size = new System.Drawing.Size(88, 38);
            this.Racelabel.TabIndex = 3;
            this.Racelabel.Text = "Race:";
            // 
            // Genderlabel
            // 
            this.Genderlabel.AutoSize = true;
            this.Genderlabel.Location = new System.Drawing.Point(333, 151);
            this.Genderlabel.Name = "Genderlabel";
            this.Genderlabel.Size = new System.Drawing.Size(125, 38);
            this.Genderlabel.TabIndex = 2;
            this.Genderlabel.Text = "Gender:";
            // 
            // Agelabel
            // 
            this.Agelabel.AutoSize = true;
            this.Agelabel.Location = new System.Drawing.Point(333, 92);
            this.Agelabel.Name = "Agelabel";
            this.Agelabel.Size = new System.Drawing.Size(76, 38);
            this.Agelabel.TabIndex = 1;
            this.Agelabel.Text = "Age:";
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Location = new System.Drawing.Point(333, 29);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(104, 38);
            this.Namelabel.TabIndex = 0;
            this.Namelabel.Text = "Name:";
            this.Namelabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Pixel President";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ForeignRelationslabel.ResumeLayout(false);
            this.ForeignRelationslabel.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage ForeignRelationslabel;
        private System.Windows.Forms.TabPage tabPage5;
        private Label Namelabel;
        private Label EmptyRace;
        private Label EmptyGender;
        private Label EmptyAge;
        private Label EmptyName;
        private Label Racelabel;
        private Label Genderlabel;
        private Label Agelabel;
        private Label ActionsLabel;
        private Label label4;
        private Label ManageRelationslabel;
        private Label PolicyPolicylabel;
        private Label Speechlabel;
        private Label EmptyActionsAllowed;
        private ProgressBar progressBar8;
        private ProgressBar progressBar7;
        private ProgressBar progressBar6;
        private Label Libertarian;
        private Label GreenPartylabel;
        private Label Republicianslabel;
        private Label Democratslabel;
        private ProgressBar progressBar5;
        private ProgressBar progressBar4;
        private ProgressBar progressBar3;
        private ProgressBar progressBar2;
        private ProgressBar progressBar1;
        private Label TimeMangementlabel;
        private Label Economicslabel;
        private Label ForiegnPolicylabel;
        private Label label1;
        private Label PublicSpeakinglabel;
        private Label FederalFundslabel;
        private ProgressBar progressBar10;
        private ProgressBar progressBar9;
        private Label Independentslabel;
    }
}

