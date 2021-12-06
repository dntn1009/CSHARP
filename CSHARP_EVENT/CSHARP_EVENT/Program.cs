using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace CSHARP_EVENT
{
    static class Program
    {
        //객체도 static으로
        static Form form = null;
       static Button button = null;

        static void OnClickEvent(object sender, EventArgs e)
        {
            MessageBox.Show("안녕하세요. SBS게임 아카데미 입니다.");
        }//이벤트 만들기
        static void MakeWindow()
        {
            form = new Form();//객체 생성
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Height = 400;
            form.Width = 400;
            form.BackColor = Color.White;

        }
        static void MakeButton()
        {
          button = new Button();
            button.Width = 150;
            button.Height = 50;
            button.Text = "클릭";
            button.Location = new Point((form.Width - button.Width)/2, (form.Height - button.Height)/2);
            button.Click += OnClickEvent;//이벤트 추가
            form.Controls.Add(button);
           

        }
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /* Application.EnableVisualStyles();
             Application.SetCompatibleTextRenderingDefault(false);
             Application.Run(new Form1());*/
            //이거 안쓰고 코드로 만들어볼 예정.
            MakeWindow();
            MakeButton();
            form.ShowDialog();
        }
    }
}
