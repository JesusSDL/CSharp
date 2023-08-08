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
}