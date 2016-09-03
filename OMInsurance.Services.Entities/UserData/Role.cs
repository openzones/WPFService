namespace OMInsurance.Services.Entities.Core
{
    public class Role : DataObject
    {
        public static Role Administrator = new Role() { Id = 1, Name = "Administrator" };
        public static Role Registrator = new Role() { Id = 2, Name = "Registrator" };
        public static Role OperatorSG = new Role() { Id = 3, Name = "OperatorSG" };
        public static Role AdministratorBSO = new Role() { Id = 4, Name = "AdministratorBSO" };
        public string Name { get; set; }
        public string Description { get; set; }

        public override bool Equals(object obj)
        {
            Role role = (Role)obj;
            return role.Id == this.Id && role.Name == Name;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode() ^ Name.GetHashCode();
        }
    }
}
