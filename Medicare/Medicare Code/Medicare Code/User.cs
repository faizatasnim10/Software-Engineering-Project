using System;

namespace Medicare
{
    class User
    {
        private string UserName = null;
        private int UserPassword;
        private string UserAdress;
        private int UserPhonenum;
        private string Email;
        public bool Check_Ambulance_schedule()
        {
            return true;
        }
        public bool Check_Ambulance_Availability()
        {
            return true;
        }
        public bool Check_Test()
        {
            return true;
        }
        public bool Check_Medicine()
        {
            return true;
        }

        public void create_profie(string UserName, int UserPassword,string UserAdress,int UserPhonenum,
        string Email)
        {
            this.UserName = UserName;
            this.UserPassword = UserPassword;
            this.UserAdress= UserAdress;
            this.UserPhonenum=UserPhonenum;
            this.Email=Email;
        }
        public string userName
        {
            set { UserName = value; }
            get { return UserName; }
        }
        public int userPassword
        {
            set { UserPassword = value; }
            get { return UserPassword; }
        }
        public string userAdress
        {
            set { UserAdress = value; }
            get { return UserAdress; }
        }
        public int userPhonenum
        {
            set { UserPhonenum = value; }
            get { return UserPhonenum; }
        }
        public string email
        {
            set { Email = value; }
            get { return Email; }
        }
        public void login(string UserName, int UserPassword)
        {

        }
        public void Showinfo()
        {
            Console.WriteLine("===================");
            Console.WriteLine("User Name: {0} \nID: {1} \nUser Password: {2} \nUser Adress: {3} \nUser Phonenum{4} \n Email {5} ", UserName,UserPassword,UserAdress, UserPhonenum,Email);
        }
        static void Main(string[] args)
        {
            User u = new User();
            Console.Write("Enter your name : ");
            u.userName = Convert.ToString(Console.ReadLine());
            Console.Write("Enter your Password : ");
            u.userPassword = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your Adress : ");
            u.UserAdress = Convert.ToString(Console.ReadLine());
            Console.Write("Enter your Phone Number : ");
            u.userPhonenum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your Email : ");
            u.Email = Convert.ToString(Console.ReadLine());

            u.Showinfo();

        }
    }
}
