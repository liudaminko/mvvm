using Organizer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer.UI.ViewModels
{
    public interface ISelectedItem
    {
        ItemStatus Status { get; set; }
        int Amount { get; set; }
    }
}
