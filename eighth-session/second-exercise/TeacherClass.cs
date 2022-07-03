using System;

namespace EightSession2

{
    public class Teacher: Person
    {

        public Teacher(string firstName, string lastName, string subject): base(firstName, lastName, subject)
        {
            _firstName = firstName;
            _lastName = lastName;
            _subject = subject;
        }

        public void Explain()
        {
            Console.WriteLine($"\nMr./Ms. {_firstName} {_lastName} is explaining {_subject}!");
        }
    }
}