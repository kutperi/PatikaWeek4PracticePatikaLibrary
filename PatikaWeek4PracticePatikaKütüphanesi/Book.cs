using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaWeek4PracticePatikaKütüphanesi
{
    
    public class Book // Creating a new class
    {
        private string _bookName;
        private string _authorName;
        private string _authorSurname;
        private int _pageCount;
        private string _publisher;
        private DateTime _registrationDate;

        // Setting properties to access and modify the fields given above
        public string bookName 
        {
            get
            {
                return _bookName;
            }
            set
            {
                _bookName = value;
            }
        }
        public string authorName
        {
            get
            {
                return _authorName;
            }
            set
            {
                _authorName = value;
            }
        }

        public string authorSurname
        {
            get
            {
                return _authorSurname;
            }
            set
            {
                _authorSurname = value;
            }
        }

        public int pageCount
        {
            get
            {
                return _pageCount;
            }
            set
            {
                _pageCount = value;
            }
        }

        public string publisher
        {
            get
            {
                return _publisher;
            }
            set
            {
                _publisher = value;
            }
        }

        public DateTime registrationDate
        {
            get
            {
                return _registrationDate;
            }
            set
            {
                _registrationDate = value;
            }
        }




        public Book() // Default constructor
        {
            RegistrationDate();
        }

        public Book(string bookName, string authorName, string authorSurname, int pageCount, string publisher) // Constructor that takes parameters
        {
            _bookName = bookName;
            _authorName = authorName;
            _authorSurname = authorSurname;
            _pageCount = pageCount;
            _publisher = publisher;
            RegistrationDate();
        }

        public void BookInfo() // Method that prints out information about books.
        {
            Console.WriteLine($"{_authorName} {_authorSurname} kişisine ait {_pageCount} sayfalık, {_publisher} yayınevinden çıkan {_bookName} adlı kitap oluşturuldu.");
            Console.WriteLine($"Kayıt tarihi: {_registrationDate}");
        }

        public void RegistrationDate() // Method to save current date and time when its called
        {
            _registrationDate = DateTime.Now;
        }
    }
}
