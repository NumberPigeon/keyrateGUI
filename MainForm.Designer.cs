namespace KeyRateGUI
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelDelay = new System.Windows.Forms.Label();
            this.labelRepeat = new System.Windows.Forms.Label();
            this.textBoxDelay = new System.Windows.Forms.TextBox();
            this.textBoxRepeat = new System.Windows.Forms.TextBox();
            this.buttonSet = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelTest = new System.Windows.Forms.Label();
            this.textBoxTest = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelVersion = new System.Windows.Forms.Label();
            this.linkLabelSource = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // labelDelay
            // 
            this.labelDelay.AutoSize = true;
            this.labelDelay.Location = new System.Drawing.Point(54, 33);
            this.labelDelay.Name = "labelDelay";
            this.labelDelay.Size = new System.Drawing.Size(37, 13);
            this.labelDelay.TabIndex = 0;
            this.labelDelay.Text = "Delay:";
            // 
            // labelRepeat
            // 
            this.labelRepeat.AutoSize = true;
            this.labelRepeat.Location = new System.Drawing.Point(25, 62);
            this.labelRepeat.Name = "labelRepeat";
            this.labelRepeat.Size = new System.Drawing.Size(66, 13);
            this.labelRepeat.TabIndex = 1;
            this.labelRepeat.Text = "Repeat rate:";
            // 
            // textBoxDelay
            // 
            this.textBoxDelay.Location = new System.Drawing.Point(107, 30);
            this.textBoxDelay.Name = "textBoxDelay";
            this.textBoxDelay.Size = new System.Drawing.Size(100, 20);
            this.textBoxDelay.TabIndex = 2;
            this.textBoxDelay.Text = "150";
            // 
            // textBoxRepeat
            // 
            this.textBoxRepeat.Location = new System.Drawing.Point(107, 59);
            this.textBoxRepeat.Name = "textBoxRepeat";
            this.textBoxRepeat.Size = new System.Drawing.Size(100, 20);
            this.textBoxRepeat.TabIndex = 3;
            this.textBoxRepeat.Text = "10";
            // 
            // buttonSet
            // 
            this.buttonSet.Location = new System.Drawing.Point(28, 101);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Size = new System.Drawing.Size(78, 23);
            this.buttonSet.TabIndex = 4;
            this.buttonSet.Text = "Set";
            this.buttonSet.UseVisualStyleBackColor = true;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(126, 101);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(78, 23);
            this.buttonReset.TabIndex = 5;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(28, 141);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(25, 13);
            this.labelResult.TabIndex = 6;
            this.labelResult.Text = "......";
            // 
            // labelTest
            // 
            this.labelTest.AutoSize = true;
            this.labelTest.Location = new System.Drawing.Point(21, 178);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(139, 13);
            this.labelTest.TabIndex = 7;
            this.labelTest.Text = "Test keyrate settings below:";
            // 
            // textBoxTest
            // 
            this.textBoxTest.Location = new System.Drawing.Point(22, 199);
            this.textBoxTest.Name = "textBoxTest";
            this.textBoxTest.Size = new System.Drawing.Size(107, 20);
            this.textBoxTest.TabIndex = 8;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(138, 197);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(69, 23);
            this.buttonClear.TabIndex = 9;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(26, 242);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(37, 13);
            this.labelVersion.TabIndex = 10;
            this.labelVersion.Text = "v1.0.0";
            // 
            // linkLabelSource
            // 
            this.linkLabelSource.AutoSize = true;
            this.linkLabelSource.Location = new System.Drawing.Point(24, 259);
            this.linkLabelSource.Name = "linkLabelSource";
            this.linkLabelSource.Size = new System.Drawing.Size(73, 13);
            this.linkLabelSource.TabIndex = 11;
            this.linkLabelSource.TabStop = true;
            this.linkLabelSource.Text = "github Source";
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(234, 311);
            this.Controls.Add(this.linkLabelSource);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textBoxTest);
            this.Controls.Add(this.labelTest);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonSet);
            this.Controls.Add(this.textBoxRepeat);
            this.Controls.Add(this.textBoxDelay);
            this.Controls.Add(this.labelRepeat);
            this.Controls.Add(this.labelDelay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "KeyRateGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDelay;
        private System.Windows.Forms.Label labelRepeat;
        private System.Windows.Forms.TextBox textBoxDelay;
        private System.Windows.Forms.TextBox textBoxRepeat;
        private System.Windows.Forms.Button buttonSet;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelTest;
        private System.Windows.Forms.TextBox textBoxTest;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.LinkLabel linkLabelSource;
    }
}

