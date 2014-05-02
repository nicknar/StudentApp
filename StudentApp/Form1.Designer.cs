namespace StudentApp
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.rbtnq = new System.Windows.Forms.RadioButton();
            this.rbtnm = new System.Windows.Forms.RadioButton();
            this.rbtmbx = new System.Windows.Forms.RadioButton();
            this.rbtnbn = new System.Windows.Forms.RadioButton();
            this.rbtnst = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(324, 199);
            this.listBox1.TabIndex = 0;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // rbtnq
            // 
            this.rbtnq.AutoSize = true;
            this.rbtnq.Location = new System.Drawing.Point(12, 236);
            this.rbtnq.Name = "rbtnq";
            this.rbtnq.Size = new System.Drawing.Size(62, 17);
            this.rbtnq.TabIndex = 3;
            this.rbtnq.Text = "Queens";
            this.rbtnq.UseVisualStyleBackColor = true;
            this.rbtnq.Click += new System.EventHandler(this.rbtnq_Click);
            // 
            // rbtnm
            // 
            this.rbtnm.AutoSize = true;
            this.rbtnm.Location = new System.Drawing.Point(80, 236);
            this.rbtnm.Name = "rbtnm";
            this.rbtnm.Size = new System.Drawing.Size(76, 17);
            this.rbtnm.TabIndex = 4;
            this.rbtnm.Text = "Manhattan";
            this.rbtnm.UseVisualStyleBackColor = true;
            this.rbtnm.Click += new System.EventHandler(this.rbtnm_Click);
            // 
            // rbtmbx
            // 
            this.rbtmbx.AutoSize = true;
            this.rbtmbx.Location = new System.Drawing.Point(12, 259);
            this.rbtmbx.Name = "rbtmbx";
            this.rbtmbx.Size = new System.Drawing.Size(52, 17);
            this.rbtmbx.TabIndex = 5;
            this.rbtmbx.Text = "Bronx";
            this.rbtmbx.UseVisualStyleBackColor = true;
            this.rbtmbx.Click += new System.EventHandler(this.rbtmbx_Click);
            // 
            // rbtnbn
            // 
            this.rbtnbn.AutoSize = true;
            this.rbtnbn.Location = new System.Drawing.Point(80, 259);
            this.rbtnbn.Name = "rbtnbn";
            this.rbtnbn.Size = new System.Drawing.Size(66, 17);
            this.rbtnbn.TabIndex = 6;
            this.rbtnbn.Text = "Brooklyn";
            this.rbtnbn.UseVisualStyleBackColor = true;
            this.rbtnbn.Click += new System.EventHandler(this.rbtnbn_Click);
            // 
            // rbtnst
            // 
            this.rbtnst.AutoSize = true;
            this.rbtnst.Location = new System.Drawing.Point(162, 236);
            this.rbtnst.Name = "rbtnst";
            this.rbtnst.Size = new System.Drawing.Size(87, 17);
            this.rbtnst.TabIndex = 7;
            this.rbtnst.Text = "Staten Island";
            this.rbtnst.UseVisualStyleBackColor = true;
            this.rbtnst.Click += new System.EventHandler(this.rbtnst_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(342, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 154);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(342, 217);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(168, 148);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Phone #";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(408, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(341, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Site Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(424, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 372);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rbtnst);
            this.Controls.Add(this.rbtnbn);
            this.Controls.Add(this.rbtmbx);
            this.Controls.Add(this.rbtnm);
            this.Controls.Add(this.rbtnq);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "NY Youth Summer Jobs";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton rbtnq;
        private System.Windows.Forms.RadioButton rbtnm;
        private System.Windows.Forms.RadioButton rbtmbx;
        private System.Windows.Forms.RadioButton rbtnbn;
        private System.Windows.Forms.RadioButton rbtnst;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

