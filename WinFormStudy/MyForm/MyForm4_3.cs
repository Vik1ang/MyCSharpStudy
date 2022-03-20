using System;
using System.Windows.Forms;

namespace WinFormStudy.MyForm
{
    public partial class MyForm4_3 : Form
    {
        public MyForm4_3()
        {
            InitializeComponent();
        }

        private void OnButtonClick(object sender, EventArgs e)
        {
            string timeStr = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            timeField.Text = timeStr;
        }
    }
}