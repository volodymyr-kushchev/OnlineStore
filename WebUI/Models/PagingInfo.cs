using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI.Models
{
    public class PagingInfo
    {
        public int TotalItems { get; set; }     // Numbers of all books
        public int ItemsPerPage { get; set; }   // Numbers books per one page
        public int CurrentPage { get; set; }    // Current page number
        public int TotalPages 
        {
            get { return (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage); }
        }
    }
}