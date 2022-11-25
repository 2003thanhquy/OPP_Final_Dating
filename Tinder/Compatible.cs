using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Tinder
{
    public class Compatible
    {
        public List<User> disLike = new List<User> ();// nguoi  ban khong muon chon tim hieu 
        public List<User> likeYou = new List<User> ();// nhung nguoi muon tim hieu ban
        public User userDating; // nguoi dang hen ho voi ban
        public List<string> feedback = new List<string>();// feedback an danh
       
        List<User> userCompatibles = new List<User>(); // user phu hop khi may lua chon
        List<int> scoreCompatible = new List<int>();// so diem cua tung user 
        public Compatible() { }

         void FindListUserCompatible(User userCurrLogin)
        {
           /* userCompatibles.Clear ();
            scoreCompatible.Clear ();

            foreach (User usr in ManageControl.users)
            {
                if (usr == userCurrLogin) continue;
                if (usr.relationship == 0 && (userCurrLogin.orientationSexuelle == usr.gender) || (userCurrLogin.orientationSexuelle == 0))
                {
                    int scoreCp = 0;
                    for (int i = 0; i < userCurrLogin.hobbies.Count; i++)
                    {
                        if (userCurrLogin.hobbies[i] == usr.hobbies[i]) scoreCp += 10;
                        if (userCurrLogin.hobbies[i] == -usr.hobbies[i]) scoreCp -= 10;
                    }
                    scoreCp += usr.trustScore;
                    userCompatibles.Add(usr);
                    scoreCompatible.Add(scoreCp);
                }
            }
            //sort score/
            for (int i = 0; i < scoreCompatible.Count; i++)
            {
                for (int j = i + 1; j < scoreCompatible.Count; j++)
                {
                    if (scoreCompatible[i] < scoreCompatible[j])
                    {
                        int tmp = scoreCompatible[i];
                        scoreCompatible[i] = scoreCompatible[j];
                        scoreCompatible[j] = tmp;
                        User usr = userCompatibles[i];
                        userCompatibles[i] = userCompatibles[j];
                        userCompatibles[j] = usr;
                    }
                }
            }

*/
        

        }

        public void ChooseUserCompatible(User userCurrLogin)
        {

            /*if (userCurrLogin.relationship != 0) return;

            FindListUserCompatible(userCurrLogin);




            void ChooseLikeYou()
            {
                foreach(User usr in likeYou)
                {
                    
                    if(usr.relationship!=0 || disLike.Contains(usr))
                    {
                        likeYou.Remove(usr);
                        if (likeYou.Count == 0) return;
                        continue;
                    }
                    
                    int optionY;
                    do
                    {
                        Console.WriteLine("Username: " + usr.userName);
                        Console.WriteLine("1.Like\t2.Dislike\t3.Profile\t4.Show Feedback\t5.Next\t0.Exit");
                        optionY = int.Parse(Console.ReadLine());
                        switch (optionY)
                        {
                            case 1:
                                userDating = usr;
                                userCurrLogin.relationship = 1;//hen ho
                                usr.compatibleWithUser.userDating = userCurrLogin;
                                usr.relationship = 1;//hen ho;
                                Console.WriteLine("Choose user complete!");
                                return;
                                
                            case 2:
                                disLike.Add(usr);
                                break;
                            case 3:
                                usr.Display();
                                break;
                            case 4: 
                                foreach (string fb in usr.compatibleWithUser.feedback)
                                {
                                    Console.WriteLine(fb);

                                }
                                break;

                        }

                    } while (optionY != 0&&optionY!=5);
                    if(optionY==0) return;
                }
            }
            void ChooseFromSystem()
            {
                for(int i = 0; i < userCompatibles.Count; i++)
                {
                    if(userCompatibles[i].relationship != 0) continue;
                    int optionS;
                    do
                    {
                        Console.WriteLine("Username: " + userCompatibles[i].userName +
                            "\tScore Compatible: " + scoreCompatible[i]);
                        Console.WriteLine("1.Like\t2.Dislike\t3.Profile\t4.Show Feedback\t4.Next\t0.Exit");
                        optionS = int.Parse(Console.ReadLine());
                        switch (optionS)
                        {
                            case 1:
                                if (likeYou.Contains(userCompatibles[i]))
                                {
                                    userDating = userCompatibles[i];
                                    userCurrLogin.relationship = 1;//hen ho
                                    userCompatibles[i].compatibleWithUser.userDating = userCurrLogin;
                                    userCompatibles[i].relationship = 1;//hen ho;
                                    Console.WriteLine("Choose user complete!");
                                    return;
                                }
                                else
                                {
                                    if (!userCompatibles[i].compatibleWithUser.likeYou.Contains(userCurrLogin))
                                    {
                                        userCompatibles[i].compatibleWithUser.likeYou.Add(userCurrLogin);
                                    }
                                 
                                }

                                break;
                            case 2:
                                disLike.Add(userCompatibles[i]);
                                break;
                            case 3:
                                userCompatibles[i].Display();
                                break;
                            case 4:
                                foreach (string fb in userCompatibles[i].compatibleWithUser.feedback)
                                {
                                    Console.WriteLine(fb);

                                }
                                break;
                        }
                    } while (optionS ==3||optionS==4);
                    if (optionS == 0) break;
                }
            }
            int option; 
           do
            {
                Console.WriteLine("1.Choose in list Like you\n2.Choose from  System\t0.Exit");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        ChooseLikeYou();
                        break;
                    case 2:
                        ChooseFromSystem();
                        break;
                }
                if(userCurrLogin.relationship != 0)
                {
                    Console.WriteLine("Exit");
                    return;
                }
            }while(option!=0);*/
        } 
    }
}
