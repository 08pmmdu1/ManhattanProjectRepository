namespace ManhattanProject.Models.Entities
{
    public class User
    {
        public int Id { get; set; }
        //Имя
        public string Name { get; set; }
        //Фамилия
        public byte SecondName { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public byte Age { get; set; }
        public string Passport { get; set; }
    }
}
