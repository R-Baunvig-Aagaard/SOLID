using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle
{
    public interface ILibraryItem
    {
        string Title { get; set; }
        string LibraryId { get; set; }
        //string Author { get; set; }
        //int Pages { get; set; }
        //DateTime BorrowDate { get; set; }
        //string Borrower { get; set; }
        //int CheckOutDurationInDays { get; set; }
        //string LibraryId { get; set; }
        //void CheckIn();
        //void CheckOut(string borrower);
        //DateTime GetDueDate();


    }
}
