using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BindingDemo
{
    public partial class MainPage : ContentPage
    {
        private List<Book> _books = new List<Book>();

        public List<Book> Books
        {
            get
            {
                return _books;
            }
            set
            {
                _books = value;
            }
        }

        public MainPage()
        {
            InitializeComponent();

            var book = new Book();
            book.BookTitle = "Pokemon Adventures";
            book.NumebrOfChapters = 549;
            book.UpdatedDate = new DateTime(2022, 05, 11);
            book.ImageName = "tiger.png";

            Books.Add(book);

            book = new Book();
            book.BookTitle = "Other book";
            book.NumebrOfChapters = 20;
            book.UpdatedDate = new DateTime(2022, 05, 11);
            book.ImageName = "swoosh.png";

            Books.Add(book);

            book = new Book();
            book.BookTitle = "Another book";
            book.NumebrOfChapters = 20;
            book.UpdatedDate = new DateTime(2022, 05, 11);
            book.ImageName = "swoosh.png";

            Books.Add(book);


            BindingContext = this;
        }
    }
}
