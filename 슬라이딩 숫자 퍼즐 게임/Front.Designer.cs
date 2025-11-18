namespace 슬라이딩_숫자_퍼즐_게임
{
    partial class Front
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
            this.Start_btn = new System.Windows.Forms.Button();
            this.Rank_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Level = new System.Windows.Forms.ComboBox();
            this.Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Start_btn
            // 
            this.Start_btn.BackColor = System.Drawing.Color.Transparent;
            this.Start_btn.BackgroundImage = global::슬라이딩_숫자_퍼즐_게임.Properties.Resources.Cloud;
            this.Start_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Start_btn.FlatAppearance.BorderSize = 0;
            this.Start_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Start_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Start_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start_btn.Font = new System.Drawing.Font("휴먼편지체", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Start_btn.Location = new System.Drawing.Point(323, 149);
            this.Start_btn.Name = "Start_btn";
            this.Start_btn.Size = new System.Drawing.Size(150, 110);
            this.Start_btn.TabIndex = 10;
            this.Start_btn.Text = "\r\n게임 시작";
            this.Start_btn.UseVisualStyleBackColor = false;
            this.Start_btn.Click += new System.EventHandler(this.Start_btn_Click);
            this.Start_btn.MouseEnter += new System.EventHandler(this.Start_btn_MouseEnter);
            this.Start_btn.MouseLeave += new System.EventHandler(this.Start_btn_MouseLeave);
            // 
            // Rank_btn
            // 
            this.Rank_btn.BackColor = System.Drawing.Color.Transparent;
            this.Rank_btn.BackgroundImage = global::슬라이딩_숫자_퍼즐_게임.Properties.Resources.Cloud;
            this.Rank_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Rank_btn.Cursor = System.Windows.Forms.Cursors.Default;
            this.Rank_btn.FlatAppearance.BorderSize = 0;
            this.Rank_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Rank_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Rank_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rank_btn.Font = new System.Drawing.Font("휴먼편지체", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Rank_btn.Location = new System.Drawing.Point(134, 149);
            this.Rank_btn.Name = "Rank_btn";
            this.Rank_btn.Size = new System.Drawing.Size(150, 110);
            this.Rank_btn.TabIndex = 9;
            this.Rank_btn.Text = "\r\n랭킹 보기";
            this.Rank_btn.UseVisualStyleBackColor = false;
            this.Rank_btn.Click += new System.EventHandler(this.Rank_btn_Click);
            this.Rank_btn.MouseEnter += new System.EventHandler(this.Rank_btn_MouseEnter);
            this.Rank_btn.MouseLeave += new System.EventHandler(this.Rank_btn_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(151, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "난이도 선택";
            // 
            // Level
            // 
            this.Level.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Level.FormattingEnabled = true;
            this.Level.Items.AddRange(new object[] {
            "초보",
            "중수",
            "고수"});
            this.Level.Location = new System.Drawing.Point(289, 112);
            this.Level.Name = "Level";
            this.Level.Size = new System.Drawing.Size(80, 27);
            this.Level.TabIndex = 7;
            this.Level.Text = "초보";
            this.Level.SelectedIndexChanged += new System.EventHandler(this.Level_SelectedIndexChanged);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("휴먼편지체", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Title.Location = new System.Drawing.Point(203, 41);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(176, 31);
            this.Title.TabIndex = 6;
            this.Title.Text = "숫자 게임 퍼즐";
            // 
            // Front
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::슬라이딩_숫자_퍼즐_게임.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(574, 271);
            this.Controls.Add(this.Start_btn);
            this.Controls.Add(this.Rank_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Level);
            this.Controls.Add(this.Title);
            this.Name = "Front";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Front";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start_btn;
        private System.Windows.Forms.Button Rank_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Level;
        private System.Windows.Forms.Label Title;
    }
}

