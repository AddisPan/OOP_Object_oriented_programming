using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWindowsFormsApp
{
    class Car
    {
        private int _year;
        private string _model;
        private int _speed;
        public Car()
        {
            _speed = 0;
        }
        public Car (int year,string model)
        {
            _year = year;
            _model = model;
            _speed = 0;
        }
        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                _year = value;
            }
        }
        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }
        public int Speed
        {
            get
            {
                return _speed;
            }
            set
            {
                if (value >=0 && value <= 300)
                {
                    _speed = value;
                }                
            }
        }
        public int Accelerate()
        {
            if (_speed <= 295)
            {
                _speed += 5;
            }
            return _speed;
        }
        public int Break()
        {
            if (_speed >= 5)
            {
                _speed -= 5;
            }
            return _speed;
        }
    }
}
