using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;

namespace Async_and_Await
{
   public class MainWindowViewModel
    {
        public MainWindowViewModel()
        {

        }    

        private async Task DownloadWebsite()
        {
            Task.Run(() => "return");
        }


    }
}
