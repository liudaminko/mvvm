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
            model.Books = new List<Book>()
            {
                new Book()
                {
                    Name = "Хлібне перемир'я", Author = "Сергій Жадан"
                }
            };
            model.EBooks = new List<EBook>()
            {
                new EBook()
                {
                    Name = "Проєкт з КПЗ"
                }
            };
            model.Souvenirs = new List<Souvenir>()
            {
                new Souvenir()
                {
                    Name = "Написання тестів", Description = "Створити файл -> написати тести -> протестувати"
                },
                new Souvenir()
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
