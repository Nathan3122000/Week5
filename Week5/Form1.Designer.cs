
namespace Week5
{
    partial class Form1
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxAktif = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkboxWarnaMerah = new System.Windows.Forms.CheckBox();
            this.checkBoxWarnaBiru = new System.Windows.Forms.CheckBox();
            this.labelDisplay = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(60, 21);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(227, 22);
            this.textBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(306, 20);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(78, 86);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(227, 212);
            this.listBox.TabIndex = 3;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Koleksi:";
            // 
            // checkBoxAktif
            // 
            this.checkBoxAktif.AutoSize = true;
            this.checkBoxAktif.Location = new System.Drawing.Point(396, 60);
            this.checkBoxAktif.Name = "checkBoxAktif";
            this.checkBoxAktif.Size = new System.Drawing.Size(57, 21);
            this.checkBoxAktif.TabIndex = 5;
            this.checkBoxAktif.Text = "Aktif";
            this.checkBoxAktif.UseVisualStyleBackColor = true;
            this.checkBoxAktif.CheckedChanged += new System.EventHandler(this.checkBoxAktif_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Setting:";
            // 
            // checkboxWarnaMerah
            // 
            this.checkboxWarnaMerah.AutoSize = true;
            this.checkboxWarnaMerah.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkboxWarnaMerah.Location = new System.Drawing.Point(337, 87);
            this.checkboxWarnaMerah.Name = "checkboxWarnaMerah";
            this.checkboxWarnaMerah.Size = new System.Drawing.Size(116, 21);
            this.checkboxWarnaMerah.TabIndex = 7;
            this.checkboxWarnaMerah.Text = "Warna Merah";
            this.checkboxWarnaMerah.UseVisualStyleBackColor = true;
            this.checkboxWarnaMerah.CheckedChanged += new System.EventHandler(this.checkboxWarnaMerah_CheckedChanged);
            // 
            // checkBoxWarnaBiru
            // 
            this.checkBoxWarnaBiru.AutoSize = true;
            this.checkBoxWarnaBiru.Location = new System.Drawing.Point(337, 115);
            this.checkBoxWarnaBiru.Name = "checkBoxWarnaBiru";
            this.checkBoxWarnaBiru.Size = new System.Drawing.Size(101, 21);
            this.checkBoxWarnaBiru.TabIndex = 8;
            this.checkBoxWarnaBiru.Text = "Warna Biru";
            this.checkBoxWarnaBiru.UseVisualStyleBackColor = true;
            this.checkBoxWarnaBiru.CheckedChanged += new System.EventHandler(this.checkBoxWarnaBiru_CheckedChanged);
            // 
            // labelDisplay
            // 
            this.labelDisplay.AutoSize = true;
            this.labelDisplay.Location = new System.Drawing.Point(393, 212);
            this.labelDisplay.Name = "labelDisplay";
            this.labelDisplay.Size = new System.Drawing.Size(12, 17);
            this.labelDisplay.TabIndex = 9;
            this.labelDisplay.Text = ".";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(78, 320);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(227, 23);
            this.buttonClear.TabIndex = 10;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelDisplay);
            this.Controls.Add(this.checkBoxWarnaBiru);
            this.Controls.Add(this.checkboxWarnaMerah);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBoxAktif);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form Materi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxAktif;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkboxWarnaMerah;
        private System.Windows.Forms.CheckBox checkBoxWarnaBiru;
        private System.Windows.Forms.Label labelDisplay;
        private System.Windows.Forms.Button buttonClear;
    }
}

