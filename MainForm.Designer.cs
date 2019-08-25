namespace Fake_Name_Generator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbGen = new System.Windows.Forms.ComboBox();
            this.cmbCon = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGnr = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAmnt = new System.Windows.Forms.TextBox();
            this.txtres = new System.Windows.Forms.TextBox();
            this.lblReport = new System.Windows.Forms.Label();
            this.btnClear = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gender :";
            // 
            // cmbGen
            // 
            this.cmbGen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGen.FormattingEnabled = true;
            this.cmbGen.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGen.Location = new System.Drawing.Point(30, 119);
            this.cmbGen.Name = "cmbGen";
            this.cmbGen.Size = new System.Drawing.Size(90, 21);
            this.cmbGen.TabIndex = 0;
            // 
            // cmbCon
            // 
            this.cmbCon.AutoCompleteCustomSource.AddRange(new string[] {
            "American",
            "Arabic",
            "Australian",
            "Brazil",
            "Chechen ",
            "Chinese",
            "Croatian",
            "Czech",
            "Danish",
            "Dutch",
            "England",
            "Eritrean",
            "Finnish",
            "French",
            "German",
            "Greenland",
            "Hispanic",
            "Hobbit",
            "Hungarian",
            "Icelandic",
            "Igbo",
            "Italian",
            "Japanese",
            "Klingon",
            "Ninja",
            "Norwegian",
            "Persian",
            "Polish",
            "Russian",
            "Scottish",
            "Slovenian",
            "Swedish",
            "Thai",
            "Vietnamese"});
            this.cmbCon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbCon.DropDownHeight = 120;
            this.cmbCon.DropDownWidth = 100;
            this.cmbCon.FormattingEnabled = true;
            this.cmbCon.IntegralHeight = false;
            this.cmbCon.Items.AddRange(new object[] {
            "American",
            "Arabic",
            "Australian",
            "Brazil",
            "Chinese",
            "Croatian",
            "Czech",
            "Danish",
            "Dutch",
            "England",
            "Eritrean",
            "Finnish",
            "French",
            "German",
            "Greenland",
            "Hungarian",
            "Icelandic",
            "Italian",
            "Japanese",
            "Norwegian",
            "Persian",
            "Polish",
            "Russian",
            "Scottish",
            "Slovenian",
            "Swedish",
            "Thai",
            "Vietnamese"});
            this.cmbCon.Location = new System.Drawing.Point(142, 119);
            this.cmbCon.Name = "cmbCon";
            this.cmbCon.Size = new System.Drawing.Size(114, 21);
            this.cmbCon.Sorted = true;
            this.cmbCon.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Country :";
            // 
            // btnGnr
            // 
            this.btnGnr.Depth = 0;
            this.btnGnr.Location = new System.Drawing.Point(373, 117);
            this.btnGnr.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGnr.Name = "btnGnr";
            this.btnGnr.Primary = true;
            this.btnGnr.Size = new System.Drawing.Size(57, 23);
            this.btnGnr.TabIndex = 2;
            this.btnGnr.Text = "Go";
            this.btnGnr.UseVisualStyleBackColor = true;
            this.btnGnr.Click += new System.EventHandler(this.btnGnr_Click);
            // 
            // btnSave
            // 
            this.btnSave.Depth = 0;
            this.btnSave.Location = new System.Drawing.Point(344, 165);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = true;
            this.btnSave.Size = new System.Drawing.Size(86, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Results :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Amount :";
            // 
            // txtAmnt
            // 
            this.txtAmnt.Location = new System.Drawing.Point(278, 120);
            this.txtAmnt.Name = "txtAmnt";
            this.txtAmnt.Size = new System.Drawing.Size(78, 20);
            this.txtAmnt.TabIndex = 10;
            this.txtAmnt.Text = "100";
            this.txtAmnt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmnt_KeyPress);
            // 
            // txtres
            // 
            this.txtres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtres.Location = new System.Drawing.Point(84, 170);
            this.txtres.Name = "txtres";
            this.txtres.ReadOnly = true;
            this.txtres.Size = new System.Drawing.Size(145, 13);
            this.txtres.TabIndex = 11;
            this.txtres.Text = "No Data Found";
            // 
            // lblReport
            // 
            this.lblReport.AutoSize = true;
            this.lblReport.Location = new System.Drawing.Point(29, 208);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(76, 13);
            this.lblReport.TabIndex = 12;
            this.lblReport.Text = "Please Wait....";
            this.lblReport.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.Depth = 0;
            this.btnClear.Location = new System.Drawing.Point(252, 165);
            this.btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClear.Name = "btnClear";
            this.btnClear.Primary = true;
            this.btnClear.Size = new System.Drawing.Size(86, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 243);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblReport);
            this.Controls.Add(this.txtres);
            this.Controls.Add(this.txtAmnt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnGnr);
            this.Controls.Add(this.cmbCon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbGen);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fake Name Generator | Softkini Corporation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbGen;
        private System.Windows.Forms.ComboBox cmbCon;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialRaisedButton btnGnr;
        private MaterialSkin.Controls.MaterialRaisedButton btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAmnt;
        private System.Windows.Forms.TextBox txtres;
        private System.Windows.Forms.Label lblReport;
        private MaterialSkin.Controls.MaterialRaisedButton btnClear;
    }
}

