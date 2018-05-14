namespace BridgePattern
{
    public abstract class Manuscript
    {      
        public string Title { get; set; }
        public string TotalPages { get; set; }
        public string YearPublished { get; set; }
        public string Description { get; set; }

        public abstract void Print();
    }
}
