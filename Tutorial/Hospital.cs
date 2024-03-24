namespace Tutorial
{
    internal class Hospital
    {
        static void Main(string[] args)
        {
            Doctor doctor1 = new Doctor("kavindu",2001,"aaa");
            

            Doctor doctor2 = new Doctor("Charith",2003,"bbb");

            doctor2.Name = "pradeep";

            Console.WriteLine(doctor1.Id);
            Console.WriteLine(doctor2.Name);

        }
    }
}

