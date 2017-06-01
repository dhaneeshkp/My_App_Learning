using CoreProject.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProject.Services
{
    public class DialogService : IDialogProvider
    {
        private readonly IPage _page;
        public DialogService(IPage page)
        {
            _page = page;
        }

        public Task<string> DisplayActionSheet(string title, string cancel, string description, params string[] buttons)
        {
            return _page.DisplayActionSheet(title, cancel, description, buttons);
        }

        public Task DisplayAlert(string title, string message, string cancel)
        {
            return _page.DisplayAlert(title, message, cancel);
        }

        public Task<bool> DisplayAlert(string title, string message, string accept, string cancel)
        {
            return _page.DisplayAlert(title, message, accept, cancel);

        }
    }
}
