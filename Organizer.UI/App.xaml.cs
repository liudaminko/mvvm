using AutoMapper;
using Organizer.Model;
using Organizer.UI.Base;
using Organizer.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Organizer.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private DataModel model;
        private DataViewModel viewModel;
        private IMapper mapper;
        public App()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<Mapping>();
            });
            mapper = new Mapper(config);
            new Mapping().Create();
            model = DataModel.Load();
            viewModel = mapper.Map<DataModel, DataViewModel>(model);
            var window = new MainWindow()
            {
                DataContext = viewModel
            };
            window.Show();

        }

        protected override void OnExit(ExitEventArgs e)
        {
            try
            {
                model = mapper.Map<DataViewModel, DataModel>(viewModel);
                model.Save();
            } catch (Exception)
            {
                base.OnExit(e);
                throw;
            }
        }
    }
}
