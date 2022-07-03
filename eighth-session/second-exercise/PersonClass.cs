using System;

namespace EightSession2

{
    public class Person
    {
        public string _firstName { get; set; }
        public string _lastName { get; set; }
        public string _subject { get; set; }
        
        
        public Person(string firstName, string lastName, string subject)
        {
            _firstName = firstName;
            _lastName = lastName;
            _subject = subject;
        }
    }
}