using System;

namespace project01 {
    class Human {
        public string firstName { get; }
        public string lastName { get; }
        public DateTime birth { get; }

        public string name {
            get {
                return $"{firstName} {lastName}";
            }
        }

        public int age {
            get {
                // https://stackoverflow.com/a/1404
                DateTime today = DateTime.Today;
                int age = today.Year - birth.Year;
                if (birth.Date > today.AddYears(-age)) {
                    age--;
                }
                return age;
            }
        }

        public Human(string firstName, string lastName, DateTime birth) {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birth = birth;
        }

        public Human(string firstName, string lastName, string birth) {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birth = DateTime.Parse(birth);
        }

    }
}