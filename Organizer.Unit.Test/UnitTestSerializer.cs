using Microsoft.VisualStudio.TestTools.UnitTesting;
using Organizer.Model;
using Organizer.Model.Serialization;
using System;
using System.Collections.Generic;

namespace Organizer.Unit.Test
{
    [TestClass]
    public class UnitTestSerializer
    {
        [TestMethod]
        public void TestMethodSerialize()
        {
            var model = new DataModel();
            model.Events = new List<Book>()
            {
                new Book()
                {
                    Name = "Хлібне перемир'я", Author = "Сергій Жадан"
                }
            };
            model.Projects = new List<Project>()
            {
                new Project()
                {
                    Name = "Проєкт з КПЗ"
                }
            };
            model.Tasks = new List<Task>()
            {
                new Task()
                {
                    Name = "Написання тестів", Description = "Створити файл -> написати тести -> протестувати"
                },
                new Task()
                {
                    Name = "", Description = ""
                }
            };

            DataSerializer.SerializeData(@"D:\uni\3\organizer.dat", model);
        }

        [TestMethod]
        public void TestMethodDeSerialize()
        {
            var model = DataSerializer.DeserializeItem(@"D:\uni\3\organizer.dat");
        }
    }
}
