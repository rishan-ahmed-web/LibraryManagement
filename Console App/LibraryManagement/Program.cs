

using LibraryManagement;

List<Book> books = new List<Book>
{
    new Book("Opekkha","Humayun Ahmed","79841-546"),
    new Book("Prottoborton","Arif Azad","98746-985"),
    new Book("Paradoxical","Arif Azad","64654-987")
};

foreach (Book book in books)
{
    book.ShowInfo();
}