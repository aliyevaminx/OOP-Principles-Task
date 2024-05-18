class Group
{
    public int GroupNo { get; }
    public DateTime StartDate { get; }
    public DateTime EndDate { get; }
    public int Limit { get; set; }
    public Student[] Students { get; }
    public Teacher[] Teachers { get; }
    public Topic[] Topics { get; }


    private int studentCount;
    private int teacherCount;
    private int topicCount;


    public Group(int groupNo, DateTime startDate, DateTime endDate, int limit)
    {
        GroupNo = groupNo;
        StartDate = startDate;
        EndDate = endDate;
        Limit = limit + 1;


        Students = new Student[Limit];
        Teachers = new Teacher[Limit];
        Topics = new Topic[Limit];

    }

    public void GetDetails()
    {
        Console.WriteLine($"Group No: {GroupNo} Start Date: {StartDate} End Date: {EndDate} Limit: {Limit - 1}");
    }

    public void AddStudent(Student student)
    {
        if (studentCount < Limit - 1)
        {
            Students[studentCount++] = student;
        }
        else
        {
            Console.WriteLine("Group is full");
        }
    }

    public void RemoveStudent(Student student)
    {
        int index = Array.IndexOf(Students, student);

        if (index != -1)
        {

            for (int i = index; i < studentCount; i++)
            {
                Students[i] = Students[i + 1];
            }
            studentCount--;

        }
        else
            Console.WriteLine("This student isn't available");
    }

    public void GetStudents()
    {
        for (int i = 0; i < studentCount; i++)
        {
            Console.WriteLine($"{i + 1}.Student: {Students[i].Name} {Students[i].Surname}");
        }
    }

    public void AddTeacher(Teacher teacher)
    {
        if (teacherCount < Limit - 1)
        {
            Teachers[teacherCount++] = teacher;
        }
        else
            Console.WriteLine("Teacher capacity is full");
    }

    public void RemoveTeacher(Teacher teacher)
    {
        int index = Array.IndexOf(Teachers, teacher);

        if (index != -1)
        {

            for (int i = index; i < teacherCount; i++)
            {
                Teachers[i] = Teachers[i + 1];
            }
            teacherCount--;

        }
        else
            Console.WriteLine("This teacher isn't available");
    }

    public void GetTeachers()
    {
        for (int i = 0; i < teacherCount; i++)
        {
            Console.WriteLine($"{i + 1}.Teacher: {Teachers[i].Name} {Teachers[i].Surname}");
        }
    }

    public void AddTopic(Topic topic)
    {
        if (topicCount < Limit - 1)
        {
            Topics[topicCount++] = topic;
        }
        else
            Console.WriteLine("Topic capacity is full");
    }

    public void RemoveTopic(Topic topic)
    {
        int index = Array.IndexOf(Topics, topic);

        if (index != -1)
        {

            for (int i = index; i < topicCount; i++)
            {
                Topics[i] = Topics[i + 1];
            }
            topicCount--;

        }
        else
            Console.WriteLine("This topic isn't available");
    }

    public void GetTopics()
    {
        for (int i = 0; i < topicCount; i++)
        {
            Console.WriteLine($"{i + 1}.Topic: {Topics[i].TopicName}");
        }
    }
}