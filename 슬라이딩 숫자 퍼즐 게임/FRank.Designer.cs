namespace 슬라이딩_숫자_퍼즐_게임
{
    partial class FRank
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
            this.Close_btn = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.Rank_list = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // Close_btn
            // 
            this.Close_btn.BackColor = System.Drawing.Color.Transparent;
            this.Close_btn.BackgroundImage = global::슬라이딩_숫자_퍼즐_게임.Properties.Resources.Star;
            this.Close_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Close_btn.FlatAppearance.BorderSize = 0;
            this.Close_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Close_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_btn.Location = new System.Drawing.Point(534, 337);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(55, 55);
            this.Close_btn.TabIndex = 7;
            this.Close_btn.TabStop = false;
            this.Close_btn.UseVisualStyleBackColor = false;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            this.Close_btn.MouseEnter += new System.EventHandler(this.Close_btn_MouseEnter);
            this.Close_btn.MouseLeave += new System.EventHandler(this.Close_btn_MouseLeave);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("휴먼편지체", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(224, 49);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(192, 38);
            this.title.TabIndex = 6;
            this.title.Text = "난이도별 랭킹";
            // 
            // Rank_list
            // 
            this.Rank_list.BackColor = System.Drawing.Color.White;
            this.Rank_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.Rank_list.Font = new System.Drawing.Font("휴먼편지체", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Rank_list.ForeColor = System.Drawing.Color.Black;
            this.Rank_list.FullRowSelect = true;
            this.Rank_list.GridLines = true;
            this.Rank_list.HideSelection = false;
            this.Rank_list.Location = new System.Drawing.Point(106, 113);
            this.Rank_list.Name = "Rank_list";
            this.Rank_list.Scrollable = false;
            this.Rank_list.Size = new System.Drawing.Size(375, 242);
            this.Rank_list.TabIndex = 5;
            this.Rank_list.UseCompatibleStateImageBehavior = false;
            this.Rank_list.View = System.Windows.Forms.View.Details;
            this.Rank_list.SelectedIndexChanged += new System.EventHandler(this.Rank_list_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "순위";
            this.columnHeader1.Width = 62;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "닉네임";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 135;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "시 간";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 174;
            // 
            // FRank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::슬라이딩_숫자_퍼즐_게임.Properties.Resources.SimpleSpace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(601, 404);
            this.Controls.Add(this.Close_btn);
            this.Controls.Add(this.title);
            this.Controls.Add(this.Rank_list);
            this.DoubleBuffered = true;
            this.Name = "FRank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "랭킹순위";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Close_btn;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.ListView Rank_list;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}