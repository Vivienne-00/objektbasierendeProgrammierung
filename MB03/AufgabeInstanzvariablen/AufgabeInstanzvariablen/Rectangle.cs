using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AufgabeInstanzvariablen
{
    internal class Rectangle
    {
        //Aufgabe 1
        private int Height;
        private int Width;

        //Aufgabe 2
        public readonly string id;
        
        //Aufgabe 3
        public readonly string form = "Rectangle";
        
        //Aufgabe 4
        public string Name { get { return name; } }
        
        //Aufgabe 5
        public double Height { get { return height; } set { height = value; } }
        
        //Aufgabe 6
        public double Width { set { width = value; } }
        
        //Aufgabe 7
        public string Form { get; }
        
        //Aufgabe 8
        public string Form2 { get; set; }

        //Aufgabe 9
        //nicht möglich

        //Aufgabe 10
        //public Height GetHeight() => this.Height;
        //public Width GetWidth() => this.Width;
    }







}
