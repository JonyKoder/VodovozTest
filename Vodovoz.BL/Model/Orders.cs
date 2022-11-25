using System;
using VodovozTest.DAL.Model.Interface;

namespace VodovozTest.DAL.Model {
    public class Orders : IEntity {
        public int ID { get; set; }

        public int Number { get; set; }

        public string Contractor { get; set; }

        public DateTime OrderDate { get; set; }

        public Employee Employee { get; set; }

        public bool Validate() {
            if (string.IsNullOrWhiteSpace(Contractor)) return false;
            if (Number <= 0) return false;
            if ((DateTime.Now- OrderDate) < TimeSpan.FromMinutes(1)) return false;
            return true;
        }
    }
}