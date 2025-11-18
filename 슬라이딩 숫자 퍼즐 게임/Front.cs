using System;
using System.Drawing;
using System.Windows.Forms;


namespace 슬라이딩_숫자_퍼즐_게임
{
    public partial class Front : Form
    {
        private string Levelinfo;  // 난이도 정보 저장
        private PictureBox pb;     // 이미지 제어하기 위해 존재

        public Front()
        {
            InitializeComponent();
            pb = new PictureBox();
            Levelinfo = "초보";     // 처음 레벨 정보는 초보
        }

        private void Start_btn_Click(object sender, EventArgs e)      // 게임 시작 버튼 클릭 시
        {
            switch (Levelinfo)      // 레벨 정보 별로 실행할 폼을 분류
            {
                case "초보":
                    GamePlay1 form = new GamePlay1();
                    form.ShowDialog();
                    break;

                case "중수":
                    GamePlay2 form2 = new GamePlay2();
                    form2.ShowDialog();
                    break;

                case "고수":
                    GamePlay3 form4 = new GamePlay3();
                    form4.ShowDialog();
                    break;

                default:
                    MessageBox.Show("에러가 발생했습니다. 다시 실행해주세요.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void Level_SelectedIndexChanged(object sender, EventArgs e)   
        {
            Levelinfo = Level.SelectedItem.ToString();  // 콤보박스에서 난이도를 선택할 때마다 난이도 정보 저장
        }

        private void Rank_btn_Click(object sender, EventArgs e)
        {
            FRank fRank = new FRank(Levelinfo);     // 선택한 난이도 랭킹 정보 form 생성
            fRank.Show();
        }

        private Image Button_Enter_Image()          // 마우스 오버 시 바뀔 이미지 메소드
        {
            pb.Image = Properties.Resources.blueCloud;
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            return pb.Image;
        }

        private Image Button_Leave_Image()       // 버튼에 마우스 올렸다가 내렸을 때 원래 이미지로 세팅하는 메소드
        {
            pb.Image = Properties.Resources.Cloud;
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            return pb.Image;
        }

        private void Start_btn_MouseEnter(object sender, EventArgs e)     // "게임 시작"버튼에 마우스 올릴 경우의 이벤트
        {
            this.Start_btn.BackColor =  Color.Transparent;
            Start_btn.BackgroundImage = this.Button_Enter_Image();
        }

        private void Start_btn_MouseLeave(object sender, EventArgs e)     // "게임 시작"버튼에 마우스 내렸을 경우의 이벤트
        {
            Start_btn.BackgroundImage = this.Button_Leave_Image();
        }

        private void Rank_btn_MouseEnter(object sender, EventArgs e)      // "랭킹 보기"버튼에 마우스 올릴 경우의 이벤트
        {
            this.Rank_btn.BackColor = Color.Transparent;
            Rank_btn.BackgroundImage = this.Button_Enter_Image();
        }

        private void Rank_btn_MouseLeave(object sender, EventArgs e)      // "랭킹 보기"버튼에 마우스 내렸을 경우의 이벤트
        {
            Rank_btn.BackgroundImage = this.Button_Leave_Image();
        }
    }
}
