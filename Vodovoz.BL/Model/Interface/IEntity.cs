namespace VodovozTest.DAL.Model.Interface {
    public interface IEntity {
        int ID { get; set; }

        bool Validate();
    }
}
