using BuilderPattern;


var firstArticle = ArticleBuilder.InitializeCreateArticle()
    .SetTitle("First Hello World")
    .SetContent("Content of this article")
    .SetSummary("Summary");

var createdArticle = ((ArticleBuilder)firstArticle).Build();

Console.WriteLine($"{createdArticle.Title}\n{createdArticle.Content}\n{createdArticle.Summary}\n" );
    
