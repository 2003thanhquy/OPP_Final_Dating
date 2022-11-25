using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinder
{
    class ManageControl
    {
        public static List<User> users = new List<User>() {
            new User(0,"Admin",DateTime.Now,"","091",null,"","Male","admin@gmail.com","12345678","Female","Female",0),
            new User(1,"NguyenVanA",new DateTime(2003,10,20),"Viet Nam","091000",new List<string>(){"Music","Movie"},"Student",
                "Male","A@gmail.com","12345678","Female","Single",100
                ),
            new User(2,"NguyenThiB",new DateTime(2000,1,1),"HCM","09212",new List<string>(){"Music","Movie","Travel"},"manager","Female","B@gmail.com","12345678",
                "Male","Single",100),
        };
        public static List<Post> postAllUsers = new List<Post>();
       
        public static int[,] listBlockChatUsers = new int[100, 100];
        public static int id = 1;
        public static List<string> userHobbies = new List<string>()
            {
                "Music",
                "Language",
                "Travel",
                "Movie",
                "Shopping"
            };
        
    }
}
