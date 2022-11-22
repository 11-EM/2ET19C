internal class Program
{
    class Libary_Managment_System{
        protected string UserType, Username, Password;
        public string Login(){
            return "Metoda 1 z klasy 1";
        }
        public string Register(){
            return "Metoda 2 z klasy 1";
        }
        public string Logout(){
            return "Metoda 3 z klasy 1";
        }
    }
    class User{
        public string Name;
        private int ID;
        public string Verify(){
            return "Metoda 1 z klasy 2";
        }
        public string CheckAccount(){
            return "Metoda 2 z klasy 2";
        }
        public string get_book_info(){
            return "Metoda 3 z klasy 2";
        }
    }
    class Account{
        public bool no_borrowed_books, no_reserved_books, no_returned_books, no_lost_books;
        public float fine_amount;
        private string Calculate_fine(){
            return "Metoda 1 z klasy 3";
        }
    }
    class Book{
        public string Title, Author, ISBN, Publication;
        public string Show_duedt(){
            return "Metoda 1 z klasy 4";
        }
        public string Reservation_status(){
            return "Metoda 2 z klasy 4";
        }
        public string Feedback(){
            return "Metoda 3 z klasy 4";
        }
        public string Book_request(){
            return "Metoda 4 z klasy 4";
        }
        public string Renw_info(){
            return "Metoda 5 z klasy 4";
        }
    }
    class Liberian{
        public string Name, SearchString;
        private int ID;
        protected string Password;
        public string Verify_liberian(){
            return "Metoda 1 z klasy 5";
        }
        public string Search(){
            return "Metoda 2 z klasy 5";
        }
    }
    class Libary_database{
        public string List_of_books;
        private string Add(){
            return "Metoda 1 z klasy 6";
        }
        private string Delete(){
            return "Metoda 2 z klasy 6";
        }
        private string Update(){
            return "Metoda 3 z klasy 6";
        }
        private string Display(){
            return "Metoda 4 z klasy 6";
        }
        private string Search(){
            return "Metoda 5 z klasy 6";
        }
    }
    private static void Main(string[] args)
    {
        
    }
}
