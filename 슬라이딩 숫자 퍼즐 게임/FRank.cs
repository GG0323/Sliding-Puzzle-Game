using System;
using System.Drawing;
using System.IO;

using System.Windows.Forms;

namespace 슬라이딩_숫자_퍼즐_게임
{
    public partial class FRank : Form
    {
        private string username;
        private string level;
        private PictureBox pb;
        public FRank(string level)      // 레벨 정보를 받아 해당 레벨 랭킹 파일 데이터를 읽어오는 생성자
        {
            InitializeComponent();

            pb = new PictureBox();
            title.Text = level + " 랭킹";
            this.level = level;

            try
            {
                if (File.Exists(level+".txt") == false)
                {
                    FileStream fs = new FileStream(level+".txt", FileMode.Create);
                    fs.Close();
                }
                else
                {
                    StreamReader sr = new StreamReader(new FileStream(level+".txt", FileMode.Open));
                    while (sr.EndOfStream == false)
                    {
                        string data = sr.ReadLine();
                        if (data == null) break;
                        string[] item = data.Split(',');
                        ListViewItem List_item = new ListViewItem(item);
                        Rank_list.Items.Add(List_item);
                        Rank_list.EndUpdate();
                    }
                    sr.Close();
                }
            } catch (Exception E) { MessageBox.Show(E.Message + "\nErr"); }
        }

        private void Close_btn_Click(object sender, EventArgs e)    // "닫기" 버튼 클릭 시 발생하는 이벤트
        {
            this.Close();
        }

        private void Close_btn_MouseEnter(object sender, EventArgs e)   // "닫기"버튼에 마우스 올릴 경우의 이벤트
        {
            pb.Image = Properties.Resources.DropStar;
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            Close_btn.BackgroundImage = pb.Image;
        }

        private void Close_btn_MouseLeave(object sender, EventArgs e)   // "닫기"버튼에 마우스 내렸을 경우의 이벤트
        {
            pb.Image = Properties.Resources.Star;
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            Close_btn.BackgroundImage = pb.Image;
        }

        private void Rank_list_SelectedIndexChanged(object sender, EventArgs e)    // 리스트 뷰에서 랭킹 데이터를 선택하면 발생하는 이벤트
        {
            if (Rank_list.SelectedItems.Count > 0)
            { 
                username = Rank_list.SelectedItems[0].SubItems[1].Text;
                try
                {
                    Certification cf = new Certification();    // 본인 인증을 요청하는 폼 생성
                    cf.getvalue(username, level);
                    cf.Show();
                    this.Close();
                }catch (Exception E) { MessageBox.Show(E.Message); }
            }
        }
    }
}
