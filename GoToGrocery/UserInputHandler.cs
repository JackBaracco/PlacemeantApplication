using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoToGrocery
{
    internal class UserInputHandler
    {
        private List<string> _checked = new List<string>();
        private List<string> _input = new List<string>();

        public UserInputHandler() { }
        
        public List<string> Checked
        {
            get { return _checked; }
        }

        public List<string> Input
        {
            get { return _input; }
        }

        public void AddChecked(string checkbox)
        {
            _checked.Add(checkbox);
        }

        public void AddUserInput(string userinput)
        {
            _input.Add(userinput);
        }

        public void ClearLists()
        {
            _checked.Clear();
            _input.Clear();
        }
    }
}
