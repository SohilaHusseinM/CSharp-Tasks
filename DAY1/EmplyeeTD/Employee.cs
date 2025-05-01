using DTypes;
namespace EmplyeeTD
{
    public enum Gender
    {
        M,F
    }
    [Flags]
    public enum SecurityLevel
    {
        guest=8
        ,Developer=4,
        secretary=2,
        DBA=1
    }
    public struct Employee
    {
        int ID;
        SecurityLevel securityLvl = new SecurityLevel();
        double salary;
        Gender gender;
        HDate hiringDate;
        //setters
        public Employee(int id,double salary , string security,string _gender,HDate date)
        {
            ID = id;
            securityLvl ^= (SecurityLevel)Enum.Parse(typeof(SecurityLevel), security, true);
            gender = (Gender)Enum.Parse(typeof(Gender), _gender, true); 
            hiringDate = date;
        }
        public Employee()
        {
            ID = -1;
        }

        public void setId(int id)
        {
            ID = id;
        }
        public void setSalary(double s)
        {
            salary = s;
        }
        public void setSecurity(string lvl)
        {
            securityLvl ^= (SecurityLevel)Enum.Parse(typeof(SecurityLevel), lvl, true);
        }
        public void sethiringDate(HDate _hiringDate)
        {
            hiringDate = _hiringDate;
        }
        public void setGender(string _gender)
        {
             gender = (Gender)Enum.Parse(typeof(Gender), _gender, true); ;
        }

        //getters
        public int getId() { return ID; }

        public SecurityLevel getsecurityLvl()
        {
            return securityLvl;
        }
        public double getSalary()
        {
            return salary;
        }
        public HDate gethiringDate()
        {
            return hiringDate;
        }
        public Gender getGender()
        {
            return gender;
        }
        public override string ToString()
        {
            return string.Format("The Emplyee has id:{0}\nSecurity Level he have" +
                "{1}\nGender {2}\nHis salary {3}\nGet Hired in {4}\n", ID, securityLvl, gender, salary, hiringDate);
        }
    }
}
