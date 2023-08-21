using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.Collections.Generic;
namespace lab06 {
    public class Person {
        private string name;
        private List<Dog> dogs;

        public Person(string name) {
            Name = name;
            dogs = new List<Dog>();
        }



        public string Name {
            get => name;
            set => name = value;
        }

        public List<Dog> Dogs {
            get => dogs;
        }

    }
}