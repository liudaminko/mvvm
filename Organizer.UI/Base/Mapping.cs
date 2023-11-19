using AutoMapper;
using Organizer.Model;
using Organizer.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer.UI.Base
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            Create();
        }
        public void Create()
        {
            CreateMap<DataModel, DataViewModel>();
            CreateMap<DataViewModel, DataModel>();

            CreateMap<Project, ProjectViewModel>();
            CreateMap<ProjectViewModel, Project>();

            CreateMap<Model.Task, TaskViewModel>();
            CreateMap<TaskViewModel, Model.Task>();

            CreateMap<Book, BooksViewModel>();
            CreateMap<BooksViewModel, Book>();

        }
    }
}
