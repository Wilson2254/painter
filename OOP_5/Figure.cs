﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization;
namespace OOP_5
{
    public abstract class Figure
    {

        //Координаты
        public int x1 { get;  set; }
        public int x2 { get;  set; }
        public int y1 { get;  set; }
        public int y2 { get;  set; }


        //Для рисования
        public abstract void Draw(Graphics g);


        //Для выбора фигуры
        public abstract bool Select(int sx, int sy);
    }
}
