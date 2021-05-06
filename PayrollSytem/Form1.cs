using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PayrollSytem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void enable_menu(string user)
        {
            Ability ability;
            switch (user)
            {
                case "Administrator":
                    ability = new AdminPermission();
                    ability.permission();
                    tsLogin.Text = ability.Status;
                    tsLogin.Image = ability.Img;
                    tsEmployee.Enabled = ability.Employee;
                    tsPayroll.Enabled = ability.Payroll;
                    tsUser.Enabled = ability.User;
                    break;
                case "Staff":
                    ability = new StaffPermission();
                    ability.permission();
                    tsLogin.Text = ability.Status;
                    tsLogin.Image = ability.Img;
                    tsEmployee.Enabled = ability.Employee;
                    tsPayroll.Enabled = ability.Payroll;
                    tsUser.Enabled = ability.User;
                    break;
                case "Guest":
                    ability = new GuestPermission();
                    ability.permission();
                    tsLogin.Text = ability.Status;
                    tsLogin.Image = ability.Img;
                    tsEmployee.Enabled = ability.Employee;
                    tsPayroll.Enabled = ability.Payroll;
                    tsUser.Enabled = ability.User;
                    break;
                default:
                    ability = new NoPermission();
                    ability.permission();
                    tsLogin.Text = ability.Status;
                    tsLogin.Image = ability.Img;
                    tsEmployee.Enabled = ability.Employee;
                    tsPayroll.Enabled = ability.Payroll;
                    tsUser.Enabled = ability.User;
                    break;
            }
        }
         
        private void Form1_Load(object sender, EventArgs e)
        {

        }

         

        private void closeChildForm()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
        }

        private void showFrm(Form frm)
        {
            this.IsMdiContainer = true;
            frm.MdiParent = this;
            frm.Show();
        }

        private void tsEmployee_Click(object sender, EventArgs e)
        {
            closeChildForm();
            showFrm(new frm_Employees());
        }

        private void tsPayroll_Click(object sender, EventArgs e)
        {
            closeChildForm();
            showFrm(new frm_Payroll());
        }

        private void tsUser_Click(object sender, EventArgs e)
        {
            closeChildForm();
            showFrm(new frm_user());
        }

        private void tsLogin_Click(object sender, EventArgs e)
        {
            if (tsLogin.Text == "Login")
            {
                closeChildForm();
                showFrm(new frm_login(this));
            }
            else
            {
                Ability noPermission = new NoPermission();
                noPermission.permission();
                tsLogin.Text = noPermission.Status;
                tsLogin.Image = noPermission.Img;
                tsEmployee.Enabled = noPermission.Employee;
                tsPayroll.Enabled = noPermission.Payroll;
                tsUser.Enabled = noPermission.User;
            }
        }
    }
}
