namespace Code_OOP_Tasks
{
    internal class DocumentProgram
    {
        public void OpenDocument()
        {
            Console.WriteLine("Document opened");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Can Edit in Pro and Expert versions");
        }
       public virtual void SaveDocument(string documentFormat)
        {
            Console.WriteLine("Can Save in Pro and Expert versions");
        }
    }
}
