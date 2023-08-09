LinqQueries lq = new LinqQueries();


void imprimirValores(IEnumerable<Book> listadeLibros){
    Console.WriteLine("{0, -60}| {1,12}| {2,11}\n", "Título", "Nro Páginas", "Fecha de Publicaicón");
    foreach (var i in listadeLibros)
    {
        Console.WriteLine("{0, -60}| {1,12}| {2,11}", i.title, i.pageCount, i.publishedDate);
    }
}


//Console.Write($"primera publicación: {lq.FirstPublishedDate()}");
//Console.Write($"Cantidad de libros con páginas entre 200 y 500:\n {lq.booksBetween200And500Pag()}");
//imprimirValores(lq.firstThreeBooks());
//imprimirValores(lq.threeAndFourBookMore400Pag());
//imprimirValores(lq.publishedDateRecent());
//imprimirValores(lq.orderByDescPag450());
//imprimirValores(lq.orderByJAVA());
//imprimirValores(lq.inCategoryPython());
//Console.WriteLine($"Algún libro se publicó en 2005? \n {lq.anyPublished2005()}");
//Console.Write($"Los status están llenos? \n {lq.StatusNotNull()}");
//imprimirValores(lq.More250PagTitleInAction());
//imprimirValores(lq.publicationAfter2000());
//imprimirValores(lq.todaLaColeccion());
