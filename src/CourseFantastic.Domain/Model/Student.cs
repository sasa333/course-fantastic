using System;
using System.Collections.Generic;
using System.Linq;
using CourseFantastic.Domain.Model;
using CourseFantastic.Domain.Services;

namespace CourseFantastic.Domain.Model
{
    public class Student : Learner
    {
        private Dictionary<string, List<Attendance>> _attendance;

        public Dictionary<string, List<Attendance>> Attendance
        {
            get { return _attendance; }
            set { _attendance = value; }
        }
        private List<Enrolment> _enrolments;
        
        public List<Enrolment> Enrolments
        {
            get { return _enrolments; }
            set { _enrolments = value; }
        }
        private Boolean _active;

        public Boolean Active
        {
            get { return _active; }
            set { _active = value; }
        }
        private string _studentID;

        public string StudentID
        {
            get { return _studentID; }
            set { _studentID = value; }
        }
        private Person _person;

        public Person Person
        {
            get { return _person; }
            set { _person = value; }
        }

        public Student(Person person, string studentID)
        {
            Person = person;
            StudentID = studentID;
            _attendance = new Dictionary<string, List<Attendance>>();

        }
        public Enrolment CreateEnrolment (CourseDelivery course)
        {
            var result = new Enrolment(this, course);
            Enrolments.Add(result);
            foreach (var subject in result.CourseRun.Subjects) {
                Attendance.Add(subject.Name, new List<Attendance>());
            }
            course.Enrolments.Add(result);
            return result;
        }

        public List<Enrolment> GetActiveEnrolments()
        {
            return Enrolments.Where(e => e.CourseRun.DeliveryPeriod.End >= DateTime.Now).ToList();
        }


        public Attendance CheckIn(DateTime start)
        {
            var result = new Attendance(start);
            return result;
        }

        public Attendance CheckOut(DateTime end)
        {
            throw new NotImplementedException();
        }
    }

}
