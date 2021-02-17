using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1
{
    public partial class Form1 : Form
    {
        //parallel arrays of book information
        string[] bookNames = { "The Great Gatsby", "War and Peace", "Moby - Dick", "Hamlet", " Pride and Prejudice" };
        string[] bookDescriptions = { "The story of eccentric millionaire Jay Gatsbyand his pursuit of his lost love.", "A fictional story about the 1812 Frenchinvasion of Russia.", "The story of a sailor’s relentless hunt for awhite whale.", "A Shakespearean tragedy about a youngman coming home from college after the murder of his father.", "A comedic story of love and life in Old England." };
        string[] bookAuthors = { "F. Scott Fitzgerald", "Leo Tolstoy", "Herman Melville", "William Shakespeare", "Jane Austen" };
        string[] isbns = { "978-1847496140", "978-1400079988", "978-1503280786", "978-1973844402", "978-0141439518" };
        public Form1()
        {
            InitializeComponent();
        }

        //Event Handlers
        private void btnAuthor_Click(object sender, EventArgs e)
        {
            string authorSearch = txtBoxAuthor.Text;
            int authorPosition = SearchByAuthor(authorSearch);
            ShowBook(authorPosition);
        }

        private void btnISBN_Click(object sender, EventArgs e)
        {
            int isbnPosition = SearchByIsbn(txtBoxISBN.Text);
            ShowBook(isbnPosition);
        }

        private void btnKeyword_Click(object sender, EventArgs e)
        {
            ShowBook(SearchByKeyword(txtBoxKeyword.Text));
        }

        //custom methods

        private int SearchByAuthor(string authorName)
        {
            //assume the author is NOT found with a local variable
            int authorIndex = -1;

            //search the array with a loop
            for (int i = 0; i < bookAuthors.Length; i++)
            {
                if(bookAuthors[i].ToLower().Contains(authorName.ToLower()))
                {
                    //if author is found set the position of the author in the array
                    authorIndex = i;
                }
            }


            return authorIndex;
            //return the position
        }

        private int SearchByIsbn(string isbn)
        {
            int isbnIndex = -1;

            for (int i = 0; i < isbns.Length; i++)
            {
                if(isbns[i].Equals(isbn))
                {
                    isbnIndex = i;
                }
            }

            return isbnIndex;
        }

        private int SearchByKeyword(string keyword)
        {
            int bookPosition = -1;

            //searches book names and book descriptions
            for (int i = 0; i < bookNames.Length; i++)
            {
                if(bookNames[i].ToLower().Contains(keyword.ToLower()) || bookDescriptions[i].ToLower().Contains(keyword.ToLower()))
                {
                    //book found
                    bookPosition = i;
                }
            }

            return bookPosition;
        }

        private void ShowBook(int bookIndex)
        {
            if(bookIndex == -1)
            {
                //book not found
                lblAuthor.Text = "Item Not Found";
                lblDescip.Text = "Item Not Found";
                lblISBN.Text = "Item Not Found";
                lblName.Text = "Item Not Found";
            }
            else
            {
                //book found
                //output book
                lblAuthor.Text = bookAuthors[bookIndex];
                lblDescip.Text = bookDescriptions[bookIndex];
                lblISBN.Text = isbns[bookIndex];
                lblName.Text = bookNames[bookIndex];
            }
        }
    }
}
