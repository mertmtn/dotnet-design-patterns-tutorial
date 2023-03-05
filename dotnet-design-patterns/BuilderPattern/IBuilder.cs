namespace BuilderPattern
{
    public interface IBuilder
    {
        public IBuilder SetTitle(string value);
        public IBuilder SetAbstract(string value);
        public IBuilder SetContent(string value);
        public IBuilder SetReferences(string value);
        public IBuilder SetSummary(string value); 
    }
}
