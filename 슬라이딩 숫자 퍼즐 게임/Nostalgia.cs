using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace 슬라이딩_숫자_퍼즐_게임
{
    public class Rank    // 게임 순위 데이터와 파일처리하는 클래스 
    {
        public KeyValuePair<string, string> User { get; set; }                                    // key = 닉네임, value = 비밀번호
        private Dictionary<string, string> Rank_info = new Dictionary<string, string>();           // key = 시간, value = 닉네임
        private Dictionary<string, string> Rank_user = new Dictionary<string, string>();          // key = 닉네임, value = 비밀번호
        private string Fname;

        public Rank(string level)    // 레벨 정보가 매개변수인 생성자
        {
            try
            {
                Fname = level + ".txt";  // 파일 이름 저장

                if (File.Exists(Fname) == false)       // 파일 없으면 만들기
                {
                    FileStream fs = new FileStream(Fname, FileMode.Create);
                    fs.Close();
                }
                else                                   // 있으면 데이터 저장
                {
                    StreamReader sr = new StreamReader(new FileStream(Fname, FileMode.Open));
                    while (sr.EndOfStream == false)
                    {
                        string data = sr.ReadLine();
                        if (data == null) break;
                        string[] item = data.Split(',');     // 파일에는 순위, 닉네임, 시간, 비밀번호 순으로 저장되어 있다.

                        Rank_info.Add(item[2], item[1]);     // key = 시간, value = 닉네임으로 정보 저장
                        Rank_user.Add(item[1], item[3]);     // key = 닉네임, value = 패스워드으로 정보 저장
                    }
                    sr.Close();
                }
            } catch (Exception E) { MessageBox.Show(E.Message);   Process.GetCurrentProcess().Kill(); }
        }

        public bool isRank(string time)        // 랭킹순위에 들어가는지 확인
        {
            List<string> key = this.Rank_info.Keys.ToList();      // key = 시간

            if (key.Count < 5)                   // 데이터가 5개 미만일 경우는 무조건 순위권에 들어간다. (1~5등까지 등록 가능)
                return true;
            if (key.Contains(time))              // 기존 랭킹에 있는 기록과 같은 기록이라면 랭킹 순위에 등록하지 않는다.
                return false;
            else
            {
                bool flag = false;

                foreach (string k in key)
                {
                    int what = string.Compare(k, time);    // 신규 시간이 랭킹 기록보다 작거나 같으면 -1 또는 0 반환 
                    flag = what >= 0 ? true : flag;
                }
                return flag;
            }
        }

        public bool isOverlap(string name)  // 닉네임이 중복되는지 확인하는 메소드
        {
            bool flag = false;

            foreach (string k in Rank_user.Keys)
                flag = k == name ? true : flag;

            return flag;
        }

        private void sort()  // 랭킹 정렬
        {
            Dictionary<string, string> tmp = new Dictionary<string, string>();

            List<string> key = this.Rank_info.Keys.ToList();     // key = 시간.
            key.Sort();   // 오름차순으로 정렬

            if (key.Count > 5)                   // 5등까지 등록하기위해 5개 초과하는지 확인
                key.RemoveAt(key.Count - 1);     // 마지막 요소 삭제(data를 1개만 넣었기 때문에 1개 삭제)

            foreach (var k in key)
                tmp.Add(k, this.Rank_info[k]);   // 정렬된 값을 tmp에 저장

            this.Rank_info = tmp;
        }

        protected void score(string time)   //랭킹에 새로운 기록 등록
        {
            this.Rank_info.Add(time, User.Key);           // key = 시간, value = 닉네임
            this.Rank_user.Add(User.Key, User.Value);     // kye = 닉네임, value = 비밀번호
            this.writeToFile();
        }

        private void writeToFile()  // 파일에 랭킹 데이터를 기록
        {
            this.sort();    // 데이터 정렬
            try
            {
                int r = 1;     // 1등~5등을 입력하기위한 변수

                StreamWriter sw = new StreamWriter(new FileStream(Fname, FileMode.Create));                  // 기존 파일에 덮어써서 새로운 데이터만 저장된다.

                foreach (var key in Rank_info.Keys)
                    sw.WriteLine("{0},{1},{2},{3}", r++, Rank_info[key], key, Rank_user[Rank_info[key]]);   // 순위, 닉네임, 시간, 비밀번호
                              
                sw.Close();
            }
            catch (Exception E) { MessageBox.Show(E.Message); }
        }

        public bool isRight(string inputId, string inputps) // 본인 인증 확인
        {
                return Rank_user[inputId] == inputps;    
             //key = 닉네임인데 key에 해당하는 닉네임이 입력받은 비밀번호가 일치한지 검사 후 결과 반환
         }

        protected void remove()     // 랭킹 삭제
        {
            string findKey = Rank_info.FirstOrDefault(x => x.Value == User.Key).Key;
                    // Rank_info의 value가 user의 키와 같다 ( Ranke_info.value = 닉네임,  user.key = 닉네임 )

            if (this.isRight(User.Key, User.Value))     // 본인이 맞다면 기록 삭제
            {
                this.Rank_info.Remove(findKey);
                this.writeToFile();
            }
        }
        public static Rank operator --(Rank rank)       // 단항 연산자 -- 재정의
        {
            rank.remove();
            return rank;
        }
    }

    public abstract class GameEvent : Rank              // 게임에 필요한 이벤트 관련 추상 메소드 제공하는 담당(인터페이스 대신 사용)
    {
        private PictureBox pb = new PictureBox();       // 윈폼 이미지를 컨트롤하기 위한 필드

        public GameEvent(string level) : base(level) { } 

        public abstract void Exchange(Button[] btn);      // 버튼의 텍스트를 서로 교환하기 위한 시그니처를 제공하는 추상 메소드

        public abstract bool isFinish(Button[] lst);      // 퍼즐이 완성됐는지 검사하기 위한 시그니처를 제공하는 추상 메소드
        public abstract void Mix(Button[] buttons);       // 퍼즐을 랜덤으로 섞기 위한 시그니처를 제공하는 추상 메소드

        protected Image IMG(Image img)                  // 원하는 이미지를 크기에 맞게 세팅해주는 메소드
        {
            this.pb.Image = img;
            this.pb.SizeMode = PictureBoxSizeMode.StretchImage;
            return img;
        }
    }

    public class GamePlay : GameEvent      // 게임 플레이에 필요한 이벤트들을 정의하고 랭킹 클래스의 파일 처리를 위해 상속받은 클래스
    {
        public Timer Timer { get; set; }
        public Stopwatch Stop { get; set; }
        public bool Start { get; set; }


        public GamePlay(string level) : base(level)  // 게임 세팅 초기화
        {
            Start = false;

            Timer = new Timer();
            Timer.Interval = 1000;      // 1초 간격으로 이벤트 실행

            Stop = new Stopwatch();
        }

        override public bool isFinish(Button[] lst)    // 퍼즐이 완성됐는지 확인하는 함수
        {
            for (int i = 0; i < lst.Length; i++)
            {
                if (lst[i].Text != (i + 1).ToString())
                    return false;
            }
            return true;
        }

        override public void Exchange(Button[] btn)          // 주변에 공백 버튼이 있을 경우 공백 버튼과 자기 자신 숫자를 서로 교환(버튼 클릭 이벤트에 넣을 메소드) 
        {
            for (int i = 1; i < btn.Length; i++)             // btn[0]은 현재 버튼
            {
                if (btn[i].Text == "")
                {
                    btn[i].Text = btn[0].Text;
                    btn[0].Text = "";
                }
            }
        }

        public void Exchange(Button cur, Button btn1, Button btn2)      // Exchange 메소드 중복으로 방향이 2개인 경우
        { 
            if (btn1.Text == "")
            {
                btn1.Text = cur.Text;
                cur.Text = "";
            }
            if(btn2.Text =="")
            {
                btn2.Text=cur.Text;
                cur.Text = "";
            }
        }
        public void Exchange(Button cur, Button btn1, Button btn2,Button btn3)     // Exchange 메소드 중복으로 방향이 3개인 경우
        {
            if (btn1.Text == "")
            {
                btn1.Text = cur.Text;
                cur.Text = "";
            }
            if (btn2.Text == "")
            {
                btn2.Text = cur.Text;
                cur.Text = "";
            }
            if(btn3.Text =="")
            {
                btn3.Text = cur.Text;
                cur.Text = "";
            }
        }

        public void Exchange(Button cur, Button btn1, Button btn2, Button btn3,Button btn4)      // Exchange 메소드 중복으로 방향이 4개인 경우
        {
            if (btn1.Text == "")
            {
                btn1.Text = cur.Text;
                cur.Text = "";
            }
            if (btn2.Text == "")
            {
                btn2.Text = cur.Text;
                cur.Text = "";
            }
            if (btn3.Text == "")
            {
                btn3.Text = cur.Text;
                cur.Text = "";
            }
            if(btn4.Text=="")
            {
                btn4.Text = cur.Text;
                cur.Text = "";
            }
        }


        override public void Mix(Button[] buttons)   // 퍼즐들을 랜덤하게 섞어줄 메소드(게임 시작 버튼 클릭 이벤트에 넣을 메소드)
        {
            List<int> list = new List<int>();
            Random random = new Random();
                                                                        
            for (int i = 1; i <= buttons.Length - 1; i++) // 리스트에 1부터 버튼의 마지막 개수 - 1만큼 순차적으로 입력
                list.Add(i);

            int index = 0;
            while (list.Count > 0)  // 리스트에서 중복 없이 난수를 발생하여 마지막 버튼 빼고 입력
            {
                int LIndex = random.Next(0, list.Count);
                buttons[index++].Text = list[LIndex].ToString();
                list.RemoveAt(LIndex);
            }

            buttons[buttons.Length - 1].Text = "";  // 마지막 버튼은 공백
            this.Start = true;
        }

        public void Enter_Image(Button btn)      // 게임 시작 버튼 마우스 오버시 이미지 세팅
        {
            btn.BackgroundImage= IMG(Properties.Resources.DropStar);
        }

        public void Leave_Image(Button btn)      // 게임 시작 버튼 마우스 오버 후 다시 내릴 때 원래 이미지로 세팅
        {
            btn.BackgroundImage= IMG(Properties.Resources.Star);
        }

        public static GamePlay operator +(GamePlay GP, string time)   // 랭킹 기록을 추가해주는 연산자 중복 메소드
        {
            GP.score(time);
            return GP;
        }
    }
}
