using System;
using System.Collections.Generic;
using VodovozTest.DAL.Model.Interface;

namespace VodovozTest.DAL.Model {
    public class Employee : IEntity {
        public int ID { get; set; }

        public string Surname { get; set; }

        public string Name { get; set; }

        public string Patronimyc { get; set; }

        public DateTime BirthDate { get; set; }

        public Gender Gender { get; set; }

        public Division Division { get; set; }

        public ICollection<Orders> Orders { get; set; }

        public bool Validate() {
            if (string.IsNullOrWhiteSpace(Name)) return false;
            if (string.IsNullOrWhiteSpace(Surname)) return false;
            if (DateTime.Now.Year - BirthDate.Year < 18) return false;
            return true;
        }
    }

    public enum Gender {
        Male,
        Female
    }
}