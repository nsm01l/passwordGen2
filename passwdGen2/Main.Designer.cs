namespace passwdGen2
{
    partial class Main
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtLen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.chkLowUp = new System.Windows.Forms.CheckBox();
            this.chkAlNum = new System.Windows.Forms.CheckBox();
            this.btnGen = new System.Windows.Forms.Button();
            this.txtPasswd = new System.Windows.Forms.TextBox();
            this.btnLDec = new System.Windows.Forms.Button();
            this.btnLInc = new System.Windows.Forms.Button();
            this.btnLLShift = new System.Windows.Forms.Button();
            this.btnLRShift = new System.Windows.Forms.Button();
            this.btnNRShift = new System.Windows.Forms.Button();
            this.btnNLShift = new System.Windows.Forms.Button();
            this.btnNInc = new System.Windows.Forms.Button();
            this.btnNDec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "桁数(&L)";
            // 
            // txtLen
            // 
            this.txtLen.Location = new System.Drawing.Point(66, 6);
            this.txtLen.Name = "txtLen";
            this.txtLen.Size = new System.Drawing.Size(100, 19);
            this.txtLen.TabIndex = 1;
            this.txtLen.Text = "16";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "個数(&N)";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(66, 59);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 19);
            this.txtNum.TabIndex = 7;
            this.txtNum.Text = "1";
            // 
            // chkLowUp
            // 
            this.chkLowUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkLowUp.AutoSize = true;
            this.chkLowUp.Checked = true;
            this.chkLowUp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLowUp.Location = new System.Drawing.Point(211, 8);
            this.chkLowUp.Name = "chkLowUp";
            this.chkLowUp.Size = new System.Drawing.Size(142, 16);
            this.chkLowUp.TabIndex = 12;
            this.chkLowUp.Text = "大文字・小文字混在(&U)";
            this.chkLowUp.UseVisualStyleBackColor = true;
            // 
            // chkAlNum
            // 
            this.chkAlNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkAlNum.AutoSize = true;
            this.chkAlNum.Checked = true;
            this.chkAlNum.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAlNum.Location = new System.Drawing.Point(211, 34);
            this.chkAlNum.Name = "chkAlNum";
            this.chkAlNum.Size = new System.Drawing.Size(100, 16);
            this.chkAlNum.TabIndex = 13;
            this.chkAlNum.Text = "英数字混在(&A)";
            this.chkAlNum.UseVisualStyleBackColor = true;
            // 
            // btnGen
            // 
            this.btnGen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGen.Location = new System.Drawing.Point(236, 62);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(75, 33);
            this.btnGen.TabIndex = 14;
            this.btnGen.Text = "作る(&G)";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // txtPasswd
            // 
            this.txtPasswd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPasswd.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtPasswd.Location = new System.Drawing.Point(0, 110);
            this.txtPasswd.Multiline = true;
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPasswd.Size = new System.Drawing.Size(359, 203);
            this.txtPasswd.TabIndex = 15;
            // 
            // btnLDec
            // 
            this.btnLDec.Location = new System.Drawing.Point(90, 30);
            this.btnLDec.Name = "btnLDec";
            this.btnLDec.Size = new System.Drawing.Size(20, 20);
            this.btnLDec.TabIndex = 3;
            this.btnLDec.Text = "-";
            this.btnLDec.UseVisualStyleBackColor = true;
            this.btnLDec.Click += new System.EventHandler(this.btnLDec_Click);
            // 
            // btnLInc
            // 
            this.btnLInc.Location = new System.Drawing.Point(116, 30);
            this.btnLInc.Name = "btnLInc";
            this.btnLInc.Size = new System.Drawing.Size(20, 20);
            this.btnLInc.TabIndex = 4;
            this.btnLInc.Text = "+";
            this.btnLInc.UseVisualStyleBackColor = true;
            this.btnLInc.Click += new System.EventHandler(this.btnLInc_Click);
            // 
            // btnLLShift
            // 
            this.btnLLShift.Location = new System.Drawing.Point(49, 30);
            this.btnLLShift.Name = "btnLLShift";
            this.btnLLShift.Size = new System.Drawing.Size(20, 20);
            this.btnLLShift.TabIndex = 2;
            this.btnLLShift.Text = "<";
            this.btnLLShift.UseVisualStyleBackColor = true;
            this.btnLLShift.Click += new System.EventHandler(this.btnLLShift_Click);
            // 
            // btnLRShift
            // 
            this.btnLRShift.Location = new System.Drawing.Point(157, 30);
            this.btnLRShift.Name = "btnLRShift";
            this.btnLRShift.Size = new System.Drawing.Size(20, 20);
            this.btnLRShift.TabIndex = 5;
            this.btnLRShift.Text = ">";
            this.btnLRShift.UseVisualStyleBackColor = true;
            this.btnLRShift.Click += new System.EventHandler(this.btnLRShift_Click);
            // 
            // btnNRShift
            // 
            this.btnNRShift.Location = new System.Drawing.Point(157, 84);
            this.btnNRShift.Name = "btnNRShift";
            this.btnNRShift.Size = new System.Drawing.Size(20, 20);
            this.btnNRShift.TabIndex = 11;
            this.btnNRShift.Text = ">";
            this.btnNRShift.UseVisualStyleBackColor = true;
            this.btnNRShift.Click += new System.EventHandler(this.btnNRShift_Click);
            // 
            // btnNLShift
            // 
            this.btnNLShift.Location = new System.Drawing.Point(49, 84);
            this.btnNLShift.Name = "btnNLShift";
            this.btnNLShift.Size = new System.Drawing.Size(20, 20);
            this.btnNLShift.TabIndex = 8;
            this.btnNLShift.Text = "<";
            this.btnNLShift.UseVisualStyleBackColor = true;
            this.btnNLShift.Click += new System.EventHandler(this.btnNLShift_Click);
            // 
            // btnNInc
            // 
            this.btnNInc.Location = new System.Drawing.Point(116, 84);
            this.btnNInc.Name = "btnNInc";
            this.btnNInc.Size = new System.Drawing.Size(20, 20);
            this.btnNInc.TabIndex = 10;
            this.btnNInc.Text = "+";
            this.btnNInc.UseVisualStyleBackColor = true;
            this.btnNInc.Click += new System.EventHandler(this.btnNInc_Click);
            // 
            // btnNDec
            // 
            this.btnNDec.Location = new System.Drawing.Point(90, 84);
            this.btnNDec.Name = "btnNDec";
            this.btnNDec.Size = new System.Drawing.Size(20, 20);
            this.btnNDec.TabIndex = 9;
            this.btnNDec.Text = "-";
            this.btnNDec.UseVisualStyleBackColor = true;
            this.btnNDec.Click += new System.EventHandler(this.btnNDec_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 313);
            this.Controls.Add(this.btnNRShift);
            this.Controls.Add(this.btnNLShift);
            this.Controls.Add(this.btnNInc);
            this.Controls.Add(this.btnNDec);
            this.Controls.Add(this.btnLRShift);
            this.Controls.Add(this.btnLLShift);
            this.Controls.Add(this.btnLInc);
            this.Controls.Add(this.btnLDec);
            this.Controls.Add(this.txtPasswd);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.chkAlNum);
            this.Controls.Add(this.chkLowUp);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLen);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "passwdGen2";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.CheckBox chkLowUp;
        private System.Windows.Forms.CheckBox chkAlNum;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.TextBox txtPasswd;
        private System.Windows.Forms.Button btnLDec;
        private System.Windows.Forms.Button btnLInc;
        private System.Windows.Forms.Button btnLLShift;
        private System.Windows.Forms.Button btnLRShift;
        private System.Windows.Forms.Button btnNRShift;
        private System.Windows.Forms.Button btnNLShift;
        private System.Windows.Forms.Button btnNInc;
        private System.Windows.Forms.Button btnNDec;
    }
}

