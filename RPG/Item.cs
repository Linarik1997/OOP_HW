namespace OOP_HW.RPG
{
    public abstract class Item
    {
        private int _weight;
        private string _name;



        public int Weight
        {
            get { return _weight; }
            protected set { _weight = value; }
        }
        public string Name
        {
            get { return _name; }
            protected set { _name = value; }
        }


        public abstract void Use();
    }
}