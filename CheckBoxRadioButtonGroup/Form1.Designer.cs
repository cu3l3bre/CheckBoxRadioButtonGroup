namespace CheckBoxRadioButtonGroup
{
    partial class main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonClose = new System.Windows.Forms.Button();
            this.checkBoxFett = new System.Windows.Forms.CheckBox();
            this.checkBoxKursiv = new System.Windows.Forms.CheckBox();
            this.checkBoxUnterStrichen = new System.Windows.Forms.CheckBox();
            this.checkBoxDurchgestrichen = new System.Windows.Forms.CheckBox();
            this.groupBoxHintergrund = new System.Windows.Forms.GroupBox();
            this.radioButtonHhellgruen = new System.Windows.Forms.RadioButton();
            this.radioButtonHhellblau = new System.Windows.Forms.RadioButton();
            this.radioButtonHrosa = new System.Windows.Forms.RadioButton();
            this.radioButtonHgelb = new System.Windows.Forms.RadioButton();
            this.radioButtonHanthrazit = new System.Windows.Forms.RadioButton();
            this.groupBoxSchrift = new System.Windows.Forms.GroupBox();
            this.radioButtonSweiss = new System.Windows.Forms.RadioButton();
            this.radioButtonSviolett = new System.Windows.Forms.RadioButton();
            this.radioButtonSgelb = new System.Windows.Forms.RadioButton();
            this.radioButtonSrot = new System.Windows.Forms.RadioButton();
            this.radioButtonSblau = new System.Windows.Forms.RadioButton();
            this.groupBoxHintergrund.SuspendLayout();
            this.groupBoxSchrift.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(329, 123);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(87, 36);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // checkBoxFett
            // 
            this.checkBoxFett.AutoSize = true;
            this.checkBoxFett.Location = new System.Drawing.Point(315, 31);
            this.checkBoxFett.Name = "checkBoxFett";
            this.checkBoxFett.Size = new System.Drawing.Size(41, 17);
            this.checkBoxFett.TabIndex = 1;
            this.checkBoxFett.Text = "fett";
            this.checkBoxFett.UseVisualStyleBackColor = true;
            this.checkBoxFett.CheckedChanged += new System.EventHandler(this.setFont);
            // 
            // checkBoxKursiv
            // 
            this.checkBoxKursiv.AutoSize = true;
            this.checkBoxKursiv.Location = new System.Drawing.Point(315, 54);
            this.checkBoxKursiv.Name = "checkBoxKursiv";
            this.checkBoxKursiv.Size = new System.Drawing.Size(54, 17);
            this.checkBoxKursiv.TabIndex = 2;
            this.checkBoxKursiv.Text = "kursiv";
            this.checkBoxKursiv.UseVisualStyleBackColor = true;
            this.checkBoxKursiv.CheckedChanged += new System.EventHandler(this.setFont);
            // 
            // checkBoxUnterStrichen
            // 
            this.checkBoxUnterStrichen.AutoSize = true;
            this.checkBoxUnterStrichen.Location = new System.Drawing.Point(315, 77);
            this.checkBoxUnterStrichen.Name = "checkBoxUnterStrichen";
            this.checkBoxUnterStrichen.Size = new System.Drawing.Size(87, 17);
            this.checkBoxUnterStrichen.TabIndex = 3;
            this.checkBoxUnterStrichen.Text = "unterstrichen";
            this.checkBoxUnterStrichen.UseVisualStyleBackColor = true;
            this.checkBoxUnterStrichen.CheckedChanged += new System.EventHandler(this.setFont);
            // 
            // checkBoxDurchgestrichen
            // 
            this.checkBoxDurchgestrichen.AutoSize = true;
            this.checkBoxDurchgestrichen.Location = new System.Drawing.Point(315, 100);
            this.checkBoxDurchgestrichen.Name = "checkBoxDurchgestrichen";
            this.checkBoxDurchgestrichen.Size = new System.Drawing.Size(102, 17);
            this.checkBoxDurchgestrichen.TabIndex = 4;
            this.checkBoxDurchgestrichen.Text = "durchgestrichen";
            this.checkBoxDurchgestrichen.UseVisualStyleBackColor = true;
            this.checkBoxDurchgestrichen.CheckedChanged += new System.EventHandler(this.setFont);
            // 
            // groupBoxHintergrund
            // 
            this.groupBoxHintergrund.Controls.Add(this.radioButtonHanthrazit);
            this.groupBoxHintergrund.Controls.Add(this.radioButtonHgelb);
            this.groupBoxHintergrund.Controls.Add(this.radioButtonHrosa);
            this.groupBoxHintergrund.Controls.Add(this.radioButtonHhellblau);
            this.groupBoxHintergrund.Controls.Add(this.radioButtonHhellgruen);
            this.groupBoxHintergrund.Location = new System.Drawing.Point(12, 12);
            this.groupBoxHintergrund.Name = "groupBoxHintergrund";
            this.groupBoxHintergrund.Size = new System.Drawing.Size(104, 141);
            this.groupBoxHintergrund.TabIndex = 5;
            this.groupBoxHintergrund.TabStop = false;
            this.groupBoxHintergrund.Text = "Hintergrundfarbe";
            // 
            // radioButtonHhellgruen
            // 
            this.radioButtonHhellgruen.AutoSize = true;
            this.radioButtonHhellgruen.Location = new System.Drawing.Point(6, 19);
            this.radioButtonHhellgruen.Name = "radioButtonHhellgruen";
            this.radioButtonHhellgruen.Size = new System.Drawing.Size(68, 17);
            this.radioButtonHhellgruen.TabIndex = 0;
            this.radioButtonHhellgruen.Text = "hellgruen";
            this.radioButtonHhellgruen.UseVisualStyleBackColor = true;
            this.radioButtonHhellgruen.CheckedChanged += new System.EventHandler(this.RadioButtonHhellgruen_CheckedChanged);
            // 
            // radioButtonHhellblau
            // 
            this.radioButtonHhellblau.AutoSize = true;
            this.radioButtonHhellblau.Checked = true;
            this.radioButtonHhellblau.Location = new System.Drawing.Point(6, 42);
            this.radioButtonHhellblau.Name = "radioButtonHhellblau";
            this.radioButtonHhellblau.Size = new System.Drawing.Size(61, 17);
            this.radioButtonHhellblau.TabIndex = 1;
            this.radioButtonHhellblau.TabStop = true;
            this.radioButtonHhellblau.Text = "hellblau";
            this.radioButtonHhellblau.UseVisualStyleBackColor = true;
            this.radioButtonHhellblau.CheckedChanged += new System.EventHandler(this.RadioButtonHhellblau_CheckedChanged);
            // 
            // radioButtonHrosa
            // 
            this.radioButtonHrosa.AutoSize = true;
            this.radioButtonHrosa.Location = new System.Drawing.Point(6, 65);
            this.radioButtonHrosa.Name = "radioButtonHrosa";
            this.radioButtonHrosa.Size = new System.Drawing.Size(45, 17);
            this.radioButtonHrosa.TabIndex = 2;
            this.radioButtonHrosa.Text = "rosa";
            this.radioButtonHrosa.UseVisualStyleBackColor = true;
            this.radioButtonHrosa.CheckedChanged += new System.EventHandler(this.RadioButtonHrosa_CheckedChanged);
            // 
            // radioButtonHgelb
            // 
            this.radioButtonHgelb.AutoSize = true;
            this.radioButtonHgelb.Location = new System.Drawing.Point(6, 88);
            this.radioButtonHgelb.Name = "radioButtonHgelb";
            this.radioButtonHgelb.Size = new System.Drawing.Size(45, 17);
            this.radioButtonHgelb.TabIndex = 3;
            this.radioButtonHgelb.Text = "gelb";
            this.radioButtonHgelb.UseVisualStyleBackColor = true;
            this.radioButtonHgelb.CheckedChanged += new System.EventHandler(this.RadioButtonHgelb_CheckedChanged);
            // 
            // radioButtonHanthrazit
            // 
            this.radioButtonHanthrazit.AutoSize = true;
            this.radioButtonHanthrazit.Location = new System.Drawing.Point(6, 111);
            this.radioButtonHanthrazit.Name = "radioButtonHanthrazit";
            this.radioButtonHanthrazit.Size = new System.Drawing.Size(65, 17);
            this.radioButtonHanthrazit.TabIndex = 4;
            this.radioButtonHanthrazit.Text = "anthrazit";
            this.radioButtonHanthrazit.UseVisualStyleBackColor = true;
            this.radioButtonHanthrazit.CheckedChanged += new System.EventHandler(this.RadioButtonHanthrazit_CheckedChanged);
            // 
            // groupBoxSchrift
            // 
            this.groupBoxSchrift.Controls.Add(this.radioButtonSweiss);
            this.groupBoxSchrift.Controls.Add(this.radioButtonSviolett);
            this.groupBoxSchrift.Controls.Add(this.radioButtonSgelb);
            this.groupBoxSchrift.Controls.Add(this.radioButtonSrot);
            this.groupBoxSchrift.Controls.Add(this.radioButtonSblau);
            this.groupBoxSchrift.Location = new System.Drawing.Point(183, 12);
            this.groupBoxSchrift.Name = "groupBoxSchrift";
            this.groupBoxSchrift.Size = new System.Drawing.Size(104, 141);
            this.groupBoxSchrift.TabIndex = 6;
            this.groupBoxSchrift.TabStop = false;
            this.groupBoxSchrift.Text = "Schriftfarbe";
            // 
            // radioButtonSweiss
            // 
            this.radioButtonSweiss.AutoSize = true;
            this.radioButtonSweiss.Checked = true;
            this.radioButtonSweiss.Location = new System.Drawing.Point(6, 111);
            this.radioButtonSweiss.Name = "radioButtonSweiss";
            this.radioButtonSweiss.Size = new System.Drawing.Size(51, 17);
            this.radioButtonSweiss.TabIndex = 4;
            this.radioButtonSweiss.TabStop = true;
            this.radioButtonSweiss.Text = "weiss";
            this.radioButtonSweiss.UseVisualStyleBackColor = true;
            this.radioButtonSweiss.CheckedChanged += new System.EventHandler(this.RadioButtonSweiss_CheckedChanged);
            // 
            // radioButtonSviolett
            // 
            this.radioButtonSviolett.AutoSize = true;
            this.radioButtonSviolett.Location = new System.Drawing.Point(6, 88);
            this.radioButtonSviolett.Name = "radioButtonSviolett";
            this.radioButtonSviolett.Size = new System.Drawing.Size(53, 17);
            this.radioButtonSviolett.TabIndex = 3;
            this.radioButtonSviolett.Text = "violett";
            this.radioButtonSviolett.UseVisualStyleBackColor = true;
            this.radioButtonSviolett.CheckedChanged += new System.EventHandler(this.RadioButtonSviolett_CheckedChanged);
            // 
            // radioButtonSgelb
            // 
            this.radioButtonSgelb.AutoSize = true;
            this.radioButtonSgelb.Location = new System.Drawing.Point(6, 65);
            this.radioButtonSgelb.Name = "radioButtonSgelb";
            this.radioButtonSgelb.Size = new System.Drawing.Size(45, 17);
            this.radioButtonSgelb.TabIndex = 2;
            this.radioButtonSgelb.Text = "gelb";
            this.radioButtonSgelb.UseVisualStyleBackColor = true;
            this.radioButtonSgelb.CheckedChanged += new System.EventHandler(this.RadioButtonSgelb_CheckedChanged);
            // 
            // radioButtonSrot
            // 
            this.radioButtonSrot.AutoSize = true;
            this.radioButtonSrot.Location = new System.Drawing.Point(6, 42);
            this.radioButtonSrot.Name = "radioButtonSrot";
            this.radioButtonSrot.Size = new System.Drawing.Size(37, 17);
            this.radioButtonSrot.TabIndex = 1;
            this.radioButtonSrot.Text = "rot";
            this.radioButtonSrot.UseVisualStyleBackColor = true;
            this.radioButtonSrot.CheckedChanged += new System.EventHandler(this.RadioButtonSRot_CheckedChanged);
            // 
            // radioButtonSblau
            // 
            this.radioButtonSblau.AutoSize = true;
            this.radioButtonSblau.Location = new System.Drawing.Point(6, 19);
            this.radioButtonSblau.Name = "radioButtonSblau";
            this.radioButtonSblau.Size = new System.Drawing.Size(45, 17);
            this.radioButtonSblau.TabIndex = 0;
            this.radioButtonSblau.Text = "blau";
            this.radioButtonSblau.UseVisualStyleBackColor = true;
            this.radioButtonSblau.CheckedChanged += new System.EventHandler(this.RadioButtonSBlau_CheckedChanged);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 168);
            this.Controls.Add(this.groupBoxSchrift);
            this.Controls.Add(this.groupBoxHintergrund);
            this.Controls.Add(this.checkBoxDurchgestrichen);
            this.Controls.Add(this.checkBoxUnterStrichen);
            this.Controls.Add(this.checkBoxKursiv);
            this.Controls.Add(this.checkBoxFett);
            this.Controls.Add(this.buttonClose);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckBox, RadioButton und GoupBox";
            this.groupBoxHintergrund.ResumeLayout(false);
            this.groupBoxHintergrund.PerformLayout();
            this.groupBoxSchrift.ResumeLayout(false);
            this.groupBoxSchrift.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.CheckBox checkBoxFett;
        private System.Windows.Forms.CheckBox checkBoxKursiv;
        private System.Windows.Forms.CheckBox checkBoxUnterStrichen;
        private System.Windows.Forms.CheckBox checkBoxDurchgestrichen;
        private System.Windows.Forms.GroupBox groupBoxHintergrund;
        private System.Windows.Forms.RadioButton radioButtonHanthrazit;
        private System.Windows.Forms.RadioButton radioButtonHgelb;
        private System.Windows.Forms.RadioButton radioButtonHrosa;
        private System.Windows.Forms.RadioButton radioButtonHhellblau;
        private System.Windows.Forms.RadioButton radioButtonHhellgruen;
        private System.Windows.Forms.GroupBox groupBoxSchrift;
        private System.Windows.Forms.RadioButton radioButtonSweiss;
        private System.Windows.Forms.RadioButton radioButtonSviolett;
        private System.Windows.Forms.RadioButton radioButtonSgelb;
        private System.Windows.Forms.RadioButton radioButtonSrot;
        private System.Windows.Forms.RadioButton radioButtonSblau;
    }
}

