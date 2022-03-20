using System.Drawing;
using System.Windows.Forms;

namespace WinFormStudy.MyForm
{
    public partial class MyForm5_2 : Form
    {
        public MyForm5_2()
        {
            InitializeComponent();
            textBox1.AutoSize = false;
        }

        protected override void OnLayout(LayoutEventArgs levent)
        {
            // 1. 调用父类的 OnLayout
            base.OnLayout(levent);

            // 2. 获取窗口大小
            int w = ClientSize.Width;
            int h = ClientSize.Height;

            // 3. 计算每一个控件的位置和大小
            int yOff = 0;

            yOff = 4;
            textBox1.Location = new Point(0, yOff);
            textBox1.Size = new Size(w - 80, 30);
            button1.Location = new Point(w - 80, yOff);
            button1.Size = new Size(80, 30);

            yOff += 30; // 第一行的高度
            yOff += 4; // 间隔

            pictureBox1.Location = new Point(0, yOff);
            pictureBox1.Size = new Size(w, h - yOff - 4);
        }
    }
}