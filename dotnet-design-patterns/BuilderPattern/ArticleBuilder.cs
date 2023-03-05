namespace BuilderPattern
{
    public class ArticleBuilder :IBuilder
    {
        public string Title { get; set; }
        public string Abstract { get; set; }
        public string Content { get; set; }
        public string Summary { get; set; }
        public string References { get; set; }

        public IBuilder SetTitle(string value)
        {
            this.Title = value;
            return this;
        }

        public IBuilder SetAbstract(string value)
        {
            this.Abstract = value;
            return this;
        }

        public IBuilder SetContent(string value)
        {
            this.Content = value;
            return this;
        }

        public IBuilder SetReferences(string value)
        {
            this.References = value;
            return this;
        }

        public IBuilder SetSummary(string value)
        {
            this.Summary = value;
            return this;
        }

        public static ArticleBuilder InitializeCreateArticle()
        {
            return new ArticleBuilder();
        }

        public Article Build()
        {
            return new Article
            {
                Title = this.Title,
                Abstract = this.Abstract,
                Content = this.Content,
                Summary = this.Summary,
                References = this.References
            };
        }
    } 
}
