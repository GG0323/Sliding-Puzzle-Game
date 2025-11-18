using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace 슬라이딩_숫자_퍼즐_게임
{
    public partial class NewRank : Form
    {
        string name, pass;
        Rank rank;
        private PictureBox pb;
        public NewRank(string fname)
        {
            InitializeComponent();
            pb = new PictureBox();
            rank = new Rank(fname);
        }

        public KeyValuePair<string, string> Result()    // 여기서 입력한 닉네임과 비밀번호를 넘겨주는 메소드
        {
                return new KeyValuePair<string, string>(name, pass);
        }


        private void NewRank_Load(object sender, EventArgs e)       // 이 폼이 생성될 때 발생하는 이벤트 메소드
        {
            MessageBox.Show("축하합니다! 랭커입니다!");
        }

        private void Enter_btn_MouseEnter(object sender, EventArgs e)       // 별 모양 버튼에 마우스 올렸을 때 발생하는 이벤트
        {
            pb.Image = Properties.Resources.SmileStar;
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            Enter_btn.BackgroundImage = pb.Image;
        }

        private void Enter_btn_MouseLeave(object sender, EventArgs e)       // 별 모양 버튼에 마우스 내렸을 때 발생하는 이벤트
        {
            pb.Image = Properties.Resources.Star;
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            Enter_btn.BackgroundImage = pb.Image;
        }

        private void Enter_btn_Click(object sender, EventArgs e)        // 별 모양 버튼을 클릭 시 발생하는 이벤트
        {
            try
            {
                if (ID_textBox.Text == "" || Password_textBox.Text == "")        // 닉네임 또는 비밀번호가 입력되지 않았는데 별 모양 버튼을 클릭 한 경우 
                {
                    MessageBox.Show("닉네임 또는 비밀번호를 입력하지 않았습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (rank.isOverlap(ID_textBox.Text))        // 기존 랭킹 파일에 입력한 닉네임이 존재하여 중복되는 경우
                    MessageBox.Show("이미 존재하는 닉네임 입니다. 다른 닉네임을 입력해주세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    name = ID_textBox.Text;
                    pass = Password_textBox.Text;
                    MessageBox.Show("랭킹에 등록되었습니다:) \n다시한번 축하드립니다!!");
                }
            }catch (Exception E) { MessageBox.Show(E.Message); }
        }

        private void close_btn_Click(object sender, EventArgs e)    // "닫기" 버튼 클릭 시 발생하는 이벤트
        {
            if (name == null || pass == null)  // 아무것도 입력하지 않은 상태에서는 창을 못닫게 처리
                MessageBox.Show("닉네임 또는 비밀번호를 입력하지 않았습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                this.Close();
        }
    }
}
