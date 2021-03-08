
namespace sinzuku
{
    partial class FormList
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.stuPanel = new System.Windows.Forms.Panel();
            this.name = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.PictureBox();
            this.handStatus = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.startClass = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.EndClass = new System.Windows.Forms.Button();
            this.handsReset = new System.Windows.Forms.Button();
            this.handsCountBox = new System.Windows.Forms.TextBox();
            this.stuCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.stuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.handStatus)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.stuPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(559, 662);
            this.panel2.TabIndex = 3;
            // 
            // stuPanel
            // 
            this.stuPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.stuPanel.Controls.Add(this.name);
            this.stuPanel.Controls.Add(this.exit);
            this.stuPanel.Controls.Add(this.handStatus);
            this.stuPanel.Location = new System.Drawing.Point(0, 6);
            this.stuPanel.Name = "stuPanel";
            this.stuPanel.Size = new System.Drawing.Size(559, 76);
            this.stuPanel.TabIndex = 4;
            this.stuPanel.Visible = false;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.name.Location = new System.Drawing.Point(12, 13);
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Size = new System.Drawing.Size(112, 39);
            this.name.TabIndex = 7;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.exit.Location = new System.Drawing.Point(300, 13);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(100, 50);
            this.exit.TabIndex = 6;
            this.exit.TabStop = false;
            this.exit.Visible = false;
            // 
            // handStatus
            // 
            this.handStatus.BackColor = System.Drawing.Color.Lime;
            this.handStatus.Location = new System.Drawing.Point(194, 13);
            this.handStatus.Name = "handStatus";
            this.handStatus.Size = new System.Drawing.Size(100, 50);
            this.handStatus.TabIndex = 5;
            this.handStatus.TabStop = false;
            this.handStatus.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.startClass);
            this.panel1.Controls.Add(this.refresh);
            this.panel1.Controls.Add(this.EndClass);
            this.panel1.Controls.Add(this.handsReset);
            this.panel1.Controls.Add(this.handsCountBox);
            this.panel1.Controls.Add(this.stuCount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 100);
            this.panel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "손든 학생 수";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "방코드";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(398, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 21);
            this.textBox1.TabIndex = 9;
            // 
            // startClass
            // 
            this.startClass.Location = new System.Drawing.Point(342, 30);
            this.startClass.Name = "startClass";
            this.startClass.Size = new System.Drawing.Size(100, 53);
            this.startClass.TabIndex = 8;
            this.startClass.Text = "수업 시작";
            this.startClass.UseVisualStyleBackColor = true;
            this.startClass.Click += new System.EventHandler(this.startClass_Click);
            // 
            // refresh
            // 
            this.refresh.Enabled = false;
            this.refresh.Location = new System.Drawing.Point(130, 30);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(100, 53);
            this.refresh.TabIndex = 7;
            this.refresh.Text = "새로고침";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // EndClass
            // 
            this.EndClass.Enabled = false;
            this.EndClass.Location = new System.Drawing.Point(448, 30);
            this.EndClass.Name = "EndClass";
            this.EndClass.Size = new System.Drawing.Size(100, 53);
            this.EndClass.TabIndex = 6;
            this.EndClass.Text = "수업 종료";
            this.EndClass.UseVisualStyleBackColor = true;
            this.EndClass.Click += new System.EventHandler(this.EndClass_Click);
            // 
            // handsReset
            // 
            this.handsReset.Enabled = false;
            this.handsReset.Location = new System.Drawing.Point(236, 30);
            this.handsReset.Name = "handsReset";
            this.handsReset.Size = new System.Drawing.Size(100, 53);
            this.handsReset.TabIndex = 5;
            this.handsReset.Text = "손들기 초기화";
            this.handsReset.UseVisualStyleBackColor = true;
            this.handsReset.Click += new System.EventHandler(this.handsReset_Click);
            // 
            // handsCountBox
            // 
            this.handsCountBox.Location = new System.Drawing.Point(249, 3);
            this.handsCountBox.Name = "handsCountBox";
            this.handsCountBox.ReadOnly = true;
            this.handsCountBox.Size = new System.Drawing.Size(58, 21);
            this.handsCountBox.TabIndex = 4;
            // 
            // stuCount
            // 
            this.stuCount.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.stuCount.Location = new System.Drawing.Point(12, 47);
            this.stuCount.Name = "stuCount";
            this.stuCount.ReadOnly = true;
            this.stuCount.Size = new System.Drawing.Size(112, 39);
            this.stuCount.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "학생 수";
            // 
            // FormList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(559, 762);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormList";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormList";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormList_FormClosing);
            this.panel2.ResumeLayout(false);
            this.stuPanel.ResumeLayout(false);
            this.stuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.handStatus)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel stuPanel;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.PictureBox handStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button startClass;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button EndClass;
        private System.Windows.Forms.Button handsReset;
        private System.Windows.Forms.TextBox handsCountBox;
        private System.Windows.Forms.TextBox stuCount;
        private System.Windows.Forms.Label label1;
    }
}