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
            switch (user)
            {
                case "Administrator":
                    Ability adminAbility = new AdminPermission();
                    adminAbility.permission();
                    tsLogin.Text = adminAbility.Logout;
                    tsLogin.Image = adminAbility.Img;
                    tsEmployee.Enabled = adminAbility.Employee;
                    tsPayroll.Enabled = adminAbility.Payroll;
                    tsUser.Enabled = adminAbility.User;
                    break;
                case "Staff":
                    Ability staffAbility = new StaffPermission();
                    staffAbility.permission();
                    tsLogin.Text = staffAbility.Logout;
                    tsLogin.Image = staffAbility.Img;
                    tsEmployee.Enabled = staffAbility.Employee;
                    tsPayroll.Enabled = staffAbility.Payroll;
                    tsUser.Enabled = staffAbility.User;
                    break;
                case "Guest":
                    Ability guestAbility = new GuestPermission();
                    guestAbility.permission();
                    tsLogin.Text = guestAbility.Logout;
                    tsLogin.Image = guestAbility.Img;
                    tsEmployee.Enabled = guestAbility.Employee;
                    tsPayroll.Enabled = guestAbility.Payroll;
                    tsUser.Enabled = guestAbility.User;
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
                tsLogin.Text = "Login";
                tsLogin.Image = PayrollSytem.Properties.Resources._lock;
                tsEmployee.Enabled = false;
                tsPayroll.Enabled = false;
                tsUser.Enabled = false;
                tsReport.Enabled = false;
            }
        }
    }
}
