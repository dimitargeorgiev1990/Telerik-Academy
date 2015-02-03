using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture
{
    namespace FurnitureManufacturer.Interfaces
    {
        public interface ICompany
        {
            string Name { get; }

            string RegistrationNumber { get; }

            ICollection<IFurniture> Furnitures { get; }

            void Add(IFurniture furniture);

            void Remove(IFurniture furniture);

            IFurniture Find(string model);

            string Catalog();
        }

        public interface IFurniture
        {
            string Model { get; }

            string Material { get; }

            decimal Price { get; set; }

            decimal Height { get; }
        }

        public interface IChair : IFurniture
        {
            int NumberOfLegs { get; }
        }



        public interface ITable : IFurniture
        {
            decimal Length { get; }

            decimal Width { get; }

            decimal Area { get; }
        }

        public interface IAdjustableChair : IChair
        {
            void SetHeight(decimal height);
        }

        public interface IConvertibleChair : IChair
        {
            bool IsConverted { get; }

            void Convert();
        }
    }

}
