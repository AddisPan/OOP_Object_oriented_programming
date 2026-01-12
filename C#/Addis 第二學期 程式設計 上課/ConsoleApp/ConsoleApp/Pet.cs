using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Pet
    {
        private string _name;
        //建構子
        public Pet()
        {
            _name = "";
        }
        public Pet(string name)
        {
            _name = name;
        }

        //定義一個Name property
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
    }
}
