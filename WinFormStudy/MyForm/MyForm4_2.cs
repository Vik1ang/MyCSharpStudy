using System.Windows.Forms;

namespace WinFormStudy.MyForm
{
    public partial class MyForm4_2 : Form
    {
        public MyForm4_2()
        {
            InitializeComponent();

            testButton.Click += OnTest;
        }

        public void OnTest(object sender, System.EventArgs e)
        {
            MessageBox.Show("你好");
        }
    }
}