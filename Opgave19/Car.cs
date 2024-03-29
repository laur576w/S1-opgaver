﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave19 {
    internal class Car {
        public string Brand  { get;}
        public string Model { get; }
        public string Color { get; }
        public double Price { get; set; }
        public bool IsSold { get; set; }
        public bool OnSale { get; set; }

        //main object
        public Car(string brand, string model, string color, double price, bool isSold) {
            Brand = brand;
            Model = model;
            Color = color;
            Price = price;
            IsSold = isSold;
            OnSale = false;
        }

        //print info on whole car
        public void PrintInfo() {
            if (IsSold == true) {
                Console.WriteLine($"\nBrand: {Brand}   Model: {Model}   Color {Color}   Sold: yes   Price: {Price}.\n");
            }
            else {
                Console.WriteLine($"\nBrand: {Brand}   Model: {Model}   Color {Color}   Sold: No   Price: {Price}.\n");
            }
        }

        //overwrite tostring
        public override string ToString() {
            return $"{Brand} {Model}";
        }

        //on sale command
        public void PutOnSale() {
            OnSale = true;
            Price *= 0.90;
        }
    }

}
