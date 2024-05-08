using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЖальЧтоЯНеПаблоЭскобар_18ИПо8284
{
    public class Room
    {
        double roomLength;
        double roomWidth;

        public double RoomLength
        {
            get { return roomLength; }
            set { roomLength = value; }
        }
        public double RoomWidth
        {
            get { return roomWidth; }
            set { roomWidth= value; }
        }
        /// <summary>
        /// Метод вычисляет периметр комнаты
        /// </summary>
        /// <returns>Возвращает значение периметра</returns>
        public double RoomPerimeter()
        {
            return 2 * (roomLength + roomWidth);
        }
       /// <summary>
       /// Метод Вычисляет площадь комнаты
       /// </summary>
       /// <returns>Возвращает значение площади</returns>
        public double RoomArea()
        {
            return roomLength * roomWidth;
        }
        /// <summary>
        /// Метод вычисляет число квадратных метров на одного человека
        /// </summary>
        /// <param name="np">Число человек</param>
        /// <returns>возвращает число квадратных метров</returns>
        public double PersonArea(int np)
        {
            return RoomArea() / np;
        }
        public virtual string Info()
        {
            return "Жилая комната площадью" + RoomArea() + " кв.м";
        }
    }
    public class livingRoom : Room
    {
        int numWin; //число окон
        public int NumWin
        { get { return numWin; } set { numWin = value; } }
        
        public override string Info()
        {
            return "Жилая комната площадью" + RoomArea() + " кв.м, с " + numWin + "окнами";
        }
    }
    public class Office : Room
    {
        int numSockets;
        public int NumSockets
        { get { return numSockets; }set { numSockets = value;  } }

        public int NumWorkplaces()
        {
            int num = Convert.ToInt32(Math.Truncate(RoomArea() / 4.5));
            return Math.Min(numSockets, num);
        }

        public override string Info()
        {
            return "офис на" + NumWorkplaces() + "Рабочих мест";
        }
    }
    
}
