﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Family
    {
		private List<Person> people;

        public Family()
        {
            this.people = new List<Person>();
        }
        public List<Person> People
		{
			get { return people; }
			set { people = value; }
		}

        public void AddMember(Person member)
        {
            People.Add(member);
        }

        public Person GetOldestMember()
        {
           Person person = people.MaxBy(p => p.Age);
           return person;
        }
    }
}