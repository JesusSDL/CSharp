LinqQueries lq = new LinqQueries();


void imprimirValores(IEnumerable<Book> listadeLibros){
    Console.WriteLine("{0, -60}| {1,12}| {2,11}\n", "Título", "Nro Páginas", "Fecha de Publicaicón");
    foreach (var i in listadeLibros)
    {
        Console.WriteLine("{0, -60}| {1,12}| {2,11}", i.title, i.pageCount, i.publishedDate);
    }
}
imprimirValores(lq.More250PagTitleInAction());
//imprimirValores(lq.publicationAfter2000());
//imprimirValores(lq.todaLaColeccion());
