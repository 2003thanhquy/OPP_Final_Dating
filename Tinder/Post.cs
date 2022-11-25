using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Tinder
{
    public class Post
    {
        User userPost;
        string content;
        int numberOfLikes = 0;
        public bool flag = false;
        List<User> userLikes = new List<User>();
        List<Post> comment = new List<Post>();
        
        public List<User> listFollowUsers = new List<User>();
        public List<User> listBlockPostUsers = new List<User>();
        public Post(User userPost, string content)
        {
            this.userPost = userPost;
            this.content = content;

        }
        void CommentPost(Post pst)
        {
            Console.WriteLine($"Post: {pst.userPost.UserName}: {pst.content}");
            foreach (Post cmt in pst.comment)
            {
                Console.WriteLine("\t" + cmt.userPost.UserName + ": " + cmt.content);
            }
        }
        public (List<User>, List<User>) ShowPost(int check,List<User> listFollowUsers, List<User> listBlockPostUser,User userCurrLogin)
        {
            foreach (Post pst in ManageControl.postAllUsers)
            {
                if (userCurrLogin == pst.userPost) continue;
                
                if(check == 1)
                {
                    if (!listFollowUsers.Contains(pst.userPost)) continue;
                }
                if (listBlockPostUser.Contains((pst.userPost))) continue;
                CommentPost(pst);
                int option;
                do
                {
                    string like = "Like";
                    if (pst.userLikes.Contains(userCurrLogin))
                    {
                        like = "Liked";
                    }
                    string follow = listFollowUsers.Contains(pst.userPost) ? "Followed" : "Follow";
                    Console.WriteLine($"1.{like}:{pst.numberOfLikes}\t2.Comment\t3.Next post \t4.{follow}\t5.Block\t0.Exit");
                    option = int.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            if (like == "Like")
                            {
                                pst.numberOfLikes += 1;
                                pst.userLikes.Add(userCurrLogin);
                            }
                            else
                            {
                                pst.numberOfLikes -= 1;
                                pst.userLikes.Remove(userCurrLogin);
                            }

                            break;
                        case 2:
                            Console.WriteLine("Enter content");
                            string cmt = Console.ReadLine();
                            pst.comment.Add(new Post(userCurrLogin, cmt));
                            pst.flag = true;    
                            CommentPost(pst);
                            break;
                        case 4:
                            if (pst.userPost == userCurrLogin) continue;
                            if (listFollowUsers.Contains(pst.userPost))
                            {
                                listFollowUsers.Remove(pst.userPost);
                            }
                            else { listFollowUsers.Add(pst.userPost); }
                            break;
                        case 5:
                            if (pst.userPost == userCurrLogin) continue;
                            listBlockPostUsers.Add(pst.userPost);
                            listFollowUsers.Remove(pst.userPost);
                            break;
                    }


                } while (option == 1 || option == 2 || option == 4);

                if (option == 0) break;
            }

                return (listFollowUsers, listBlockPostUsers);   
        }
        public void CheckPersonalPost(User userCurrLogin,int flg)
        {
            List<Post> postUserCurrLogin = (from pst in ManageControl.postAllUsers
                                           where (pst.userPost == userCurrLogin)
                                           select pst).ToList();
             foreach(Post pst in postUserCurrLogin)
            {
                if (flg == 2)
                {
                    if (!pst.flag) continue;
                }
                int option;
               
                do
                {
                    CommentPost(pst);
                    Console.WriteLine("Number like: " + pst.numberOfLikes + "\t1.comment\t2.next\t 0.Exit");
                    option = int.Parse(Console.ReadLine());

                    if (option == 2 || option == 0) break;
                    Console.WriteLine("Enter Content");
                    comment.Add(new Post(userPost, Console.ReadLine()));
                } while (true);
                if (option == 0) break;
            }                          

           


            



        }


    }
}
