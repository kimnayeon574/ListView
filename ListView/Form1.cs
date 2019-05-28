using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ListView
{
    public partial class Form1 : Form
    {
        string strName;
        string strAge;
        string strWork;

        public Form1()
        {
            InitializeComponent();
        }
        
        private bool TextCheck()
        {
            if(this.txtName.Text == "")
            {
                MessageBox.Show("이름을 입력하세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtName.Focus();
                return false;
            }
            if(this.txtAge.Text == "")
            {
                MessageBox.Show("나이를 입력하세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtAge.Focus();
                return false;
            }
            if (this.txtWork.Text == "")
            {
                MessageBox.Show("직업을 입력하세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtWork.Focus();
                return false;
            }
        }
    }
}
