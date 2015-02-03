using Furniture.FurnitureManufacturer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public abstract class Furniture : IFurniture 
    {
        private string model;
        private string material;
        private decimal price;
        private decimal height;

        public Furniture()
        {

        }
        public string Model
        {
            get { return this.model; }
        }

        public string Material
        {
            get { return this.material; }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                // validation
                this.price = value;
            }
        }

        public decimal Height
        {
            get { return this.height; }
            protected set { this.height = value; }
        }
    }

    public class Company : ICompany
    {
        private string name;
        private string regNumber;
        private string catalog;
        private List<IFurniture> furnitures; 
        public string Name
        {
            get { return name; }
        }

        public string RegistrationNumber
        {
            get { return regNumber; }
        }

        public ICollection<IFurniture> Furnitures
        {
            get { return furnitures; }
        }

        public void Add(IFurniture furniture)
        {
            this.furnitures.Add(furniture);
        }

        public void Remove(IFurniture furniture)
        {
            this.furnitures.Remove(furniture);
        }

        public IFurniture Find(string model)
        {
           return this.furnitures.FirstOrDefault(x=>x.Model == model);
        }

        public string Catalog()
        {
            return this.catalog;
        }
    }

    public abstract class Chair : Furniture, IChair 
    {
        private int numberOfLegs;
        public int NumberOfLegs
        {
            get { return numberOfLegs; }
        }
    }

    public class Table : Furniture, ITable
    {
        private decimal length;
        private decimal width;
        private decimal area;
        public decimal Length
        {
            get { return this.length; }
        }

        public decimal Width
        {
            get { return this.width; }
        }

        public decimal Area
        {
            get { return this.area; }
        }
    }

    public class AdjustableChair : Chair, IAdjustableChair
    {
        public void SetHeight(decimal height)
        {
            base.Height = height;
        }
    }

    public class ConvertableChair : Chair, IConvertibleChair
    {
        private bool isConverted;
        public bool IsConverted
        {
            get { return this.isConverted; }
        }

        public void Convert()
        {
            this.isConverted = !this.isConverted;
        }
    }
}
