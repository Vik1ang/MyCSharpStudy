using System.Windows.Forms;

namespace WinFormStudy.MyForm
{
    public partial class MyForm4_1 : Form
    {
        public MyForm4_1()
        {
            InitializeComponent();
        }

        private void OnTestClick(object sender, System.EventArgs e)
        {
            MessageBox.Show("Hello world");
        }
    }
}