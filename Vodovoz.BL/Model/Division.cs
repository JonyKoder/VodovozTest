using System.Collections.Generic;
using VodovozTest.DAL.Model.Interface;

namespace VodovozTest.DAL.Model {
    public class Division: IEntity {
        public int ID { get; set; }
        public string Title { get; set; }

        public ICollection<Employee> Employees { get; set; }

        public Employee Glav { get; set; }

        public int GlavId { get; set; }
        public bool Validate() {
            if (string.IsNullOrWhiteSpace(Title)) return false;
            return true;
        }
    }
}