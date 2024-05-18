using Code_OOP_Tasks;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your version: ");
    InputProgramVersion: string programVersion = Console.ReadLine();

        switch (programVersion)
        {
            case "basic":
                DocumentProgram basic = new DocumentProgram();
                basic.OpenDocument();
                basic.EditDocument();
                basic.SaveDocument("doc");
                break;
            case "pro":
                ProDocumentProgram pro = new ProDocumentProgram();
                pro.OpenDocument();
                pro.EditDocument();
                pro.SaveDocument("pdf");
                break;
            case "expert":
                ExpertDocumentProgram expert = new ExpertDocumentProgram();
                expert.OpenDocument();
                expert.EditDocument();
                expert.SaveDocument("pdf");
                break;
            default:
                Console.WriteLine("Invalid input, check your version");
                goto InputProgramVersion;
                break;
        }
    }
}