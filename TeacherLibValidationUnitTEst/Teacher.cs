namespace TeacherLibValidationUnitTEst
{
    public class Teacher
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public int Salary { get; set; }

        public override string ToString()
        { return ID + " " + Name + " " + Salary; }
    }
}