using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    public interface IFruit
    {
        string GetName();
        string GetColor();
        string GetInformation();
    }

    public class Apple : IFruit
    {
        private string _name = "Apple";
        private string _color = "Red or green";

        public string GetName()
        {
            return _name;
        }

        public string GetColor()
        {
            return _color;
        }

        public string GetInformation()
        {
            return $"Name: {_name}\nColor: {_color}\n";
        }
    }

    public class Banana : IFruit
    {
        private string _name = "Banana";
        private string _color = "Yellow";

        public string GetName()
        {
            return _name;
        }

        public string GetColor()
        {
            return _color;
        }

        public string GetInformation()
        {
            return $"Name: {_name}\nColor: {_color}\n";
        }
    }

    public class Orange : IFruit
    {
        private string _name = "Orange";
        private string _color = "Orange";

        public string GetName()
        {
            return _name;
        }

        public string GetColor()
        {
            return _color;
        }

        public string GetInformation()
        {
            return $"Name: {_name}\nColor: {_color}\n";
        }
    }
}
