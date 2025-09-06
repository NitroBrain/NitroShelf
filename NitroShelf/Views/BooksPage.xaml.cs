using Microsoft.UI.Xaml.Controls;
using System.Collections.ObjectModel;

namespace NitroShelf
{
    public sealed partial class BooksPage : Page
    {
        public ObservableCollection<Book> Books { get; set; }

        public BooksPage()
        {
            this.InitializeComponent();

            Books = new ObservableCollection<Book>
            {
                new Book { Title = "Book One", Author = "Author A", Cover="../Assets/book.jpg" },
                new Book { Title = "Book Two", Author = "Author B", Cover="../Assets/book.jpg" },
                new Book { Title = "Book Three", Author = "Author C", Cover="../Assets/book.jpg" },
                new Book { Title = "Book Four", Author = "Author D", Cover="../Assets/book.jpg" },
            };

            BooksGrid.ItemsSource = Books;
        }

        private void BooksGrid_ItemClick(object sender, ItemClickEventArgs e)
        {
            var clickedBook = e.ClickedItem as Book;
        }
    }

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Cover { get; set; }
    }
}
