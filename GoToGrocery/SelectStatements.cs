using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoToGrocery
{
    internal abstract class SelectStatements : Statements
    {
        public SelectStatements() : base() { }

        public abstract string FormatStatement();

        public abstract string FormatStatement(List<string> searchContents, List<string> searchParameter);
    }
}
