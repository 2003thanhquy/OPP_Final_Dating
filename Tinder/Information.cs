using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinder
{

    public class Information
    {
        public int id;
        public string userName;
        public DateTime dayOfDate;
        public string address;
        public string phoneNumber;
        public List<string> hobbies;
        public string job;
        public string gender;
        public string email;
        public string password;
        public string orientationSexuelle;
        public string relationship;
        public int trustScore;
        
        public Information(int id, string userName, DateTime dayOfDate, string address, string phoneNumber, List<string> hobbies, string job, string gender, string email, string password, string orientationSexuelle,string relationship, int trustScore)
        {
            this.id = id;
            this.userName = userName;
            this.dayOfDate = dayOfDate;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.hobbies = hobbies;
            this.job = job;
            this.gender = gender;
            this.email = email;
            this.password = password;
            this.orientationSexuelle = orientationSexuelle;
            this.relationship = relationship;
            this.trustScore = trustScore;
        }

        public void Display()
        {
            



        }
    }
}
