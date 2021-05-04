using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSytem
{
    // Factory Design Pattern
    public abstract class Employee
    {
        public abstract string EmpCode { set; get; }
        public abstract string FirstName { set; get; }
        public abstract string MiddleName { set; get; }
        public abstract string LastName { set; get; }
        public abstract string Address { set; get; }
        public abstract string Contact { set; get; }
        public abstract string Status { set; get; }
        public abstract string BirthPlace { set; get; }
        public abstract string Age { set; get; }
        public abstract string Emergency { set; get; }
        public abstract string DailyRate { set; get; }
        public abstract string Position { set; get; }
        public abstract string Sex { set; get; }
        public abstract string Dob { set; get; }
        public abstract string PaymentMethod { set; get; }
        public abstract string WorkStatus { set; get; }
        public abstract string DateHired { set; get; }
    }
    public class GeneralEmployee : Employee
    {
        string empCode;
        string firstName;
        string mName;
        string lastName;
        string address;
        string contact;
        string status;
        string birthPlace;
        string age;
        string emergency;
        string dailyRate;
        string position;
        string sex;
        string dob;
        string paymentMethod;
        string workStatus;
        string dateHired;
        public GeneralEmployee(string code, string fname, string mname, string lname,
            string add, string contact, string status, string birthplace, string age, string emergency,
            string dRate, string position, string sex, string dob, string paymentMethod, string workStatus, string dateHired)
        {
            this.empCode = code;
            this.firstName = fname;
            this.mName = mname;
            this.lastName = lname;
            this.address = add;
            this.contact = contact;
            this.status = status;
            this.birthPlace = birthplace;
            this.age = age;
            this.emergency = emergency;
            this.dailyRate = dRate;
            this.position = position;
            this.sex = sex;
            this.dob = dob;
            this.paymentMethod = paymentMethod;
            this.workStatus = workStatus;
            this.dateHired = dateHired;
        }

        public override string EmpCode { get { return this.empCode; } set { this.empCode = value; } }
        public override string FirstName { get { return this.firstName; } set { this.firstName = value; } }
        public override string MiddleName { get { return this.mName; } set { this.mName = value; } }
        public override string LastName { get { return this.lastName; } set { this.lastName = value;  } }
        public override string Address { get { return this.address; } set { this.address = value;  } }
        public override string Contact { get { return this.contact; } set { this.contact = value; } }
        public override string Status { get { return this.status; } set { this.status = value;  } }
        public override string BirthPlace { get { return this.birthPlace; } set { this.birthPlace = value;  } }
        public override string Age { get { return this.age; } set { this.age = value;  } }
        public override string Emergency { get { return this.emergency; } set { this.emergency = value;  } }
        public override string DailyRate { get { return this.dailyRate; } set { this.dailyRate = value;  } }
        public override string Position { get { return this.position; } set { this.position = value;  } }
        public override string Sex { get { return this.sex; } set { this.position = value;  } }
        public override string Dob { get { return this.dob; } set { this.position = value;  } }
        public override string PaymentMethod { get { return this.paymentMethod; } set { this.position = value;  } }
        public override string WorkStatus { get { return this.workStatus; } set { this.position = value;  } }
        public override string DateHired { get { return this.dateHired; } set { this.position = value;  } }
    }
    public abstract class EmployeeFactory
    {
        public abstract Employee GetEmployee();
    }
    public class GeneralEmployeeFactory : EmployeeFactory
    {
        string empCode;
        string firstName;
        string mName;
        string lastName;
        string address;
        string contact;
        string status;
        string birthPlace;
        string age;
        string emergency;
        string dailyRate;
        string position;
        string sex;
        string dob;
        string paymentMethod;
        string workStatus;
        string dateHired;
        public GeneralEmployeeFactory(string code, string fname, string mname, string lname,
            string add, string contact, string status, string birthplace, string age, string emergency,
            string dRate, string position, string sex, string dob, string paymentMethod, string workStatus, string dateHired)
        {
            this.empCode = code;
            this.firstName = fname;
            this.mName = mname;
            this.lastName = lname;
            this.address = add;
            this.contact = contact;
            this.status = status;
            this.birthPlace = birthplace;
            this.age = age;
            this.emergency = emergency;
            this.dailyRate = dRate;
            this.position = position;
            this.sex = sex;
            this.dob = dob;
            this.paymentMethod = paymentMethod;
            this.workStatus = workStatus;
            this.dateHired = dateHired;
        }
        public override Employee GetEmployee()
        {
            return new GeneralEmployee(empCode, firstName, mName, lastName,
             address, contact,  status, birthPlace,  age, emergency,
             dailyRate,  position, sex, dob, paymentMethod, workStatus, dateHired);
        }
    }
}
