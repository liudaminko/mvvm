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

            CreateMap<EBook, EBookViewModel>();
            CreateMap<EBookViewModel, EBook>();

            CreateMap<Model.Souvenir, SouvenirViewModel>();
            CreateMap<SouvenirViewModel, Model.Souvenir>();

            CreateMap<Book, BookViewModel>();
            CreateMap<BookViewModel, Book>();

        }
    }
}
