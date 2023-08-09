public class LinqQueries{

    public List<Book> librosCollection = new List<Book>();

    public LinqQueries(){
        
        using(StreamReader reader = new StreamReader("books.json")){
            string json = reader.ReadToEnd();
            this.librosCollection = System.Text.Json.JsonSerializer.Deserialize<List<Book>>(json, new System.Text.Json.JsonSerializerOptions(){PropertyNameCaseInsensitive = true})!;
        }
    }
    public IEnumerable<Book> todaLaColeccion(){
        return librosCollection;
    }
    public IEnumerable<Book> publicationAfter2000(){
        return librosCollection.Where(x => x.publishedDate.Year > 2000);
    }
    public IEnumerable<Book> More250PagTitleInAction(){
        return librosCollection.Where(x => x.pageCount > 250 && x.title.Contains("in Action"));
    } 
    public bool StatusNotNull(){
        return librosCollection.All(x => x.status != string.Empty);
    }
    public bool anyPublished2005(){
        return librosCollection.Any(x => x.publishedDate.Year == 2005);
    }
    public IEnumerable<Book> inCategoryPython(){
        return librosCollection.Where(x => x.categories.Contains("Python"));
    }
    public IEnumerable<Book> orderByJAVA(){
        return librosCollection.Where(x => x.categories.Contains("Java")).OrderBy(x=> x.title);
    }
    public IEnumerable<Book> orderByDescPag450(){
        return librosCollection.Where(x=> x.pageCount > 450).OrderByDescending(x=> x.pageCount);
    }
    public IEnumerable<Book> publishedDateRecent(){
        return librosCollection.Where(x=> x.categories.Contains("Java"))
        .OrderByDescending(x=> x.publishedDate)
        .Take(3);
    }
    public IEnumerable<Book> threeAndFourBookMore400Pag(){
        return librosCollection.Where(x=> x.pageCount > 400).Take(4).Skip(2);
    }
    
    public IEnumerable<Book> firstThreeBooks(){
        return librosCollection.Take(3) 
        .Select(x=> new Book(){ title = x.title, pageCount = x.pageCount });
    }
    public int booksBetween200And500Pag(){
        return librosCollection.Count(x=> x.pageCount >= 200 && x.pageCount <=500);
    }
    public DateTime FirstPublishedDate(){
        return librosCollection.Min(x=> x.publishedDate);
    }
}

