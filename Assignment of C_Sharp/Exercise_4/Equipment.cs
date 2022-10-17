namespace Exercise4
{
    public abstract class Equipment
    {
        public string name, desc;
        public int distance_moved, maintainence_cost;
        public enum EquipmentType
        {
            Mobile = 1,
            Immobile = 2,
        }

        public Equipment()
        {
            distance_moved = maintainence_cost = 0;
        }

        public virtual void MoveBy(int distance)
        {
        }
    }
}
