LinqQueries lq = new LinqQueries();


void imprimirValores(IEnumerable<Book> listadeLibros){
    Console.WriteLine("{0, -60}| {1,12}| {2,11}\n", "Título", "Nro Páginas", "Fecha de Publicaicón");
    foreach (var i in listadeLibros)
    {
        Console.WriteLine("{0, -60}| {1,12}| {2,11}", i.title, i.pageCount, i.publishedDate);
    }
}

imprimirValores(lq.inCategoryPython());
//Console.WriteLine($"Algún libro se publicó en 2005? \n {lq.anyPublished2005()}");
//Console.Write($"Los status están llenos? \n {lq.StatusNotNull()}");
//imprimirValores(lq.More250PagTitleInAction());
//imprimirValores(lq.publicationAfter2000());
//imprimirValores(lq.todaLaColeccion());
