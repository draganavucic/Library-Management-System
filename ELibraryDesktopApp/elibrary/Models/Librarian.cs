using Neo4jClient;
using Neo4jClient.Cypher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibrary.Models
{
    public class Librarian
    {
        public GraphClient client;
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }


        public Librarian()
        {

        }

        public Librarian(string user, string pass, bool isAdmin, string Name, DateTime bth, GraphClient passedClient)
        {
            client = passedClient;
            Username = user;
            Password = pass;
            IsAdmin = isAdmin;
            this.Name = Name;
            Birthday = bth;
            
        }

        

        // ADDING
        public bool AddBook(Book book)
        {

            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("Title", book.Title);
            queryDict.Add("Language", book.Language);
            queryDict.Add("Genre", book.Genre);
            queryDict.Add("Year", book.Year);
            queryDict.Add("Description", book.Description);
            queryDict.Add("Author", book.Author);
            queryDict.Add("Pages", book.Pages);
            queryDict.Add("Quantity", book.Quantity);
            queryDict.Add("Available", book.Available);

            var query = new CypherQuery("CREATE (n:Book {Title:\"" + book.Title + "\", Language:\"" + book.Language + "\" , Genre:\"" + book.Genre + "\" , Year:\"" + book.Year + "\", Description:\"" + book.Description + "\", Author:\"" + book.Author + "\", Pages:\"" + book.Pages + "\", Quantity:\"" + book.Quantity + "\", Available:\"" + book.Available + "\"})return n", queryDict, CypherResultMode.Set);

            var queryBA = new CypherQuery("MATCH (a:Book {Title:'" + book.Title + "'}), (b:Author{Name:'" + book.Author + "'}) CREATE(b)-[:Wrote]->(a) return b", queryDict, CypherResultMode.Set);

            try
            {
                ((IRawGraphClient)client).ExecuteGetCypherResults<User>(query).ToList();
                ((IRawGraphClient)client).ExecuteGetCypherResults<User>(queryBA);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool AddUser(User user)
        {
            DateTime ExpirationDate = DateTime.Now.AddMonths(1);

            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("JMBG", user.JMBG);
            queryDict.Add("Name", user.Name);
            queryDict.Add("Address", user.Address);
            queryDict.Add("Phone", user.Phone);
            queryDict.Add("Email", user.Email);
            queryDict.Add("RentedBook", user.RentedBook);

            queryDict.Add("ExpirationDate", ExpirationDate.ToShortDateString());

            var query = new CypherQuery("CREATE (n:User {JMBG:\"" + user.JMBG + "\", Name:\"" + user.Name + "\" , Address:\"" + user.Address + "\" , Phone:\"" + user.Phone + "\", ExpirationDate:\"" + ExpirationDate.ToShortDateString() + "\", Email:\"" + user.Email + "\"})return n", queryDict, CypherResultMode.Set);
            
            var query2 = new CypherQuery("MATCH (a:Librarian { Username: '" + Program.librarian.Username + "' }), (b:User { Email: '"+user.Email+"' }) CREATE(a)-[:RegisteredUser {DateOfRegistration: '"+ DateTime.Now.ToString("d") +"'}]->(b) return b", queryDict, CypherResultMode.Set);

            try
            {
                ((IRawGraphClient)client).ExecuteGetCypherResults<User>(query).ToList();
                ((IRawGraphClient)client).ExecuteGetCypherResults<User>(query2);
                return true;
            }
            catch
            {
                return false;
            }
        }

        

        public bool AddLibrarian(Librarian librarian)
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("Password", librarian.Password);
            queryDict.Add("Name", librarian.Name);
            queryDict.Add("Username", librarian.Username);
            queryDict.Add("Birthday", librarian.Birthday.Date);
            queryDict.Add("IsAdmin", librarian.IsAdmin);


            var query = new CypherQuery("CREATE (n:Librarian {Name:\"" + librarian.Name + "\", Username:\"" + librarian.Username + "\" , Password:\"" + librarian.Password + "\" , Birthday:\"" + librarian.Birthday + "\" , IsAdmin:\"" + librarian.IsAdmin + "\"})return n", queryDict, CypherResultMode.Set);

            try
            {
                ((IRawGraphClient)client).ExecuteGetCypherResults<Librarian>(query).ToList();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool AddAuthor(Author autor)
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("Year", autor.Year);
            queryDict.Add("Name", autor.Name);
            queryDict.Add("Bio", autor.Bio);

            var query = new CypherQuery("CREATE (n:Author {Name:\"" + autor.Name + "\", Year:\"" + autor.Year + "\" , Bio:\"" + autor.Bio + "\"})return n", queryDict, CypherResultMode.Set);

            try
            {
                ((IRawGraphClient)client).ExecuteGetCypherResults<Author>(query).ToList();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //COMMENTS
        public void ApproveComment(Comment comment)
        {
            var query = new CypherQuery("MATCH (n:Comment) WHERE(n.CommentedBook = '" + comment.CommentedBook + "' and n.UserCommented = '" + comment.UserCommented + "' and n.Rate = " + comment.Rate + " and n.Text = '" + comment.Text + "' and n.IsApproved = " + comment.IsApproved + ") SET n.IsApproved = true", new Dictionary<string, object>(), CypherResultMode.Set);
            try
            {
                Comment DBComment = ((IRawGraphClient)client).ExecuteGetCypherResults<Comment>(query).ToList().First();
            }
            catch { }

            query = new CypherQuery("MATCH (n:Comment {IsApproved:true, Text:'" + comment.Text + "', CommentedBook:'" + comment.CommentedBook + "', UserCommented:'" + comment.UserCommented + "'}), (a:Librarian{Username:'" + Program.librarian.Username + "'}) CREATE (a)-[r:Approved]->(n) RETURN r", new Dictionary<string, object>(), CypherResultMode.Set);
            try
            {
                string result = ((IRawGraphClient)client).ExecuteGetCypherResults<string>(query).ToString();
            }
            catch { }
        }

        public void DiscardComment(Comment comment)
        {
            var query = new CypherQuery("MATCH (n:Comment) WHERE(n.CommentedBook = '" + comment.CommentedBook + "' and n.UserCommented = '" + comment.UserCommented + "' and n.Rate = " + comment.Rate + " and n.Text = '" + comment.Text + "' and n.IsApproved = " + comment.IsApproved + ") DETACH DELETE n", new Dictionary<string, object>(), CypherResultMode.Set);
            try
            {
                Comment DBComment = ((IRawGraphClient)client).ExecuteGetCypherResults<Comment>(query).ToList().First();
            }
            catch { }
        }
        //librarians

        public void DeleteLibrarian(Librarian l)
        {
            var query = new CypherQuery("match(Librarian { Username: "+l.Username+"}) optional match (n) -[r] - () delete n, r", new Dictionary<string, object>(), CypherResultMode.Set);
            //var query = new CypherQuery("MATCH (n:Librarian) WHERE(n.Username = '" + l.Username + "' and n.Password = '" + l.Password + ") DETACH DELETE n", new Dictionary<string, object>(), CypherResultMode.Set);
            try
            {
                Librarian lib = ((IRawGraphClient)client).ExecuteGetCypherResults<Librarian>(query).ToList().First();
            }
            catch { }
        }
        public void UpdateLibrarian(Librarian l)
        {
            var query = new CypherQuery("MATCH (n:Librarian) WHERE(n.Username = '" + l.Username + "' and n.Password = '" + l.Password + ") SET n.IsAdmin = false", new Dictionary<string, object>(), CypherResultMode.Set);
            try
            {
                Librarian lib = ((IRawGraphClient)client).ExecuteGetCypherResults<Librarian>(query).ToList().First();
            }
            catch { }
        }

        //RETURNS
        public Book ReturnBookByTitle(string _title)
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            Book book = new Book();

            var query = new CypherQuery("START n=node(*) where (n:Book) and (n.Title =~ '.*" + _title + ".*') RETURN n", queryDict, CypherResultMode.Set);


            book = ((IRawGraphClient)client).ExecuteGetCypherResults<Book>(query).ToList().First();

            return book;
        }
        public Author ReturnAuthorByName(string _name)
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            Author a = new Author();

            var query = new CypherQuery("START n=node(*) where (n:Author) and (n.Name =~ '.*" + _name + ".*') RETURN n", queryDict, CypherResultMode.Set);

            a = ((IRawGraphClient)client).ExecuteGetCypherResults<Author>(query).ToList().First();

            return a;
        }

        public List<Book> ReturnBooksByTitle(string _title)
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>();

            var query = new CypherQuery("START n=node(*) where (n:Book) and (n.Title =~ '.*" + _title + ".*') RETURN n", queryDict, CypherResultMode.Set);

            var books = new List<Book>();

            books = ((IRawGraphClient)client).ExecuteGetCypherResults<Book>(query).ToList();

            return books;
        }

        public List<User> ReturnAllUsers()
        {
            Dictionary<string,object> queryDict = new Dictionary<string, object>();
            
            var query = new CypherQuery("START n=node(*) where (n:User) RETURN n", queryDict, CypherResultMode.Set);

            var UserList = new List<User>();
            
            UserList = ((IRawGraphClient)client).ExecuteGetCypherResults<User>(query).ToList();
            
            return UserList;
        }

        public List<User> ReturnExpiredUsers()
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            
            var query = new CypherQuery("START n=node(*) where (n:User) RETURN n", queryDict, CypherResultMode.Set);

            var UserList = new List<User>();

            UserList = ((IRawGraphClient)client).ExecuteGetCypherResults<User>(query).ToList();
            
            UserList.RemoveAll(u => DateTime.Compare(u.ExpirationDate,DateTime.Now) > 0);
            
            return UserList;
        }

        public List<User> ReturnNonExpiredUsers()
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            
            var query = new CypherQuery("START n=node(*) where (n:User) RETURN n", queryDict, CypherResultMode.Set);

            var UserList = new List<User>();

            UserList = ((IRawGraphClient)client).ExecuteGetCypherResults<User>(query).ToList();

            UserList.RemoveAll(u => DateTime.Compare(u.ExpirationDate, DateTime.Now) < 0);

            return UserList;
        }

        public List<User> ReturnUsersByJMBG(string _jmbg)
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            
            var query = new CypherQuery("START n=node(*) where (n:User) and (n.JMBG =~ '.*" + _jmbg + ".*') RETURN n", queryDict, CypherResultMode.Set);

            var UserList = new List<User>();

            UserList = ((IRawGraphClient)client).ExecuteGetCypherResults<User>(query).ToList();

            return UserList;
        }

        internal List<User> ReturnUsersByName(string _name)
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>();

            var query = new CypherQuery("START n=node(*) where (n:User) and (n.Name =~ '.*" + _name + ".*') RETURN n", queryDict, CypherResultMode.Set);

            var UserList = new List<User>();

            UserList = ((IRawGraphClient)client).ExecuteGetCypherResults<User>(query).ToList();

            return UserList;
        }


        public List<Librarian> ReturnAllLibrarians()
        {
           
            Dictionary<string, object> queryDict = new Dictionary<string, object>();

            var query = new CypherQuery("START n=node(*) where (n:Librarian) RETURN n", queryDict, CypherResultMode.Set);

            var LibrarianList = new List<Librarian>();

            LibrarianList = ((IRawGraphClient)client).ExecuteGetCypherResults<Librarian>(query).ToList();

            return LibrarianList;
        }


        public List<Book> ReturnAllBooks()
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>();

            var query = new CypherQuery("START n=node(*) where (n:Book) RETURN n", queryDict, CypherResultMode.Set);

            var BookList = new List<Book>();

            BookList = ((IRawGraphClient)client).ExecuteGetCypherResults<Book>(query).ToList();

            return BookList;
        }

        public List<Book> ReturnAllAvailableBooks()
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>();

            var query = new CypherQuery("START n=node(*) where (n:Book) RETURN n", queryDict, CypherResultMode.Set);

            var BookList = new List<Book>();

            BookList = ((IRawGraphClient)client).ExecuteGetCypherResults<Book>(query).ToList();

            BookList.RemoveAll(u => u.Available == 0);

            return BookList;
        }

        public List<Book> ReturnAllBusyBooks()
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>();

            var query = new CypherQuery("START n=node(*) where (n:Book) RETURN n", queryDict, CypherResultMode.Set);

            var BookList = new List<Book>();

            BookList = ((IRawGraphClient)client).ExecuteGetCypherResults<Book>(query).ToList();

            BookList.RemoveAll(u => u.Available > 0);

            return BookList;
        }
        public List<Comment> ReturnAllUnApprovedComments()
        {
            var query = new CypherQuery("MATCH (n:Comment) WHERE (n.IsApproved = false) RETURN n", new Dictionary<string, object>(), CypherResultMode.Set);

            List<Comment> CommentList = ((IRawGraphClient)client).ExecuteGetCypherResults<Comment>(query).ToList();

            return CommentList;
        }

        //UPDDATE
        public void ExtendMembership(User _user)
        {
            // Extends user's membership for a month.
            var query = new CypherQuery("MATCH (a:User {JMBG:'" + _user.JMBG + "'}) SET a.ExpirationDate = '" + _user.ExpirationDate.AddMonths(1).ToString("d") + "'", new Dictionary<string, object>(), CypherResultMode.Set);
            try
            {
                // Izvrsava ga svakako, ali baca exception za deserijalizaciju. A realno nam ne treba nikakav return.
                // => sve regularno
                ((IRawGraphClient)client).ExecuteGetCypherResults<User>(query);
            }
            catch { }

            _user.ExpirationDate = _user.ExpirationDate.AddMonths(1);
        }

        public void ReturnBook(User _user, string _bookTitle)
        {
            //user.RetedBook="" //book.Available ++
            var query = new CypherQuery("MATCH (a:User {JMBG:'" + _user.JMBG + "'})-[r:Rented {IsReturned:false}]->(b:Book {Title:'" + _bookTitle + "'}) SET a.RentedBook = '' SET r.IsReturned = true SET b.Available=b.Available+1", new Dictionary<string, object>(), CypherResultMode.Set);
            try
            {
                // Izvrsava ga svakako, ali baca exception za deserijalizaciju. A realno nam ne treba nikakav return.
                // => sve regularno
                ((IRawGraphClient)client).ExecuteGetCypherResults<User>(query);
            }
            catch { }

            _user.RentedBook = null;
        }

        public void RentBook(User _user, string _bookTitle)
        {
            // This method should only be called before checking if book is available!!!

            //user.book=book //book.kolicina--
            var query = new CypherQuery("MATCH (a:User {JMBG:'" + _user.JMBG + "'}), (b:Book {Title:'" + _bookTitle + "'}) CREATE (a)-[r:Rented {IsReturned:false, DateOfRent:'" + DateTime.Now.ToString("d") + "'}]->(b) SET a.RentedBook = '" + _bookTitle + "' SET b.Available=b.Available-1", new Dictionary<string, object>(), CypherResultMode.Set);
            try
            {
                // Izvrsava ga svakako, ali baca exception za deserijalizaciju. A realno nam ne treba nikakav return.
                // => sve regularno
                ((IRawGraphClient)client).ExecuteGetCypherResults<User>(query);
            }
            catch { }

            _user.RentedBook = _bookTitle;
        }

        public bool IsBookAvailable(string _bookTitle)
        {
            var query = new CypherQuery("MATCH (a:Book {Title:'" + _bookTitle + "'}) RETURN a", new Dictionary<string, object>(), CypherResultMode.Set);

            // Izvrsava ga svakako, ali baca exception za deserijalizaciju. A realno nam ne treba nikakav return.
            // => sve regularno
            try
            {
                var book = ((IRawGraphClient)client).ExecuteGetCypherResults<Book>(query).ToList().First();
                if (book.Available > 0)
                    return true;
            }
            catch { }
            return false;
        }

    }
}
