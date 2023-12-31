public class LinqQueries
{

    public List<Book> librosCollection = new List<Book>();

    public LinqQueries()
    {

        using (StreamReader reader = new StreamReader("books.json"))
        {
            string json = reader.ReadToEnd();
            this.librosCollection = System.Text.Json.JsonSerializer.Deserialize<List<Book>>(json, new System.Text.Json.JsonSerializerOptions() { PropertyNameCaseInsensitive = true })!;
        }
    }
    public IEnumerable<Book> todaLaColeccion()
    {
        return librosCollection;
    }
    public IEnumerable<Book> publicationAfter2000()
    {
        return librosCollection.Where(x => x.publishedDate.Year > 2000);
    }
    public IEnumerable<Book> more250PagTitleInAction()
    {
        return librosCollection.Where(x => x.pageCount > 250 && x.title.Contains("in Action"));
    }
    public bool statusNotNull()
    {
        return librosCollection.All(x => x.status != string.Empty);
    }
    public bool anyPublication2005()
    {
        return librosCollection.Any(x => x.publishedDate.Year == 2005);
    }
    public IEnumerable<Book> inCategoryPython()
    {
        return librosCollection.Where(x => x.categories.Contains("Python"));
    }
    public IEnumerable<Book> orderByJAVA()
    {
        return librosCollection.Where(x => x.categories.Contains("Java")).OrderBy(x => x.title);
    }
    public IEnumerable<Book> orderByDescPag450()
    {
        return librosCollection.Where(x => x.pageCount > 450).OrderByDescending(x => x.pageCount);
    }
    public IEnumerable<Book> publicationDateRecent()
    {
        return librosCollection.Where(x => x.categories.Contains("Java"))
        .OrderByDescending(x => x.publishedDate)
        .Take(3);
    }
    public IEnumerable<Book> threeAndFourBookMore400Pag()
    {
        return librosCollection.Where(x => x.pageCount > 400).Take(4).Skip(2);
    }

    public IEnumerable<Book> firstThreeBooks()
    {
        return librosCollection.Take(3)
        .Select(x => new Book() { title = x.title, pageCount = x.pageCount });
    }
    public int booksBetween200And500Pag()
    {
        return librosCollection.Count(x => x.pageCount >= 200 && x.pageCount <= 500);
    }
    public DateTime firstPublicationDate()
    {
        return librosCollection.Min(x => x.publishedDate);
    }
    public int mostPages()
    {
        return librosCollection.Max(x => x.pageCount);
    }
    public Book lowestPages()
    {
        return librosCollection.Where(x => x.pageCount > 0).MinBy(x => x.pageCount);
    }
    public Book recientlyBooked()
    {
        return librosCollection.MaxBy(x => x.publishedDate);
    }
    public int sumBooksBetw0and500()
    {
        return librosCollection.Where(x => x.pageCount >= 0 && x.pageCount <= 500).Sum(x => x.pageCount);
    }
    public string booksAfter2015()
    {
        return librosCollection.Where(x => x.publishedDate.Year > 2015)
        .Aggregate("", (bookTitle, next) =>
        {
            if (bookTitle != string.Empty)
            {
                bookTitle += " \n" + next.title;
            }
            else
            {
                bookTitle += next.title;
            }
            return bookTitle;
        });
    }
    public double averageCharactersTitle()
    {
        return librosCollection.Average(x => x.title.Length);
    }
    public IEnumerable<IGrouping<int, Book>> publicationAfter2000GrByYear(){
        return librosCollection.Where(x => x.publishedDate.Year > 2000).GroupBy(x => x.publishedDate.Year);
    }
    public ILookup<char, Book> diccionaryBookByWord()
    {
        return librosCollection.ToLookup(p=> p.title[0], p=> p);
    }
    public IEnumerable<Book> joinMore500PagesAndPublicationAfter2005(){
        var publicationAfter2005 = librosCollection.Where(x=> x.publishedDate.Year > 2005);
        var more500Pages = librosCollection.Where(x=> x.pageCount > 500);
        return publicationAfter2005.Join(more500Pages, x=> x.title, y=> y.title, (x, y)=> x);
    }
}

