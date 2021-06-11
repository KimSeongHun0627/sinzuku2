
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EndClass = new ePOSOne.btnProduct.Button_WOC();
            this.startClass = new ePOSOne.btnProduct.Button_WOC();
            this.handsReset = new ePOSOne.btnProduct.Button_WOC();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.roomId = new System.Windows.Forms.TextBox();
            this.handsCountBox = new System.Windows.Forms.TextBox();
            this.stuCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.stuPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.stuPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(0, 170);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(446, 592);
            this.panel2.TabIndex = 3;
            // 
            // stuPanel
            // 
            this.stuPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.stuPanel.Controls.Add(this.textBox1);
            this.stuPanel.Controls.Add(this.name);
            this.stuPanel.Location = new System.Drawing.Point(0, 6);
            this.stuPanel.Name = "stuPanel";
            this.stuPanel.Size = new System.Drawing.Size(446, 76);
            this.stuPanel.TabIndex = 4;
            this.stuPanel.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(264, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(130, 32);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Kim";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.White;
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.name.Location = new System.Drawing.Point(60, 22);
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Size = new System.Drawing.Size(130, 32);
            this.name.TabIndex = 7;
            this.name.Text = "Kim";
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.EndClass);
            this.panel1.Controls.Add(this.startClass);
            this.panel1.Controls.Add(this.handsReset);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.roomId);
            this.panel1.Controls.Add(this.handsCountBox);
            this.panel1.Controls.Add(this.stuCount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 170);
            this.panel1.TabIndex = 2;
            // 
            // EndClass
            // 
            this.EndClass.BorderColor = System.Drawing.Color.Silver;
            this.EndClass.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.EndClass.FlatAppearance.BorderSize = 0;
            this.EndClass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.EndClass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.EndClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EndClass.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndClass.ForeColor = System.Drawing.SystemColors.Control;
            this.EndClass.Location = new System.Drawing.Point(292, 32);
            this.EndClass.Name = "EndClass";
            this.EndClass.OnHoverBorderColor = System.Drawing.Color.Silver;
            this.EndClass.OnHoverButtonColor = System.Drawing.Color.LightSkyBlue;
            this.EndClass.OnHoverTextColor = System.Drawing.Color.White;
            this.EndClass.Size = new System.Drawing.Size(131, 75);
            this.EndClass.TabIndex = 9;
            this.EndClass.Text = "lesson end";
            this.EndClass.TextColor = System.Drawing.Color.Navy;
            this.EndClass.UseVisualStyleBackColor = true;
            this.EndClass.Click += new System.EventHandler(this.EndClass_Click);
            // 
            // startClass
            // 
            this.startClass.BorderColor = System.Drawing.Color.Silver;
            this.startClass.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.startClass.FlatAppearance.BorderSize = 0;
            this.startClass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.startClass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.startClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startClass.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startClass.ForeColor = System.Drawing.SystemColors.Control;
            this.startClass.Location = new System.Drawing.Point(18, 32);
            this.startClass.Name = "startClass";
            this.startClass.OnHoverBorderColor = System.Drawing.Color.Silver;
            this.startClass.OnHoverButtonColor = System.Drawing.Color.LightSkyBlue;
            this.startClass.OnHoverTextColor = System.Drawing.Color.White;
            this.startClass.Size = new System.Drawing.Size(131, 75);
            this.startClass.TabIndex = 7;
            this.startClass.Text = "lesson start";
            this.startClass.TextColor = System.Drawing.Color.Navy;
            this.startClass.UseVisualStyleBackColor = true;
            this.startClass.Click += new System.EventHandler(this.startClass_Click);
            // 
            // handsReset
            // 
            this.handsReset.BorderColor = System.Drawing.Color.Silver;
            this.handsReset.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.handsReset.FlatAppearance.BorderSize = 0;
            this.handsReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.handsReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.handsReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.handsReset.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.handsReset.ForeColor = System.Drawing.SystemColors.Control;
            this.handsReset.Location = new System.Drawing.Point(155, 32);
            this.handsReset.Name = "handsReset";
            this.handsReset.OnHoverBorderColor = System.Drawing.Color.Silver;
            this.handsReset.OnHoverButtonColor = System.Drawing.Color.LightSkyBlue;
            this.handsReset.OnHoverTextColor = System.Drawing.Color.White;
            this.handsReset.Size = new System.Drawing.Size(131, 75);
            this.handsReset.TabIndex = 8;
            this.handsReset.Text = "reset hands";
            this.handsReset.TextColor = System.Drawing.Color.Navy;
            this.handsReset.UseVisualStyleBackColor = true;
            this.handsReset.Click += new System.EventHandler(this.handsReset_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(259, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 30);
            this.label3.TabIndex = 11;
            this.label3.Text = "hands";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(289, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "class code";
            // 
            // roomId
            // 
            this.roomId.Location = new System.Drawing.Point(363, 5);
            this.roomId.Name = "roomId";
            this.roomId.Size = new System.Drawing.Size(76, 21);
            this.roomId.TabIndex = 9;
            // 
            // handsCountBox
            // 
            this.handsCountBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.handsCountBox.Font = new System.Drawing.Font("굴림", 20.25F);
            this.handsCountBox.Location = new System.Drawing.Point(352, 114);
            this.handsCountBox.Multiline = true;
            this.handsCountBox.Name = "handsCountBox";
            this.handsCountBox.ReadOnly = true;
            this.handsCountBox.Size = new System.Drawing.Size(48, 39);
            this.handsCountBox.TabIndex = 4;
            // 
            // stuCount
            // 
            this.stuCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stuCount.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.stuCount.Location = new System.Drawing.Point(155, 121);
            this.stuCount.Name = "stuCount";
            this.stuCount.ReadOnly = true;
            this.stuCount.Size = new System.Drawing.Size(51, 32);
            this.stuCount.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(35, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "students";
            // 
            // FormList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(446, 762);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox roomId;
        private System.Windows.Forms.TextBox handsCountBox;
        private System.Windows.Forms.TextBox stuCount;
        private System.Windows.Forms.Label label1;
        private ePOSOne.btnProduct.Button_WOC startClass;
        private ePOSOne.btnProduct.Button_WOC EndClass;
        private ePOSOne.btnProduct.Button_WOC handsReset;
        private System.Windows.Forms.Panel stuPanel;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox textBox1;
    }
}