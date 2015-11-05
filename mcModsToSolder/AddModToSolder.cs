using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace mcModsToSolder
{
    class AddModToSolder : Exception
    {

        public event Action<string> NavigateBrowser;

        public AddModToSolder()//Action<string> navigateBrowser)
        {
            //NavigateBrowser = navigateBrowser;
        }

        public void StartBrowser()
        {
        }
    }
}
