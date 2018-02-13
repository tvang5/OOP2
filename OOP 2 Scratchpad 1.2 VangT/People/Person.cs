using System;

namespace People
{
    /// <summary>
    /// The class which is used to represent a person.
    /// </summary>
    public class Person
    {
        /// <summary>
        /// The person's salary.
        /// </summary>
        private decimal salary;

        /// <summary>
        /// The age of the person.
        /// </summary>
        private int age;

        /// <summary>
        /// The first name of the person.
        /// </summary>
        private string firstName;

        /// <summary>
        /// The last name of the person.
        /// </summary>
        private string lastName;

        /// <summary>
        /// Gets or sets the age of the person.
        /// </summary>
        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                this.age = value;
            }
        }

        /// <summary>
        /// Gets or sets the first name of the person.
        /// </summary>
        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                this.firstName = value;
            }
        }

        /// <summary>
        /// Gets or sets the last name of the person.
        /// </summary>
        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                this.lastName = value;
            }
        }
    }
}