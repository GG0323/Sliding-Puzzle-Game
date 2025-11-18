using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace 슬라이딩_숫자_퍼즐_게임
{
    public partial class GamePlay2 : Form
    {
        private string result;
        private GamePlay GP;

        public GamePlay2()
        {
            InitializeComponent();
            GP = new GamePlay("중수");
            GP.Timer.Tick += time;
        }
        private void time(object sender, EventArgs e)   // 타임 이벤트
        {
            TimeSpan elapsed = GP.Stop.Elapsed;
            label1.Text = $"경과 시간: {elapsed.Minutes:D2}:{elapsed.Seconds:D2}";
            result = $"{elapsed.Minutes:D2}:{elapsed.Seconds:D2}";
        }

        private void Start_btn_Click(object sender, EventArgs e)
        {
            if (GP.Start)
                return;
            GP.Mix(new Button[] { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12,
                button13, button14, button15, button16 });
            GP.Stop.Reset();        // 시간을 측정할 때 무조건 한 번 초기화 실행
            GP.Timer.Start();       // 타임 이벤트 시작
            GP.Stop.Start();        // 시간 측정 시작
        }

        private void isfinish()
        {
            if (GP.Start)   // 스타트 버튼을 누르고(시간을 측정하고) 게임을 시작한건지 확인
            {
                if (GP.isFinish(new Button[] { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15 }))
                {
                    GP.Stop.Stop();
                    GP.Timer.Stop();
                    if (GP.isRank(result))       // 순위권에 들어가는지 검사
                    {
                        NewRank rn = new NewRank("중수");
                        rn.ShowDialog();
                        GP.User = rn.Result();
                        GP += result;
                    }
                    else MessageBox.Show("아쉽게도 랭킹 순위에 들지 못했습니다.");
                    GP.Start=false;
                }
            }
            else MessageBox.Show("시작 버튼을 입력해주세요!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GP.Exchange(new Button[] {button1,button2,button5});
            this.isfinish();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GP.Exchange(new Button[] { button2, button1, button3, button6 });
            this.isfinish();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GP.Exchange(new Button[] { button3, button2, button4, button7 });
            this.isfinish();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GP.Exchange(new Button[] { button4, button3, button8 });
            this.isfinish();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GP.Exchange(new Button[] { button5, button1, button6, button9 });
            this.isfinish();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GP.Exchange(new Button[] { button6, button2, button5, button7, button10 });
            this.isfinish();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GP.Exchange(new Button[] { button7, button3, button6, button8, button11 });
            this.isfinish();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            GP.Exchange(new Button[] { button8, button4, button7, button12 });
            this.isfinish();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            GP.Exchange(new Button[] { button9, button5, button10, button13 });
            this.isfinish();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            GP.Exchange(new Button[] { button10, button9, button6, button14, button11 });
            this.isfinish();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            GP.Exchange(new Button[] { button11, button7, button10, button12, button15 });
            this.isfinish();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            GP.Exchange(new Button[] { button12,button16, button8, button11 });
            this.isfinish();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            GP.Exchange(new Button[] { button13, button9,button14 });
            this.isfinish();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            GP.Exchange(new Button[] { button14, button10, button13, button15 });
            this.isfinish();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            GP.Exchange(new Button[] { button15, button16, button14, button11 });
            this.isfinish();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            GP.Exchange(new Button[] { button16, button12, button15 });
            this.isfinish();
        }

        private void Start_btn_MouseEnter(object sender, EventArgs e)
        {
            this.GP.Enter_Image(Start_btn);
        }

        private void Start_btn_MouseLeave(object sender, EventArgs e)
        {
            this.GP.Leave_Image(Start_btn);
        }

        private void rank_btn_Click(object sender, EventArgs e)
        {
            FRank fRank = new FRank("중수");
            fRank.Show();
        }
    }
}
