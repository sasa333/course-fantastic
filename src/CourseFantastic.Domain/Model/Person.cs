using System;
using System.Collections.Generic;
namespace CourseFantastic.Domain.Model
{
    public class Person
    {
        public string Identity { get; set; }

        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        private string _surname;

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }
        private DateTime _dob;

        public DateTime Dob
        {
            get { return _dob; }
            set { _dob = value; }
        }
        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private string _mobile;

        public string Mobile
        {
            get { return _mobile; }
            set { _mobile = value; }
        }

        private List<CourseDelivery> _enrolments;

        public List<CourseDelivery> Enrolments
        {
            get { return _enrolments; }
            set { _enrolments = value; }
        }

        private List<Timetable> _timeTable;

        public List<Timetable> TimeTable
        {
            get { return _timeTable; }
            set { _timeTable = value; }
        }
        private Teacher _teacher;

        public Teacher Teacher
        {
            get { return _teacher; }
            set { _teacher = value; }
        }
        private Student _student;

        public Student Student
        {
            get { return _student; }
            set { _student = value; }
        }

        public Person(string firstName, string surname, DateTime dob, string email)
        {
            FirstName = firstName;
            Surname = surname;
            Dob = dob;
            Email = email;
        }
        public Person(string firstName, string surname, DateTime dob, string email, string mobile)
            : this(firstName, surname, dob, email)
        {
            Mobile = mobile;
        }
        public Person(string firstName, string surname, DateTime dob, string email, string mobile, string studentId)
            : this(firstName, surname, dob, email, mobile)
        {
            Student = new Student(this,studentId);
        }
        

    }

}
