using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinder
{
    class ExternalInterface
    {
        public  ExternalInterface() { }

        public static User LogIn(string email, string password)
        {
            User CheckInfo()
            {
                foreach(User usr in ManageControl.users)
                {
           
                    if(email == usr.email&& password == usr.password)
                    {
                        return usr;
                    }
                }
                return null;
            }
            User isCheck = CheckInfo();
            if(isCheck != null)
            {
                return isCheck;
            }
            return null;

        }
       
        public static  bool FogetPass(string email, string phoneNumber , string password)
        {
            User CheckInfo()
            {
                foreach(User usr in ManageControl.users)
                {
                    if(email == usr.email && phoneNumber == usr.PhoneNumber)
                    {
                        return usr;
                    }
                }
                return null;
            }
            void UpdatePassword(User usr)
            {
                        usr.password = password;   
            }

            User isCheck = CheckInfo();
            if (isCheck!=null)
            {
                UpdatePassword(isCheck);
                return true;
            }
            return false ;
        }
        public static void CreateNewAccount( string userName, DateTime dayOfDate, string address, string phoneNumber
            , List<string> hobbies, string job, string gender, string email, string password, string orientationSexuelle, string relationship)
        {
            ManageControl.users.Add(new User(ManageControl.id,userName,dayOfDate,address,phoneNumber,hobbies,job,gender,email,password,orientationSexuelle
                ,relationship,100));
            ManageControl.id+=1;
        }
    }
}
