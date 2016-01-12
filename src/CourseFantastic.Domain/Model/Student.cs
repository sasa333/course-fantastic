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
        public Student(Person person, string studentID, Enrolment enrolment)
            : this(person, studentID)
        {
            Enrolments.Add(enrolment);
            foreach (var subject in enrolment.CourseRun.Subjects) {
                Attendance.Add()
            }
        }

        public List<Enrolment> GetActiveEnrolments()
        {
            return Enrolments.Where(e => e.CourseRun.DeliveryPeriod.End >= DateTime.Now).ToList();
        }
        public Enrolment Enrol(string callOccCode)
        {

          throw new NotImplementedException();
        }

        public Attendance CheckIn(DateTime start)
        {
            throw new NotImplementedException();
        }

        public Attendance CheckOut(DateTime end)
        {
            throw new NotImplementedException();
        }
    }

}
