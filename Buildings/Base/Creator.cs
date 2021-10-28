using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HW.Buildings
{
    public class Creator
    {
        private static HashSet<Building> _buildings = new HashSet<Building>();
        private static long _lastId;


        private Creator() { }




        public static Building Create()
        {
            var newBuilding = new Building();
            OnCreate(newBuilding);
            return newBuilding;
        }
        public static Building Create(float height, int floorCount, int flatCount, int entranceCount)
        {
            var newBuilding = new Building(height, floorCount, flatCount, entranceCount);
            OnCreate(newBuilding);
            return newBuilding;
        }
        public static Building Destroy(Building building)
        {
            if (_buildings.Contains(building))
            {
                _buildings.Remove(building);
                Console.WriteLine($"building {building.ID} destroyed");
                return building;
            }
            else
            {
                throw new Exception();
            }
        }



        private static void OnCreate(Building building)
        {
            _lastId++;
            building.ID = _lastId;
            _buildings.Add(building);
        }
    }
}
