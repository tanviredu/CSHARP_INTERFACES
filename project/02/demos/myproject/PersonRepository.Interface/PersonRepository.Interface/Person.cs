using System;

namespace PersonRepository.Interface
{
    public class Person
    {
        /// it will hold only the attribute
        public int Id { get; set; }
        public string GivenName { get; set; }
        public string FamilyName { get; set; }
        public DateTime StartDate { get; set; }
        public string FormatString { get; set; }
        public int Rating { get; set; }

        // toString is a default method of all class
        // we are ging to override this class

        public override string ToString()
        {
            if (string.IsNullOrEmpty(FormatString))
            {
                FormatString = "{0} {1}";
                
            }
            return string.Format(FormatString, GivenName, FamilyName);
        }


    }


}
