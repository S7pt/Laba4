using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace _4._1.models
{
    public class Student
    {
        private string lastName;
        private string group;
        private int year;
        private string address;
        private int passportId;
        private int age;
        private int telephoneNumber;
        private int rating;
        public Student() { }

        public void setRating(int rating)
        {
            this.rating = rating;
        }

        public int getRating()
        {
            return this.rating;
        }
        public int Year { get => year; set => year = value; }
        public string Address { get => address; set => address = value; }
        public string Group { get => group; set => group = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int PassportId { get => passportId; set => passportId = value; }
        public int Age { get => age; set => age = value; }
        public int TelephoneNumber { get => telephoneNumber; set => telephoneNumber = value; }
        public string studentRating(int rating) {
            if (rating >= 90)
            {
                return "Greet the excellent student";
            }
            else if (rating >= 75)
            {
                return "You can study better";
                
            }
            else
            {
                return "You should spend more time studying";
            }
        }
    }
}
