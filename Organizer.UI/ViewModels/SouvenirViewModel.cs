using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer.UI.ViewModels
{
    public class SouvenirViewModel: ViewModelBase
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        private string description;
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
                OnPropertyChanged("Description");
            }
        }

        private int amount;
        public int Amount
        {
            get
            {
                return amount;
            }
            set
            {
                amount = value;
                OnPropertyChanged("Amount");
            }
        }
    }
}
