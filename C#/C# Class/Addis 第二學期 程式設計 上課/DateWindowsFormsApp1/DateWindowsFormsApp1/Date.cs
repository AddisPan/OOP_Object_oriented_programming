using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateWindowsFormsApp1
{
    class Date
    {
        private int _month;//物件的月份
        private int _date;//物件的日期
        //建構子
        public Date()
        {
            _month = 1;
            _date = 1;
        }
        //Month property
        public int Month
        {
            get
            {
                return _month;//取的物件的月份
            }
            set
            {
                if (value >= 1 && value <= 12) //有效的月份範圍
                {
                    _month = value;
                }
            }
        }

        //Day property
        public int Day
        {
            get
            {
                return _date;
            }
            set
            {
                if (_month == 1 || _month == 3 || _month == 5 || _month == 7 || _month == 8 || _month == 10 || _month == 12)
                {
                    if (value >=1 && value <= 31)
                    {
                        _date = value;
                    }
                }
                else if (_month == 4 || _month == 6 || _month == 9 || _month == 11)
                {
                    if (value >= 1 && value <= 30)
                    {
                        _date = value;
                    }
                }
                else if (_month == 2)
                {
                    if (value >= 1 && value <= 28)
                    {
                        _date = value;
                    }
                }
            }//end of date
        }

        public void addDays(int moreDays)
        {
            int maxDayInMonth = 30;
            if (_month == 1 || _month == 3 || _month == 5 || _month == 7 || _month == 8 || _month == 10 || _month == 12)
            {
                maxDayInMonth = 31;
            }
            else if (_month == 4 || _month == 6 || _month == 9 || _month == 11)
            {
                maxDayInMonth = 30;
            }
            else if (_month == 2)
            {
                maxDayInMonth = 28;
            }

            if (moreDays > 0 && moreDays < 29)
            {
                if (_date + moreDays <= maxDayInMonth)//沒有跨月分
                {
                    _date = _date + moreDays;
                }
                else  //跨月分
                {
                    _date = _date + moreDays - maxDayInMonth;
                    //新的物件月分
                    if (_month + 1 <= 12)
                    {
                        _month = _month + 1;
                    }
                    else //跨年分
                    {
                        _month = 1;
                    }
                }
            }
        }//end of addDays
    }
}
