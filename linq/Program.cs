LinqQueries lq = new LinqQueries();

void imprimirValores(IEnumerable<Book> listadeLibros)
{
    Console.WriteLine("{0, -60}| {1,12}| {2,11}\n", "Título", "Nro Páginas", "Fecha de Publicaicón");
    foreach (var i in listadeLibros)
    {
        Console.WriteLine("{0, -60}| {1,12}| {2,11}", i.title, i.pageCount, i.publishedDate);
    }
}
void ImprimirGrupo(IEnumerable<IGrouping<int,Book>> ListadeLibros)
{
    foreach(var grupo in ListadeLibros)
    {
        Console.WriteLine("");
        Console.WriteLine($"Grupo: { grupo.Key }");
        Console.WriteLine("{0,-60} {1, 15} {2, 15}\n", "Titulo", "Nro Paginas", "Fecha publicacion");
        foreach(var item in grupo)
        {
            Console.WriteLine("{0,-60} {1, 15} {2, 15}",item.title,item.pageCount,item.publishedDate); 
        }
    }
}
void ImprimirDiccionario(ILookup<char, Book> ListadeLibros, char letra)
{
   Console.WriteLine("{0,-60} {1, 15} {2, 15}\n", "Titulo", "N. Paginas", "Fecha publicacion");
   foreach(var item in ListadeLibros[letra])
   {
         Console.WriteLine("{0,-60} {1, 15} {2, 15}",item.title,item.pageCount,item.publishedDate); 
   }
}


//imprimirValores(lq.joinMore500PagesAndPublicationAfter2005());
/*var diccionario = lq.diccionaryBookByWord(); 
ImprimirDiccionario(diccionario, 'B');*/

//ImprimirGrupo(lq.publicationAfter2000GrByYear());
//Console.Write($"El promedio de cantidad de caracteres, es: {lq.averageCharactersTitle()}");
//Console.Write($"Libros después del 2015: \n {lq.booksAfter2015()}");
//Console.Write($"La suma de páginas de libros de 0 a 50 páginas es: {lq.sumBooksBetw0y500()}");

/*var recientlyBooked = lq.recientlyBooked();
Console.Write($"El libro con la fecha más reciente de publicación es: {recientlyBooked.title} con fecha: {recientlyBooked.publishedDate}");*/

/*var objectLowestPages = lq.lowestPages(); 
Console.Write($"El libro con menor cantidad de la colección es: {objectLowestPages.title} con {objectLowestPages.pageCount} cantidad de páginas.");*/

//Console.Write($"La mayor cantidad de páginas que cuenta un libro de la colección son: {lq.mostPages()}");
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
