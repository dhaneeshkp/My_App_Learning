using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
namespace CoreProject.Interface
{
    public interface IPage : IDialogProvider
    {
        INavigation Navigation { get; }
    }
}
