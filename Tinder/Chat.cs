using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinder
{
    public class ContentChat
    {
        public string content;
        public DateTime chatTime;
        public ContentChat(string content, DateTime chatTime)
        {
            this.content = content;
            this.chatTime = chatTime;
        }
    }
    public class Chat
    {
        public User userChat;
        public List<ContentChat> contentChatUser = new List<ContentChat>();
        public Chat(User userChat)
        {
            this.userChat = userChat;
        }
        public Chat() { }

        public void ChatWithUser(User userCurrLogin, User objectChat)
        {
           
            string CheckBlockChatUser(int idA, int idB)
            {
                string block = "Block";
                if (ManageControl.listBlockChatUsers[idB, idA] == 1)
                    block = "locked from the enemy";
                if (ManageControl.listBlockChatUsers[idA, idB] == 1)
                    block = "Blocked to you";
                return block;
            }
            void BlockChatUser(int idA, int idB)
            {
                if (ManageControl.listBlockChatUsers[idA, idB] == 1)
                    ManageControl.listBlockChatUsers[idA, idB] = 0;
                else ManageControl.listBlockChatUsers[idA, idB] = 1;
            }
            int option;// 1: chat //0 exit // 2: seen
            do
            {
                //Console.Clear();
                Console.WriteLine("=====================Account: " + userCurrLogin.userName + "======================");
                Console.WriteLine("===============================Chat: " + objectChat.userName+"============================");
                DisplayContentChat(userCurrLogin, objectChat);// tim noi dung chat cua doi tuong chat 

                string block = CheckBlockChatUser(userCurrLogin.id, objectChat.id);


                Console.WriteLine($"1:Chat\t2.Seen\t3.{block}\t0:Exit");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 0:
                        break;
                    case 1:
                        if (ManageControl.listBlockChatUsers[userCurrLogin.id, objectChat.id] == 1 || ManageControl.listBlockChatUsers[objectChat.id, userCurrLogin.id] == 1)
                        {
                            Console.WriteLine("Currently locked(enter)");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Enter content:");
                            string content = Console.ReadLine();
                            contentChatUser.Add(new ContentChat(content, DateTime.Now));
                            objectChat.listFlagChat.Add(userCurrLogin);
                            userCurrLogin.listFlagChat.Remove(objectChat);
                          
                        }



                        break;
                    case 2:
                        userCurrLogin.listFlagChat.Remove(objectChat);
                        break;
                    case 3:
                        BlockChatUser(userCurrLogin.id, objectChat.id);
                        break;
                }



            } while (option != 0);
            
            

        }

        void ShowMess(string userNameA, List<ContentChat> contentA, string userNameB, List<ContentChat> contentB)
        {
            int i = 0, j = 0;

            while (i < contentA.Count)
            {
                Console.WriteLine($"{userNameA}: {contentA[i].content}\t{contentA[i].chatTime}");
                i++;
                while (i < contentA.Count && j < contentB.Count && contentB[j].chatTime < contentA[i].chatTime)
                {
                    Console.WriteLine($"\t\t{userNameB}: {contentB[j].content}\t{contentB[j].chatTime}");
                    j++;
                }
            }
            while (j < contentB.Count)
            {
                Console.WriteLine($"\t\t{userNameB}: {contentB[j].content}\t{contentB[j].chatTime}");
                j++;

            }


        }
        public void DisplayContentChat(User userCurrLogin, User objectChat)
        {
            
            Chat contentChatA = null;// content Chat B ->A
            var findCurrInObj = from chatt in objectChat.listChats
                                where chatt.userChat == userCurrLogin
                                select chatt;
            if (findCurrInObj.Count() != 0) contentChatA = findCurrInObj.ToList()[0];
            if (contentChatA == null) // chua co content chat 
            {
                
                foreach (ContentChat ctChat in contentChatUser)
                {
                    Console.WriteLine(userCurrLogin.userName + ": " + ctChat.content + "\t" + ctChat.chatTime);
                }
                return;
            }
            if (this.contentChatUser.Count == 0)
            { 
                ShowMess(userCurrLogin.userName, contentChatUser, objectChat.userName, contentChatA.contentChatUser);
            }
            else
            {

                if (contentChatUser.Count == 0)
                {

                    ShowMess(userCurrLogin.userName, contentChatUser, objectChat.userName, contentChatA.contentChatUser);
                    return;
                }
                if (contentChatUser[0].chatTime < contentChatA.contentChatUser[0].chatTime)
                    ShowMess(userCurrLogin.userName, contentChatUser, objectChat.userName, contentChatA.contentChatUser);
                else
                    ShowMess(objectChat.userName, contentChatA.contentChatUser, userCurrLogin.userName, contentChatUser);
            }

        }
    }
}
