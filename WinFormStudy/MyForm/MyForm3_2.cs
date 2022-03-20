using System.Drawing;
using System.Windows.Forms;

namespace WinFormStudy.MyForm
{
    public partial class MyForm3_2 : Form
    {
        private Button testButton = new Button();

        public MyForm3_2()
        {
            InitializeComponent();

            Controls.Add(testButton);
            testButton.Text = "我的测试按钮";
            testButton.Location = new Point(40, 40);
            testButton.Size = new Size(100, 40);
        }
    }
}