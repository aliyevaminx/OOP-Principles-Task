using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_OOP_Tasks
{
    internal class ExpertDocumentProgram : ProDocumentProgram
    {
        public override void SaveDocument(string documentFormat)
        {
            if (documentFormat == "pdf")
                Console.WriteLine("Document Saved in pdf format");
            else if (documentFormat == "doc")
                Console.WriteLine("Document Saved in doc format");
            else
                Console.WriteLine("Check your format");
        }
    }
}
