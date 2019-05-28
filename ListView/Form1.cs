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
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (TextCheck())
            {
                this.strName = this.txtName.Text;
                this.strAge = this.txtAge.Text;
                this.strWork = this.txtWork.Text;

                ListViewItem lvi = new ListViewItem(
                        new string[] {this.strName, this.strAge, this.strWork});
                this.lvView.Items.Add(lvi);
                this.txtName.Text = "";
                this.txtAge.Text = "";
                this.txtWork.Text = "";
                this.txtName.Focus();
            }
        }

        private void lvView_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = lvView.SelectedItems[0];
            string name = lvi.SubItems[0].Text;
            string age = lvi.SubItems[1].Text;
            string work = lvi.SubItems[2].Text;
            MessageBox.Show("이름 : " + name + "\n나이: " + age + "\n직업 : " + work, "정보", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
