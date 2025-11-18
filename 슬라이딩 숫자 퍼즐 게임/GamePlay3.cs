using System;
using System.Windows.Forms;

namespace 슬라이딩_숫자_퍼즐_게임
{
    public partial class GamePlay3 : Form
    {
        private string result;      // 게임 결과 시간을 저장할 필드
        private GamePlay GP;

        public GamePlay3()
        {
            InitializeComponent();
            GP = new GamePlay("고수");
            GP.Timer.Tick += time;
        }
        private void time(object sender, EventArgs e)       // 시간을 측정하는 타이머 메소드
        {
            TimeSpan elapsed = GP.Stop.Elapsed;
            label1.Text = $"경과 시간: {elapsed.Minutes:D2}:{elapsed.Seconds:D2}";
            result = $"{elapsed.Minutes:D2}:{elapsed.Seconds:D2}";
        }

        private void Start_btn_Click(object sender, EventArgs e)        // 시작 버튼을 클릭하면 발생하는 이벤트 처리 메소드
        {
            if (GP.Start)       // 게임 시작 버튼을 눌렀다면 재클릭 방지
                return;
            GP.Mix(new Button[] { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11,
                button12, button13, button14, button15, button16,button17,button18,button19,button20,button21,button22,button23,button24,button25 });
            GP.Stop.Reset();        // 시간을 측정할 때 무조건 한 번 초기화 실행
            GP.Timer.Start();       // 타임 이벤트 시작
            GP.Stop.Start();        // 시간 측정 시작
        }

        private void isfinish()
        {
            if (GP.Start)    // 스타트 버튼을 누르고(시간을 측정하고) 게임을 시작한건지 확인
            {
                if (GP.isFinish(new Button[] { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14,
                    button15,button16,button17,button18,button19,button20,button21,button22,button23,button24 }))
                {
                    GP.Stop.Stop();     // 시간 측정 종료
                    GP.Timer.Stop();    // 이벤트 실행 종료
                    if (GP.isRank(result))        // 순위권에 들어가는지 검사
                    {
                        NewRank rn = new NewRank("고수");
                        rn.ShowDialog();
                        GP.User = rn.Result();
                        GP += result;
                    }
                    else MessageBox.Show("아쉽게도 랭킹 순위에 들지 못했습니다.");
                }
            }
            else MessageBox.Show("시작 버튼을 입력해주세요!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GP.Exchange(new Button[] { button1, button2, button6 });
            this.isfinish();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GP.Exchange(new Button[] { button2, button1, button3, button7 });
            this.isfinish();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GP.Exchange(new Button[] { button3, button2, button4, button8 });
            this.isfinish();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GP.Exchange(new Button[] { button4, button3, button5, button9 });
            this.isfinish();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GP.Exchange(new Button[] { button5, button4, button10 });
            this.isfinish();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GP.Exchange(new Button[] { button6, button1, button7, button11 });
            this.isfinish();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GP.Exchange(new Button[] { button7, button2, button6, button8, button12 });
            this.isfinish();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            GP.Exchange(new Button[] { button8, button3, button7, button9, button13 });
            this.isfinish();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            GP.Exchange(new Button[] { button9, button4, button8, button10, button14 });
            this.isfinish();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            GP.Exchange(new Button[] { button10, button5, button9, button15 });
            this.isfinish();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            GP.Exchange(new Button[] { button11, button6, button16, button12 });
            this.isfinish();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            GP.Exchange(new Button[] { button12, button7, button11, button13, button17 });
            this.isfinish();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            GP.Exchange(new Button[] { button13, button12, button14, button8, button18 });
            this.isfinish();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            GP.Exchange(new Button[] { button14, button9, button13, button15, button19 });
            this.isfinish();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            GP.Exchange(new Button[] { button15, button10, button14, button20 });
            this.isfinish();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            GP.Exchange(new Button[] { button16, button11, button17, button21 });
            this.isfinish();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            GP.Exchange(new Button[] { button17, button22, button16, button18, button12 });
            this.isfinish();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            GP.Exchange(new Button[] { button18, button13, button17, button19, button23 });
            this.isfinish();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            GP.Exchange(new Button[] { button19, button14, button18, button20, button24 });
            this.isfinish();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            GP.Exchange(new Button[] { button20, button15, button19, button25 });
            this.isfinish();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            GP.Exchange(new Button[] { button21, button16, button22 });
            this.isfinish();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            GP.Exchange(new Button[] { button22, button21, button23, button17 });
            this.isfinish();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            GP.Exchange(new Button[] { button23, button22, button24, button18 });
            this.isfinish();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            GP.Exchange(new Button[] { button24, button23, button25, button19 });
            this.isfinish();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            GP.Exchange(new Button[] { button25, button24, button20 });
            this.isfinish();
        }

        private void Start_btn_MouseEnter(object sender, EventArgs e)       // 마우스를 버튼에 올렸을 때
        {
            this.GP.Enter_Image(Start_btn);
        }

        private void Start_btn_MouseLeave(object sender, EventArgs e)      // 마우스를 버튼에서 떨어졌을 때
        {
            this.GP.Leave_Image(Start_btn);
        }

        private void rank_btn_Click(object sender, EventArgs e)
        {
            FRank fRank = new FRank("고수");
            fRank.Show();
        }
    }
}
