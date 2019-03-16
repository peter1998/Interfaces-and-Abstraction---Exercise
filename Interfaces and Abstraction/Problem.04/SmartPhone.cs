using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem._04
{
    public class SmartPhone : ICalling, IBrowsing
    {

        private string model;

        public SmartPhone(string model)
        {
            this.model = model;
        }

        public string Model { get => model; set => model = value; }



        public string Browsing(string website)
        {
            if (website.Any(c => char.IsDigit(c)))
            {
                throw new ArgumentException("Invalid URL!");
            }
            else
            {
                return $"Browsing: {website}!";
            }
        }


        public string Calling(string number)
        {
            if (number.Any(c => char.IsLetter(c)))
            {
                throw new ArgumentException("Invalid number!");
            }
            else
            {
                return $"Calling... {number}";
            }
        }
    }
    }
