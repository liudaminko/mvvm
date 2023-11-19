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
            CloseTaskCommand = new Command(CloseTask);
        }
        private string visibleControl = "Tasks";
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
        private TaskViewModel selectedTask;
        public TaskViewModel SelectedTask
        {
            get
            {
                return selectedTask;
            }
            set
            {
                selectedTask = value;
                OnPropertyChanged("SelectedTask");
            }
        }

        public ICommand SetControlVisibility { get; set; }
        public void ControlVisibility(object args)
        {
            VisibleControl = args.ToString();
        }
        public ICommand CloseTaskCommand { get; set; }
        public void CloseTask(object args)
        {
            //var task = (TaskViewModel)args;
            SelectedTask.Status = Model.TaskStatus.Closed;
        }

        private ObservableCollection<TaskViewModel> tasks;
        public ObservableCollection<TaskViewModel> Tasks 
        {
            get 
            {
                return tasks;
            }
            set 
            {
                tasks = value;
                OnPropertyChanged("Tasks");
            }
        }
        private ObservableCollection<ProjectViewModel> projects;
        public ObservableCollection<ProjectViewModel> Projects
        {
            get
            {
                return projects;
            }
            set
            {
                projects = value;
                OnPropertyChanged("Projects");
            }
        }

        private ObservableCollection<BooksViewModel> books;
        public ObservableCollection<BooksViewModel> Books
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
