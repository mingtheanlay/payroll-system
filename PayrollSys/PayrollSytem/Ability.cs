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
    // Strategy method
    public interface Ability
    {
        string Logout { get; set; }
        Image Img { get; set; }
        bool Employee { get; set; }
        bool Payroll { get; set; }
        bool User { get; set; }
        void permission();
    }

    public class AdminPermission : Ability
    {
        public string Logout { get; set; }
        public Image Img { get; set; }
        public bool Employee { get; set; }
        public bool Payroll { get; set; }
        public bool User { get; set; }
        public void permission()
        {
            this.Logout = "Logout";
            this.Img = PayrollSytem.Properties.Resources.logoutCLIP;
            this.Payroll = true;
            this.Employee = true;
            this.User = true;
        }
    }
    public class StaffPermission : Ability
    {
        public string Logout { get; set; }
        public Image Img { get; set; }
        public bool Employee { get; set; }
        public bool Payroll { get; set; }
        public bool User { get; set; }
        public void permission()
        {
            this.Logout = "Logout";
            this.Img = PayrollSytem.Properties.Resources.logoutCLIP;
            this.Payroll = true;
            this.Employee = true;
            this.User = false;
        }
    }
    public class GuestPermission : Ability
    {
        public string Logout { get; set; }
        public Image Img { get; set; }
        public bool Employee { get; set; }
        public bool Payroll { get; set; }
        public bool User { get; set; }
        public void permission()
        {
            this.Logout = "Logout";
            this.Img = PayrollSytem.Properties.Resources.logoutCLIP;
            this.Payroll = false;
            this.Employee = true;
            this.User = false;
        }
    }
}

