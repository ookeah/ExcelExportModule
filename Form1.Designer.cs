namespace ExcelExportModule
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.txtTargetPath = new System.Windows.Forms.TextBox();
            this.btnPath = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtToExpDirPath = new System.Windows.Forms.TextBox();
            this.btnExecExport = new System.Windows.Forms.Button();
            this.rtxtLog = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "target(*.xlsm)";
            // 
            // txtTargetPath
            // 
            this.txtTargetPath.Location = new System.Drawing.Point(104, 22);
            this.txtTargetPath.Name = "txtTargetPath";
            this.txtTargetPath.Size = new System.Drawing.Size(575, 19);
            this.txtTargetPath.TabIndex = 1;
            this.txtTargetPath.Text = "-80char-";
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(685, 20);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(41, 23);
            this.btnPath.TabIndex = 2;
            this.btnPath.Text = "...";
            this.btnPath.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "toExportDir";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(685, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtToExpDirPath
            // 
            this.txtToExpDirPath.Location = new System.Drawing.Point(104, 60);
            this.txtToExpDirPath.Name = "txtToExpDirPath";
            this.txtToExpDirPath.Size = new System.Drawing.Size(575, 19);
            this.txtToExpDirPath.TabIndex = 4;
            this.txtToExpDirPath.Text = "-80char-";
            // 
            // btnExecExport
            // 
            this.btnExecExport.Location = new System.Drawing.Point(651, 99);
            this.btnExecExport.Name = "btnExecExport";
            this.btnExecExport.Size = new System.Drawing.Size(75, 23);
            this.btnExecExport.TabIndex = 6;
            this.btnExecExport.Text = "Export";
            this.btnExecExport.UseVisualStyleBackColor = true;
            // 
            // rtxtLog
            // 
            this.rtxtLog.Location = new System.Drawing.Point(104, 136);
            this.rtxtLog.Name = "rtxtLog";
            this.rtxtLog.Size = new System.Drawing.Size(575, 270);
            this.rtxtLog.TabIndex = 7;
            this.rtxtLog.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "Log";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 435);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtxtLog);
            this.Controls.Add(this.btnExecExport);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtToExpDirPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.txtTargetPath);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ExcelExportModule";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTargetPath;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtToExpDirPath;
        private System.Windows.Forms.Button btnExecExport;
        private System.Windows.Forms.RichTextBox rtxtLog;
        private System.Windows.Forms.Label label3;
    }
}

