using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HW.Buildings
{
    public class Building
    {
        /// <summary>
        /// ID of the building
        /// </summary>
        protected long _id;
        /// <summary>
        /// Height of the building
        /// </summary>
        protected float _height;
        /// <summary>
        /// Amount of the floors in the building
        /// </summary>
        protected int _floorCount;
        /// <summary>
        /// Amount of the flats in the building
        /// </summary>
        protected int _flatCount;
        /// <summary>
        /// Amount of the entrances in the building
        /// </summary>
        protected int _entranceCount;



        internal Building(float height, int floorCount, int flatCount, int entranceCount)
        {
            Height = height;
            FloorCount = floorCount;
            FlatCount = flatCount;
            EntranceCount = entranceCount;
        }
        internal Building() : this(0, 0, 0, 0) { }


        public long ID
        {
            get { return _id; }
            protected internal set { _id = value; }
        }
        public float Height
        {
            get { return _height; }
            protected set { _height = value; }
        }
        public int FloorCount
        {
            get { return _floorCount; }
            protected set { _floorCount = value; }
        }
        public int FlatCount
        {
            get { return _flatCount; }
            protected set { _flatCount = value; }
        }
        public int EntranceCount
        {
            get { return _entranceCount; }
            protected set { _entranceCount = value; }
        }
    }
}
