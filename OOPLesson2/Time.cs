using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLesson2
{
    internal class Time
    {

        //שם הבנאי  יהיה זהה לשם המחלקה
        //בנאי לא מחזיר ערך ולא void 
        //בנאי יכול לקבל פרמטרים 
        // ניתן ליצור בנאים אבל שלפחות אחד מהפמרטרים יהיו שונים מאותו בנאי שיצרנו
        //מבחינת סוג ה type 
        //בנאי default  נוצר מאחורי הקלעים במידה ואין שום בנאי שיצרנו
        //תפקידו לאפס את הערכים

        //prop
        public int Hour { get; set; }
        public int Minute { get; set; }


        //בנאי
        //ctor
        //קונסטרקטור
        //בנאי 1
        public Time(int hour, int min)
        {

            Hour = hour;
            Minute = min;
        }

        ////לא ניתן ליצור אותו בנאי מאותו סוג של פרמטרים אותו  
        //////בנאי 2
        public Time(int hour)
        {
            Hour = hour;
        }



    }
}
