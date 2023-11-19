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
            LikeCommand = new Command(LikeItem);
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
        private ISelectedItem selectedItem;
        public ISelectedItem SelectedItem
        {
            get { return selectedItem; }
            set
            {
                selectedItem = value;
                OnPropertyChanged(nameof(SelectedItem));
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
            if (SelectedItem.Amount >=1)
                SelectedItem.Amount -= 1;
        }
        public ICommand LikeCommand { get; set; }
        public void LikeItem(object args)
        {
            if (SelectedItem.Status == ItemStatus.Liked)
                SelectedItem.Status = ItemStatus.NotLiked;
            else
                SelectedItem.Status = ItemStatus.Liked;
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
