using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using LINQtoCSV;

namespace Tinder
{
   public class User:Information
    {
        public List<Post> listPosts = new List<Post>();
        public List<Chat> listChats = new List<Chat>();
        public List<User> listFollowUsers = new List<User>();
        public List<User> listBlockPostUsers = new List<User>();
        public List<User> listFlagChat = new List<User>();

        public Compatible compatibleWithUser = new Compatible();
    
        public User(int id, string userName, DateTime dayOfDate, string address, string phoneNumber, List<string> hobbies, string job, string gender, string email, string password,string orientationSexuelle,string relationship, int trustScore)
           : base(id, userName, dayOfDate, address, phoneNumber, hobbies, job, gender, email, password, orientationSexuelle,relationship, trustScore)
        {

        }
        public int ID { get { return id; }set { id = value; } }
        public string UserName { get { return userName; } set { userName = value; } }   
        public DateTime DayOfDate { get { return dayOfDate; } set {dayOfDate = value; } }   
        public string Address { get { return address; } set { address = value; } }  
        public string PhoneNumber { get { return phoneNumber; } set { phoneNumber = value; } }
        public List<string> Hobbies { get { return hobbies; } set { hobbies = value; } }
        public string Job { get { return job; } set { job = value; } }
        public string Gender { get { return gender; } set { gender = value; } }    
        public string Email { get { return email; } set { email = value; } }    
        public string Password { get { return password; } set { password = value; } }   
        public string OrientationSexuelle { get { return orientationSexuelle; } set { orientationSexuelle = value; } }
        public string Relationship { get { return relationship; } set { relationship = value; } }
        public int TrustScore { get { return trustScore; } set { trustScore = value; } }

        public void Post(User userCurrLogin)
        {
            int optionPost;
            do
            {
                Console.WriteLine("1.Create Post\t2.See posts user follow \t3.see posts all users\t\t4.Check Personal Post\t" +
                    "5.Check Personal Post(have new comment)\t0.Exit Post");
                optionPost = int.Parse(Console.ReadLine());
                switch (optionPost)
                {
                    case 1:
                        Console.WriteLine("Enter content post");
                        string content = Console.ReadLine();
                        listPosts.Add(new Post(userCurrLogin, content));
                        ManageControl.postAllUsers.Add(new Post(userCurrLogin, content));
                        break;
                    case 2:
                        if(listFollowUsers.Count == 0)
                        {
                            Console.WriteLine("Follow =null");
                            continue;
                        }
                        foreach (Post postUser in ManageControl.postAllUsers)
                        {
                            (listFollowUsers, listBlockPostUsers) = postUser.ShowPost(1, listFollowUsers, listBlockPostUsers, userCurrLogin);
                            break;
                        }     
                        break;
                    case 3:
                        foreach (Post postUser in ManageControl.postAllUsers)
                        {
                            (listFollowUsers, listBlockPostUsers) = postUser.ShowPost(2, listFollowUsers, listBlockPostUsers, userCurrLogin);
                            break;
                        }
                        break;
                    case 4:
                        foreach (Post postUser in ManageControl.postAllUsers)
                            postUser.CheckPersonalPost(userCurrLogin,1);
                        break;
                    case 5:
                        foreach (Post postUser in ManageControl.postAllUsers)
                            postUser.CheckPersonalPost(userCurrLogin, 2);
                        
                        break;
                    case 0:
                        break;
                }
            } while (optionPost != 0);
            Console.WriteLine("Exit Post Ok");
        }

        public void Chat(User userCurrLogin)
        {

                Console.WriteLine("=====================Account: " + userCurrLogin.userName + "======================");
                foreach (User usr in ManageControl.users)
                {
                    if (usr != userCurrLogin)
                    {
                        Console.WriteLine("Id: " + usr.id + "\t" + "userName: " + usr.UserName);

                        if (listFlagChat.Contains(usr))
                        {
                            Console.WriteLine("Have message");
                        }
                        Console.WriteLine("1.Chat \t2.Next \t0.Exit Chat");// 0: 
                        int optionChat = int.Parse(Console.ReadLine());
                        if (optionChat == 1)
                        {
                        int i;
                              for( i = 0; i < listChats.Count; i++)
                                {
                                if (listChats[i].userChat == usr)
                                    {
                                        listChats[i].ChatWithUser(userCurrLogin, usr);
                                        break;
                                    }
                                }
                              if(i== listChats.Count)
                                {
                                    listChats.Add(new Chat(usr));
                                    listChats[i].ChatWithUser(userCurrLogin, usr);
                                }
                        
                        }
                        if (optionChat == 0) break;
                }
            }
        }
        
        public void Compatible(User userCurrLogin)
        {
           /* if (userCurrLogin.relationship != 0) return;
            int option;
            do
            {
                Console.WriteLine("1.Choose User Compatible \t 0.Exit");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        compatibleWithUser.ChooseUserCompatible(userCurrLogin);
                        break;
                    case 0:
                        return;

                }
            } while (true);*/
        }

        public void DatingObject(User userCurrLogin)
        {
           /* if (userCurrLogin.relationship == 0)
            {
                Console.WriteLine("You are single");
                return;
            }
            do
            {
                Console.WriteLine("1.Chat \t2.huy hen ho\t0.Exit");
                int option = int.Parse(Console.ReadLine());
               
                switch (option)
                {
                    case 1:
                        int i;
                        for (i = 0; i < listChats.Count; i++)
                        {
                            if (listChats[i].userChat == userCurrLogin.compatibleWithUser.userDating)
                            {
                                listChats[i].ChatWithUser(userCurrLogin, userCurrLogin.compatibleWithUser.userDating);
                                break;
                            }
                        }
                        if (i == listChats.Count)
                        {
                            listChats.Add(new Chat(userCurrLogin.compatibleWithUser.userDating));
                            listChats[i].ChatWithUser(userCurrLogin, userCurrLogin.compatibleWithUser.userDating);
                        }
                        break;
                    case 2:
                        userCurrLogin.relationship = 0;
                        userCurrLogin.compatibleWithUser.userDating.relationship = 0;
                        
                        Console.WriteLine("Huy  hen ho thanh cong");
                        Console.WriteLine("Do you  want feedback?(1.Yes,2.No)");
                        int optionFb = int.Parse(Console.ReadLine());
                        if (optionFb == 2)
                        {
                            userCurrLogin.compatibleWithUser.userDating.compatibleWithUser.userDating = null;
                            userCurrLogin.compatibleWithUser.userDating = null;
                            return;
                        }
                        Console.WriteLine("1.Feedback good \t 2.FeedBack bad");
                        optionFb = int.Parse(Console.ReadLine());
                        if (optionFb == 1) userCurrLogin.compatibleWithUser.userDating.trustScore += 1;
                        else userCurrLogin.compatibleWithUser.userDating.trustScore -= 1;
                        userCurrLogin.compatibleWithUser.userDating.compatibleWithUser.feedback.Add(Console.ReadLine());
                        userCurrLogin.compatibleWithUser.userDating.compatibleWithUser.userDating = null;
                        userCurrLogin.compatibleWithUser.userDating = null;
                        return;
                    case 0:
                        return;
                }
            } while (true);*/
        }
    }
}
