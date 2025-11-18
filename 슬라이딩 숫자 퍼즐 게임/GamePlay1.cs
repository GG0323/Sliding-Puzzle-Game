using System;
using System.Windows.Forms;

namespace 슬라이딩_숫자_퍼즐_게임
{
    public partial class GamePlay1 : Form
    {
        private string result;
        private GamePlay GP;

        public GamePlay1()
        {
            InitializeComponent();
            GP = new GamePlay("초보");
            GP.Timer.Tick += time;
        }

        private void time(object sender, EventArgs e)       // 타이머 이벤트
        {
            TimeSpan elapsed = GP.Stop.Elapsed;     // 경과되고있는 시간을 저장
            label1.Text = $"경과 시간: {elapsed.Minutes:D2}:{elapsed.Seconds:D2}";      // 경과된 시간을 출력
            result = $"{elapsed.Minutes:D2}:{elapsed.Seconds:D2}";    // 경과된 시간을 저장
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GP.Exchange( button1, button2, button4 );                            // 방향이 2개인 경우
            this.isfinish();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GP.Exchange( button2, button1, button3, button5 );                   // 방향이 3개인 경우
            this.isfinish();    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GP.Exchange(new Button[] { button3, button2, button6 });             // 배열로 넘기는 경우
            this.isfinish();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GP.Exchange(button4, button1, button5, button7);
            this.isfinish();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GP.Exchange(button5, button2, button4, button6, button8);         // 방향이 4개인 경우
            this.isfinish();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GP.Exchange( button6, button3, button5, button9 );
            this.isfinish();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GP.Exchange(button7, button4, button8);
            this.isfinish();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            GP.Exchange(button8, button5, button7, button9);
            this.isfinish();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            GP.Exchange(button9, button6, button8);
            this.isfinish();
        }
        private void isfinish()     // 퍼즐이 완성됐는지 파악 후 데이터 처리해주는 메소드
        {
            if (GP.Start)    // 스타트 버튼을 누르고(시간을 측정하고) 게임을 시작한건지 확인
            {
                if (GP.isFinish(new Button[8] { button1, button2, button3, button4, button5, button6, button7, button8 }))
                {
                    GP.Stop.Stop();              // 스톱워치 멈춤
                    GP.Timer.Stop();             // 타임 이벤트 멈춤
                    if (GP.isRank(result))       // 순위권에 들어가는지 검사
                    {
                        NewRank rn = new NewRank("초보");
                        rn.ShowDialog();
                        GP.User = rn.Result();
                        GP += result;                        
                    }
                    else MessageBox.Show("아쉽게도 랭킹 순위에 들지 못했습니다.");
                    GP.Start = false;
                }
            }
            else MessageBox.Show("시작 버튼을 입력해주세요!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void showRank_btn_Click(object sender, EventArgs e)     // 초보 레벨의 랭킹 정보를 보여주는 폼 호출
        {
            FRank fRank = new FRank("초보");
            fRank.Show();
        }

        private void Start_btn_Click(object sender, EventArgs e)        // 게임 시작 버튼 클릭 시 발생하는 이벤트
        {
            if (GP.Start)        // 시작 버튼 중복 클릭 방지
                return;
            GP.Mix(new Button[9] { button1, button2, button3, button4, button5, button6, button7, button8, button9 });
            GP.Stop.Reset();        // 시간을 측정할 때 무조건 한 번 초기화 실행
            GP.Timer.Start();       // 타임 이벤트 시작
            GP.Stop.Start();        // 시간 측정 시작
        }

        private void start_btn_MouseEnter(object sender, EventArgs e)     // 별 모양 start 버튼에 마우스 올렸을 때 발생하는 이벤트 메소드
        { 
            this.GP.Enter_Image(Start_btn);
        }

        private void start_btn_MouseLeave(object sender, EventArgs e)     // 별 모양 start 버튼에 마우스 내렸을 때 발생하는 이벤트 메소드
        {
            this.GP.Leave_Image(Start_btn);
        }

        private void Test_btn_Click(object sender, EventArgs e)
        {
            Button[] btn = new Button[] { button1,button2}; 
        }
    }
}
