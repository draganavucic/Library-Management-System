using ELibrary.Models;
using Neo4jClient;
using Neo4jClient.Cypher;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELibrary
{
    public partial class Login : Form
    {
        string user;
        string pass;
        private GraphClient client;

        public Login()
        {
            InitializeComponent();

            try
            {
                client = new GraphClient(new Uri("http://localhost:7474/db/data"), "neo4j", "neo4jn");
                client.Connect();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            user = tbUsername.Text;
            pass = tbPassword.Text;

            //Static instance of Librarian, used to call methods from every Form, and remember which Librarian is loged in.
            //Originately declared in Program.cs
            Program.librarian = getLibrarian(user, pass);
            
            if (Program.librarian != null)
            {
                Program.librarian.client = client;
                Hide();
                var lm = new LibrarianMain();
                lm.ShowDialog();
                Close();
            }
        }

        public Librarian getLibrarian(string user, string pass)
        {
            var query = new CypherQuery("MATCH (n:Librarian) WHERE(n.Username = \"" + user + "\" and n.Password = \"" + pass + "\") return n", new Dictionary<string, object>(), CypherResultMode.Set);
            Librarian result = null;
            try
            {
                result = ((IRawGraphClient)client).ExecuteGetCypherResults<Librarian>(query).ToList().First();
            }
            catch
            {
                MessageBox.Show("Error! User not found!");
            }
            return result;
        }
    }
}
