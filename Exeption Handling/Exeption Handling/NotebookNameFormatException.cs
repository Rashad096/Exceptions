using System;
using System.Collections.Generic;
using System.Text;

namespace Exeption_Handling
{
    internal class NotebookNameFormatException:Exception
    {
        public NotebookNameFormatException(string message):base(message) 
        {

        }
    }
}
