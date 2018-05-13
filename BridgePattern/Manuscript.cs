namespace BridgePattern
{
    public abstract class Manuscript
    {
        // Decouple an abstraction from its implementation so that the two can vary independently.
        // Publish interface in an inheritance hierarchy, and bury implementation in its own inheritance hierarchy.
        public string Title { get; set; }
        public string TotalPages { get; set; }
        public string YearPublished { get; set; }
        public string Description { get; set; }

        public abstract void Print();
    }
}
