using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Organizer.Model;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Organizer.UI.Views;

namespace Organizer.UI.ViewModels
{
    public class DataViewModel : ViewModelBase
    {
        public DataViewModel() 
        {
            SetControlVisibility = new Command(ControlVisibility);
            BuyCommand = new Command(BuyItem);
        }
        private string visibleControl = "Books";
        public string VisibleControl
        {
            get
            {
                return visibleControl;
            }
            set
            {
                visibleControl = value;
                OnPropertyChanged("VisibleControl");
            }
        }
        private SouvenirViewModel selectedItem;
        public SouvenirViewModel SelectedItem
        {
            get
            {
                return selectedItem;
            }
            set
            {
                selectedItem = value;
                OnPropertyChanged("SelectedItem");
            }
        }

        public ICommand SetControlVisibility { get; set; }
        public void ControlVisibility(object args)
        {
            VisibleControl = args.ToString();
        }
        public ICommand BuyCommand { get; set; }
        public void BuyItem(object args)
        {
            //var task = (TaskViewModel)args;
            SelectedItem.Amount -= 1;
        }

        private ObservableCollection<SouvenirViewModel> souvenirs;
        public ObservableCollection<SouvenirViewModel> Souvenirs 
        {
            get 
            {
                return souvenirs;
            }
            set 
            {
                souvenirs = value;
                OnPropertyChanged("Souvenirs");
            }
        }
        private ObservableCollection<EBookViewModel> ebooks;
        public ObservableCollection<EBookViewModel> EBooks
        {
            get
            {
                return ebooks;
            }
            set
            {
                ebooks = value;
                OnPropertyChanged("EBooks");
            }
        }

        private ObservableCollection<BookViewModel> books;
        public ObservableCollection<BookViewModel> Books
        {
            get
            {
                return books;
            }
            set
            {
                books = value;
                OnPropertyChanged("Books");
            }
        }
    }
}
