using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeWindowsFormsApp
{
    class Time
    {
        private int _hour;
        private int _minute;
        private int _second;

        public Time()
        {
            _hour = 0;
            _minute = 0;
            _second = 0;
        }

        //小時
        public int Hour
        {
            get
            {
                return _hour;
            }
            set
            {
                if (value >= 0 && value < 24) //有效的時間值
                {
                    _hour = value;
                }
            }
        }
        
        //分鐘
        public int Minute
        {
            get
            {
                return _minute;
            }
            set
            {
                if (value >= 0 && value < 60)
                {
                    _minute = value;
                }
            }
        }

        //秒鐘
        public int Second
        {
            get
            {
                return _second;
            }
            set
            {
                if (value >= 0 && value < 60)
                {
                    _second = value;
                }
            }
        }

        public void addSecond(int moreSecond)
        {
            int hours;
            int minutes;
            int seconds;

            //把現在的時間以秒為單位
            seconds = _hour * 3600 + _minute * 60 + _second + moreSecond;
            if (seconds >= 0) //時間是往前的
            {
                //計算新時間
                _second = seconds % 60;//新秒數

                //計算剩下的分鐘數
                minutes = seconds / 60;//分鐘數

                _minute =  minutes % 60;//新分鐘數

                //計算小時
                hours = minutes / 60;
                _hour = hours % 24;
            }
            else //時間往回走
            {
                _second = 60 - Math.Abs(seconds % 60);
                minutes = seconds / 60;
                minutes = Math.Abs(minutes % 60);
                if (minutes == 0)
                {
                    _minute = 59;
                }
                else
                {
                    _minute = 60 - minutes;
                }
                hours = minutes / 60;
                hours = Math.Abs(hours % 24);
                if (hours == 0)
                {
                    _hour = 23;
                }
                else
                {
                    _hour = 24 - hours;
                }
            }
        }
    }
}
