using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProDataGridDetailRowSample.ViewModels
{
    public class BookViewModel
    {
        public string Title { get; set; }
        public List<AuthorViewModel> Authors {get;set;} = [];
        public int InStock {  get; set; }
    }

    public class AuthorViewModel
    {
        public string Name { get; set; }
    }
}
