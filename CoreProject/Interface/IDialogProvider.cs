using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProject.Interface
{
 public   interface IDialogProvider
    {
        Task DisplayAlert(string title, string message, string cancel);
        Task<bool > DisplayAlert(string title, string message,string accept, string cancel);
        Task<string>DisplayActionSheet(string title,string  cancel, string description, params string[] buttons);
    }
}
