namespace 슬라이딩_숫자_퍼즐_게임
{
    partial class Certification
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
            this.ID_la = new System.Windows.Forms.Label();
            this.Password_la = new System.Windows.Forms.Label();
            this.ID_textBox = new System.Windows.Forms.TextBox();
            this.Password_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.result_la = new System.Windows.Forms.Label();
            this.close_btn = new System.Windows.Forms.Button();
            this.Enter_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ID_la
            // 
            this.ID_la.AutoSize = true;
            this.ID_la.Font = new System.Drawing.Font("굴림체", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ID_la.ForeColor = System.Drawing.Color.White;
            this.ID_la.Location = new System.Drawing.Point(56, 30);
            this.ID_la.Name = "ID_la";
            this.ID_la.Size = new System.Drawing.Size(32, 21);
            this.ID_la.TabIndex = 1;
            this.ID_la.Text = "ID";
            // 
            // Password_la
            // 
            this.Password_la.AutoSize = true;
            this.Password_la.Font = new System.Drawing.Font("굴림체", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Password_la.ForeColor = System.Drawing.Color.White;
            this.Password_la.Location = new System.Drawing.Point(29, 82);
            this.Password_la.Name = "Password_la";
            this.Password_la.Size = new System.Drawing.Size(98, 21);
            this.Password_la.TabIndex = 2;
            this.Password_la.Text = "Password";
            // 
            // ID_textBox
            // 
            this.ID_textBox.Cursor = System.Windows.Forms.Cursors.No;
            this.ID_textBox.Enabled = false;
            this.ID_textBox.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ID_textBox.Location = new System.Drawing.Point(147, 24);
            this.ID_textBox.Name = "ID_textBox";
            this.ID_textBox.Size = new System.Drawing.Size(170, 35);
            this.ID_textBox.TabIndex = 3;
            this.ID_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Password_textBox
            // 
            this.Password_textBox.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Password_textBox.Location = new System.Drawing.Point(147, 76);
            this.Password_textBox.Name = "Password_textBox";
            this.Password_textBox.PasswordChar = '*';
            this.Password_textBox.Size = new System.Drawing.Size(170, 35);
            this.Password_textBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "인증 결과";
            // 
            // result_la
            // 
            this.result_la.AutoSize = true;
            this.result_la.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.result_la.ForeColor = System.Drawing.Color.White;
            this.result_la.Location = new System.Drawing.Point(198, 151);
            this.result_la.Name = "result_la";
            this.result_la.Size = new System.Drawing.Size(80, 21);
            this.result_la.TabIndex = 6;
            this.result_la.Text = "          ";
            // 
            // close_btn
            // 
            this.close_btn.Location = new System.Drawing.Point(379, 180);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(75, 23);
            this.close_btn.TabIndex = 7;
            this.close_btn.Text = "닫기";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // Enter_btn
            // 
            this.Enter_btn.BackColor = System.Drawing.Color.Transparent;
            this.Enter_btn.BackgroundImage = global::슬라이딩_숫자_퍼즐_게임.Properties.Resources.Star;
            this.Enter_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Enter_btn.FlatAppearance.BorderSize = 0;
            this.Enter_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Enter_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Enter_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enter_btn.Location = new System.Drawing.Point(352, 30);
            this.Enter_btn.Name = "Enter_btn";
            this.Enter_btn.Size = new System.Drawing.Size(83, 73);
            this.Enter_btn.TabIndex = 0;
            this.Enter_btn.UseVisualStyleBackColor = false;
            this.Enter_btn.Click += new System.EventHandler(this.Enter_btn_Click);
            this.Enter_btn.MouseEnter += new System.EventHandler(this.Enter_btn_MouseEnter);
            this.Enter_btn.MouseLeave += new System.EventHandler(this.Enter_btn_MouseLeave);
            // 
            // Certification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(466, 215);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.result_la);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password_textBox);
            this.Controls.Add(this.ID_textBox);
            this.Controls.Add(this.Password_la);
            this.Controls.Add(this.ID_la);
            this.Controls.Add(this.Enter_btn);
            this.Name = "Certification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "본인인증";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Enter_btn;
        private System.Windows.Forms.Label ID_la;
        private System.Windows.Forms.Label Password_la;
        private System.Windows.Forms.TextBox ID_textBox;
        private System.Windows.Forms.TextBox Password_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label result_la;
        private System.Windows.Forms.Button close_btn;
    }
}