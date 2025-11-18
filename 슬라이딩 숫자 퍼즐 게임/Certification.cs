using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace 슬라이딩_숫자_퍼즐_게임
{
    public partial class Certification : Form 
    {
        Rank rank;
        string id;
        string levelinfo;
        private PictureBox pb;

        public Certification()
        {
            InitializeComponent();
            pb = new PictureBox();
        }
        public void getvalue(string username,string level)     // 닉네임과 난이도 정보를 주고 받는 메소드
        {
            this.rank = new Rank(level);
            this.id = username;
            this.levelinfo = level;
            ID_textBox.Text = this.id;
        }

        private void Enter_btn_Click(object sender, EventArgs e)        // 별 모양 버튼 클릭하면 발생하는 이벤트
        {
            rank.User = new KeyValuePair<string, string>(this.id, this.Password_textBox.Text);
             // 입력한 닉네임과 비밀번호를 저장한다.

            if (rank.isRight(this.id, this.Password_textBox.Text))      // 닉네임과 비밀번호가 일치한지 검사한다.
            {
                result_la.Text = "반갑습니다." + this.id + "님";
                DialogResult WantRemove = MessageBox.Show("기록을 삭제하시겠습니까?", this.id + "님", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (WantRemove == DialogResult.Yes)
                {
                    --rank;
                    this.Close();
                    FRank fRank = new FRank(levelinfo);
                    fRank.Show();
                }
            }
            else
                result_la.Text = "본인이 아닙니다.";
        }

        private void close_btn_Click(object sender, EventArgs e)        // "닫기" 버튼 클릭 시 해당 폼 닫기
        {
            this.Close();
        }

        private void Enter_btn_MouseEnter(object sender, EventArgs e)   // 별 모양 버튼에 마우스를 올렸을 때 다른 이미지로 변하는 이벤트 메소드
        {
            pb.Image = Properties.Resources.SmileStar;
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            Enter_btn.BackgroundImage = pb.Image;
        }

        private void Enter_btn_MouseLeave(object sender, EventArgs e)       // 별 모양 버튼에 마우스를 내렸을 때 원래 이미지로 변하는 이벤트 메소드
        {
            pb.Image = Properties.Resources.Star;
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            Enter_btn.BackgroundImage = pb.Image;
        }
    }
}
