using DTypes;
namespace DTypes
{
    
    public enum Gender
    {
        M, F
    }
    [Flags]
    public enum SecurityLevel
    {
        guest = 8
        , developer = 4,
        secretary = 2,
        DBA = 1
    }
   
    public struct Employee:IComparable
    {
        int ID;
        SecurityLevel securityLvl = new SecurityLevel();
        double Salary;
        Gender gender;
        HDate hiringDate;
        String name;
        //setters

        public Employee(int id, double Salary, string security, string _gender, HDate date,String _name)
        {
            ID = id;
            securityLvl = (SecurityLevel)Enum.Parse(typeof(SecurityLevel), security, true);
            gender = (Gender)Enum.Parse(typeof(Gender), _gender, true);
            hiringDate = date;
            name = _name;
        }
        public Employee()
        {
            ID = -1;
        }
        /// <summary>
        /// property to set and get name
        /// </summary>
        public String Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        /// <summary>
        /// property to set and get id
        /// </summary>
        public int id
        {
            set
            {
                ID = value;
            }
            get
            {
                return ID;
            }
        }
        /// <summary>
        /// property to set and get salary
        /// </summary>
        public double salary
        {
            get
            {
                return Salary;
            }
            set
            {
                Salary = value;
            }
        }
        /// <summary>
        /// property to set and get security level
        /// </summary>
        public SecurityLevel Security
        {
            get
            {
                return securityLvl;
            }
            set
            {
                securityLvl = value;
            }
        }
        public static int boxing = 0;
        /// <summary>
        /// property to set and get hiring date
        /// </summary>
        public HDate Hiring_Date
        {
            set
            {
                hiringDate = value;
            }
            get
            {
                return hiringDate;
            }
        }
        /// <summary>
        /// property to set and get gender
        /// </summary>
        public Gender Gender
        {
            set
            {
                gender = value ;
            }
            get
            {
                return gender;
            }
        }
        /// <summary>
        /// Compares the current employee's hiring date with another employee's hiring date.
        /// </summary>
        /// <param name="obj">The object to compare, expected to be of type Employee.</param>
        /// <returns>
        /// A value less than zero if this employee's hiring date is earlier than the other employee's; 
        /// zero if the hiring dates are equal; a value greater than zero if this employee's hiring date 
        /// is later than the other employee's.
        /// </returns>
        /// <exception cref="ArgumentException">Thrown if the provided object is not of type Employee.</exception>

        public int CompareTo(object? obj)
        {
            boxing++;
            if (obj is Employee other)
            {
                return this.Hiring_Date.CompareTo(other.Hiring_Date);
            }
            throw new ArgumentException("This object is not Employee");
        }
        /// <summary>
        /// Converts the employee's data into a readable string representation.
        /// </summary>
        /// <returns>A string that contains the employee's details, including ID, name, security level, gender, salary, and hiring date.</returns>
        public override string ToString()
        {
            return string.Format("The Emplyee has id:{0}\nName:{1}\nSecurity Level he have " +
                "{2}\nGender {3}\nHis salary : {4:C}\nGet Hired in {5}\n", ID,name, securityLvl, gender, Salary, hiringDate);
        }
    }
}
