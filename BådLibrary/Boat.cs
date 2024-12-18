﻿namespace BådLibrary
{
    public class Boat
    {
        public int Id { get; set; } 
        public double RentalPrice { get; set; }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Name { get; set; }
        public int RegNumber { get; set; }
        public int HorsePower { get; set; }
        public int Knots { get; set; }
        public double Height { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }

        public Boat(int id, double rentalPrice, string type, string model, string name, int regNumber, int horsePower, int knots, double height, double length, double width)
        {
            Id = id;
            RentalPrice = rentalPrice;
            Type = type;
            Model = model;
            Name = name;
            RegNumber = regNumber;
            HorsePower = horsePower;
            Knots = knots;
            Height = height;
            Length = length;
            Width = width;
        }
    }

}
