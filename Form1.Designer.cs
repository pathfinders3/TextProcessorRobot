namespace TextProcessorRobot
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeEmptyLinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblVowels1 = new System.Windows.Forms.Label();
            this.lblVowels2 = new System.Windows.Forms.Label();
            this.lblConso2 = new System.Windows.Forms.Label();
            this.lblConso1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 118);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(543, 141);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeEmptyLinesToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // removeEmptyLinesToolStripMenuItem
            // 
            this.removeEmptyLinesToolStripMenuItem.Name = "removeEmptyLinesToolStripMenuItem";
            this.removeEmptyLinesToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.removeEmptyLinesToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.removeEmptyLinesToolStripMenuItem.Text = "Remove Empty Lines";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 268);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(543, 141);
            this.textBox2.TabIndex = 2;
            // 
            // lblVowels1
            // 
            this.lblVowels1.AutoSize = true;
            this.lblVowels1.Location = new System.Drawing.Point(12, 72);
            this.lblVowels1.Name = "lblVowels1";
            this.lblVowels1.Size = new System.Drawing.Size(82, 15);
            this.lblVowels1.TabIndex = 3;
            this.lblVowels1.Text = "ㅓㅕㅣㅏㅑ";
            // 
            // lblVowels2
            // 
            this.lblVowels2.AutoSize = true;
            this.lblVowels2.Location = new System.Drawing.Point(12, 49);
            this.lblVowels2.Name = "lblVowels2";
            this.lblVowels2.Size = new System.Drawing.Size(82, 15);
            this.lblVowels2.TabIndex = 4;
            this.lblVowels2.Text = "ㅗㅛㅡㅜㅠ";
            // 
            // lblConso2
            // 
            this.lblConso2.AutoSize = true;
            this.lblConso2.Location = new System.Drawing.Point(128, 73);
            this.lblConso2.Name = "lblConso2";
            this.lblConso2.Size = new System.Drawing.Size(82, 15);
            this.lblConso2.TabIndex = 6;
            this.lblConso2.Text = "ㅁㄴㅇㄹㅎ";
            // 
            // lblConso1
            // 
            this.lblConso1.AutoSize = true;
            this.lblConso1.Location = new System.Drawing.Point(128, 48);
            this.lblConso1.Name = "lblConso1";
            this.lblConso1.Size = new System.Drawing.Size(82, 15);
            this.lblConso1.TabIndex = 5;
            this.lblConso1.Text = "ㅂㅈㄷㄱㅅ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblConso2);
            this.Controls.Add(this.lblConso1);
            this.Controls.Add(this.lblVowels2);
            this.Controls.Add(this.lblVowels1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Text Processor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeEmptyLinesToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblVowels1;
        private System.Windows.Forms.Label lblVowels2;
        private System.Windows.Forms.Label lblConso2;
        private System.Windows.Forms.Label lblConso1;
    }
}

