using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace lab06 {
    public class Dog {
        private int age;
        private string name;

        public Dog(string name, int age) {
            Name = name;
            Age = age;
        }

        public string Bark(int numTimes) {
            string msg = "";
            for (int i = 0; i < numTimes; i++) {
                msg += "bark ";
            }
            return msg;
        }

        public int Age {
            get => age;
            set => age = value;
        }


        public string Name {
            get => name;
            set => name = value;
        }

    }
}
