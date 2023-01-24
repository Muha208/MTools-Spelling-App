namespace SpellingApp
{
    partial class SpellingToolForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpellingToolForm));
            this.lbSpelling = new System.Windows.Forms.Label();
            this.tbInputNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCurancy = new System.Windows.Forms.ComboBox();
            this.rtbResultText = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbOnly = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSpelling
            // 
            this.lbSpelling.AutoSize = true;
            this.lbSpelling.BackColor = System.Drawing.SystemColors.Control;
            this.lbSpelling.Font = new System.Drawing.Font("Franklin Gothic Heavy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSpelling.ForeColor = System.Drawing.Color.Black;
            this.lbSpelling.Location = new System.Drawing.Point(83, 9);
            this.lbSpelling.Name = "lbSpelling";
            this.lbSpelling.Size = new System.Drawing.Size(186, 24);
            this.lbSpelling.TabIndex = 0;
            this.lbSpelling.Text = "Arabic Spelling Tool";
            this.lbSpelling.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbSpelling.Click += new System.EventHandler(this.lbSpelling_Click);
            // 
            // tbInputNumber
            // 
            this.tbInputNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInputNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbInputNumber.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInputNumber.Location = new System.Drawing.Point(178, 51);
            this.tbInputNumber.Name = "tbInputNumber";
            this.tbInputNumber.Size = new System.Drawing.Size(144, 26);
            this.tbInputNumber.TabIndex = 1;
            this.tbInputNumber.TextChanged += new System.EventHandler(this.tbInputNumber_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Your Number";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select The Curancy";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbCurancy
            // 
            this.cbCurancy.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCurancy.FormattingEnabled = true;
            this.cbCurancy.Location = new System.Drawing.Point(178, 93);
            this.cbCurancy.Name = "cbCurancy";
            this.cbCurancy.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbCurancy.Size = new System.Drawing.Size(144, 26);
            this.cbCurancy.TabIndex = 2;
            this.cbCurancy.SelectedIndexChanged += new System.EventHandler(this.cbCurancy_SelectedIndexChanged);
            // 
            // rtbResultText
            // 
            this.rtbResultText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbResultText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rtbResultText.Location = new System.Drawing.Point(11, 153);
            this.rtbResultText.Name = "rtbResultText";
            this.rtbResultText.ReadOnly = true;
            this.rtbResultText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rtbResultText.Size = new System.Drawing.Size(311, 65);
            this.rtbResultText.TabIndex = 4;
            this.rtbResultText.Text = "اقصى حد للتفقيط = 99999";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "Eng.Muhammad Osama";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbOnly
            // 
            this.cbOnly.AutoSize = true;
            this.cbOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOnly.Location = new System.Drawing.Point(239, 123);
            this.cbOnly.Name = "cbOnly";
            this.cbOnly.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbOnly.Size = new System.Drawing.Size(83, 24);
            this.cbOnly.TabIndex = 10;
            this.cbOnly.TabStop = false;
            this.cbOnly.Text = "فقط لا غير";
            this.cbOnly.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbOnly.UseVisualStyleBackColor = true;
            this.cbOnly.CheckedChanged += new System.EventHandler(this.cbOnly_CheckedChanged);
            // 
            // SpellingToolForm
            // 
            this.AccessibleDescription = "Spelling MTools";
            this.AccessibleName = "Eng.Muhammad Osama";
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(334, 242);
            this.Controls.Add(this.cbOnly);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbSpelling);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rtbResultText);
            this.Controls.Add(this.cbCurancy);
            this.Controls.Add(this.tbInputNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SpellingToolForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Tag = "Spelling MTools";
            this.Text = "Spelling MTools";
            this.Load += new System.EventHandler(this.SpellingToolForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSpelling;
        private System.Windows.Forms.TextBox tbInputNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCurancy;
        private System.Windows.Forms.RichTextBox rtbResultText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbOnly;
    }
}

