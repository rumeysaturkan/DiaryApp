using diary.Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace diary.Lists
{
    public class PersonList
    {
        public ObservableCollection<Person> Persons { get; set; }
        public PersonList()
        {
            Persons = new ObservableCollection<Person>();
            Persons.Add(new Person
            {
                Name = "Rumeysa Türkan",
                Email = "rumeysa@gmail.com",
                Password = "rumeysa123",
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRFyXXTy0GwvvU4wx_5YN9CZZIqH2lVh7B-mQ&usqp=CAU"


            });
            Persons.Add(new Person
            {
                Name = "Nurgül Nisa",
                Email = "nisa@gmail.com",
                Password = "nisa123",
                ImageUrl = "https://shotkit.com/wp-content/uploads/2021/06/cool-profile-pic-matheus-ferrero.jpeg"



            }); Persons.Add(new Person
            {
                Name = "Bahar Bağ",
                Email = "bahar@gmail.com",
                Password = "rumeysa123",
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRFyXXTy0GwvvU4wx_5YN9CZZIqH2lVh7B-mQ&usqp=CAU"

            });
            Persons.Add(new Person
            {
                Name = "Berna Ozer",
                Email = "berna@gmail.com",
                Password = "rumeysa123",
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRFyXXTy0GwvvU4wx_5YN9CZZIqH2lVh7B-mQ&usqp=CAU"

            });
        }
    }
}
