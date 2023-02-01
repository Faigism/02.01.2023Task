using System;
using System.Collections.Generic;
using System.Text;

namespace Task02._01._2023
{
    internal class Table :Equipment, IFurniture,ISuitable
    {
        public Table(double size) : base(size)
        {

        }
        string _name;
        double _price;
        double _size;
        string _suitable;
        public string Name
        {
            get { return _name; }
        }
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public double Size
        {
            get { return _size; }
            set { _size = value; }
        }
        public string Suitable
        {
            get { return _suitable; }
            set { _suitable = value; }
        }
        public void Convenience()
        {
            _suitable = _name;
        }
        public void Useful()
        {
            Console.WriteLine("Elverisli olub olmadigi");
        }
    }
}
