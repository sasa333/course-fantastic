using Model;
using System;
namespace CourseFantastic.Domain.Model
{
    public class Address
    {
        private string _streetNumber;
        private string _streetName;
        private string _suburb;
        private State _state;
        private string _postCode;

        public string StreetNumber
        {
            get
            {
                return _streetNumber;
            }

            set
            {
                _streetNumber = value;
            }
        }

        public string StreetName
        {
            get
            {
                return _streetName;
            }

            set
            {
                _streetName = value;
            }
        }

        public string Suburb
        {
            get
            {
                return _suburb;
            }

            set
            {
                _suburb = value;
            }
        }

        public State State
        {
            get
            {
                return _state;
            }

            set
            {
                _state = value;
            }
        }

        public string PostCode
        {
            get
            {
                return _postCode;
            }

            set
            {
                _postCode = value;
            }
        }

        public Address(string streetNumber, string streetName, string suburb, State state, string postCode)
        {
            StreetNumber = streetNumber;
            StreetName = streetName;
            Suburb = suburb;
            State = state;
            PostCode = postCode;
        }
        public string GetFullAddress()
        {
            return String.Format("{0} {1}\n{2}, {3}, {4}", StreetNumber, StreetName, Suburb, State, PostCode);
        }

    }

}
