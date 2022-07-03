using System;

namespace EightSession2

{
    public class Student: Person
    {

        public Student(string firstName, string lastName, string subject): base(firstName, lastName, subject)
        {
            _firstName = firstName;
            _lastName = lastName;
            _subject = subject;
        }

        public void Study()
        {
            Console.WriteLine($"\nMr./Ms. {_firstName} {_lastName} is studying {_subject}!");
        }
    }
}