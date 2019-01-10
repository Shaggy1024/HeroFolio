namespace HeroFolio
{
    partial class AeroWizard1
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
            this.wizardControl1 = new AeroWizard.WizardControl();
            this.characterDetails = new AeroWizard.WizardPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.characterRace = new AeroWizard.WizardPage();
            this.characterClass = new AeroWizard.WizardPage();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).BeginInit();
            this.characterDetails.SuspendLayout();
            this.characterRace.SuspendLayout();
            this.SuspendLayout();
            // 
            // wizardControl1
            // 
            this.wizardControl1.BackColor = System.Drawing.Color.White;
            this.wizardControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wizardControl1.Location = new System.Drawing.Point(0, 0);
            this.wizardControl1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.wizardControl1.Name = "wizardControl1";
            this.wizardControl1.Pages.Add(this.characterDetails);
            this.wizardControl1.Pages.Add(this.characterRace);
            this.wizardControl1.Pages.Add(this.characterClass);
            this.wizardControl1.Size = new System.Drawing.Size(1601, 962);
            this.wizardControl1.TabIndex = 0;
            this.wizardControl1.Title = "New Character Wizard";
            // 
            // characterDetails
            // 
            this.characterDetails.Controls.Add(this.comboBox1);
            this.characterDetails.Controls.Add(this.label3);
            this.characterDetails.Controls.Add(this.textBox2);
            this.characterDetails.Controls.Add(this.label2);
            this.characterDetails.Controls.Add(this.textBox1);
            this.characterDetails.Controls.Add(this.label1);
            this.characterDetails.Name = "characterDetails";
            this.characterDetails.Size = new System.Drawing.Size(1554, 671);
            this.characterDetails.TabIndex = 0;
            this.characterDetails.Text = "Character Details";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.comboBox1.Location = new System.Drawing.Point(317, 190);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 56);
            this.comboBox1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 48);
            this.label3.TabIndex = 4;
            this.label3.Text = "Character Level";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(317, 113);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(248, 55);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 48);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gender";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(317, 34);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(248, 55);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Character Name";
            // 
            // characterRace
            // 
            this.characterRace.Controls.Add(this.comboBox3);
            this.characterRace.Controls.Add(this.label4);
            this.characterRace.Controls.Add(this.comboBox2);
            this.characterRace.Name = "characterRace";
            this.characterRace.Size = new System.Drawing.Size(1554, 671);
            this.characterRace.TabIndex = 1;
            this.characterRace.Text = "Character Race";
            // 
            // characterClass
            // 
            this.characterClass.Name = "characterClass";
            this.characterClass.Size = new System.Drawing.Size(1554, 671);
            this.characterClass.TabIndex = 2;
            this.characterClass.Text = "Character Class";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Core Races",
            "Featured Races",
            "Uncommon Races"});
            this.comboBox2.Location = new System.Drawing.Point(195, 65);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(296, 56);
            this.comboBox2.TabIndex = 0;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 48);
            this.label4.TabIndex = 1;
            this.label4.Text = "Race";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(497, 65);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(311, 56);
            this.comboBox3.TabIndex = 2;
            // 
            // AeroWizard1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1601, 962);
            this.Controls.Add(this.wizardControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "AeroWizard1";
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).EndInit();
            this.characterDetails.ResumeLayout(false);
            this.characterDetails.PerformLayout();
            this.characterRace.ResumeLayout(false);
            this.characterRace.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AeroWizard.WizardControl wizardControl1;
        private AeroWizard.WizardPage characterDetails;
        private AeroWizard.WizardPage characterRace;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private AeroWizard.WizardPage characterClass;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}