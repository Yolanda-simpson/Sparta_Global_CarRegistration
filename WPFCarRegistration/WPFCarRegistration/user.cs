using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WPFCarRegistration
{
    public class User
    {
        string name;
        public string Name { get => name; set => name = value; }
        string address;
        public string Address { get => address; set => address = value; }
        public int hireDate;
        public int Hiredate { get => hireDate; set => hireDate = value; }
        string gender;
        public string Gender { get => gender; set => gender = value; }
        string phoneNumber;
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        string picturePath;
        public string PicturePath { get => picturePath; set => picturePath = value; }
        string duration;
        public string Duration { get => duration; set => duration = value; }
        string[] carType = new string[3];
        public string[] CarType { get => carType; set => carType = value; }
        public User()
        {

        }
        public User(string n, string p, int d, string g, string phone, string pic, string dr, string[] ct)
        {
            name = n;
            address = p;
            hireDate = d;
            gender = g;
            PhoneNumber = phone;
            picturePath = pic;
            duration = dr;
            carType = ct;




        }


        public void saveData()
        {
            using (StreamWriter sw = File.AppendText("userData.csv"))
            {



                string eachItem = "";

                foreach (var item in carType)
                {
                    eachItem += "-" + item;
                }
                sw.WriteLine(name + "," + address + "," + hireDate + "," + gender + "," + phoneNumber + "," + picturePath + "," + duration + "," + eachItem);
            }

        }
    }
}
