
class Program
{
    public static void Main(string[] args)
    {
        Group group = new Group(21412, new DateTime(2024, 3, 3), new DateTime(2025, 2, 12), 10);

        Student student1 = new Student("student1Name", "student1Surname");
        Student student2 = new Student("student2Name", "student2Surname");
        Student student3 = new Student("student3Name", "student3Surname");
        Student student4 = new Student("student4Name", "student4Surname");
        Student student5 = new Student("student5Name", "student5Surname");
        Student student6 = new Student("student6Name", "student6Surname");
        Student student7 = new Student("student7Name", "student7Surname");
        Student student8 = new Student("student8Name", "student8Surname");
        Student student9 = new Student("student9Name", "student9Surname");
        Student student10 = new Student("studen10Name", "student10Surname");
        Student student11 = new Student("studen11Name", "student11Surname");

        Teacher teacher1 = new Teacher("student1Name", "student1Surname");
        Teacher teacher2 = new Teacher("student2Name", "student2Surname");
        Teacher teacher3 = new Teacher("student3Name", "student3Surname");
        Teacher teacher4 = new Teacher("student4Name", "student4Surname");
        Teacher teacher5 = new Teacher("student5Name", "student5Surname"); 
        
        Topic topic1 = new Topic("topic1");
        Topic topic2 = new Topic("topic2");
        Topic topic3 = new Topic("topic3");
        Topic topic4 = new Topic("topic4");
        Topic topic5 = new Topic("topic5");



        ///////////////Students
        group.AddStudent(student1);
        group.AddStudent(student2); 
        group.AddStudent(student3);
        group.AddStudent(student4);
        group.AddStudent(student5);
        group.AddStudent(student6);
        group.AddStudent(student7);
        group.AddStudent(student8);
        group.AddStudent(student9);
        group.AddStudent(student10);
        group.RemoveStudent(student5);
        group.GetStudents();

        ///////////////Teachers
        group.AddTeacher(teacher1);
        group.AddTeacher(teacher2);
        group.AddTeacher(teacher3);
        group.AddTeacher(teacher4);
        group.AddTeacher(teacher5);
        group.GetTeachers();

        ///////////////Topics
        group.AddTopic(topic1);
        group.AddTopic(topic2);
        group.AddTopic(topic3);
        group.AddTopic(topic4);
        group.AddTopic(topic5);
        group.GetTopics();


        group.GetDetails();

    }
}