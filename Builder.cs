using DesignPatterns.Models;
using System;

namespace DesignPatterns.ModelBuilders
{
    public class CarModelBuilder
    {
        private string color = "white";
        private string brand = "Ford";
        private string model = "Explorer";
        private int year = DateTime.Now.Year;
        
        public Vehicle Build()
        {
            return new Car(color, brand, model, year)
        }


        public CarModelBuilder SetColor(string color)
        {
            this.color = color;
            return this;
        }

        public CarModelBuilder SetBrand(string brand)
        {
            this.brand = brand;
            return this;
        }

        public CarModelBuilder SetModel(string model)
        {
            this.model = model;
            return this;
        }

        public CarModelBuilder SetYear(int year)
        {
            this.year = year;
            return this;
        }