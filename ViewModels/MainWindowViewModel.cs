using System.Collections.Generic;

namespace ProDataGridDetailRowSample.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        public List<BookViewModel> Books { get; set; } =
        [
            new()
            {
                Title = "Astérix le gaulois",
                Authors =
                    [
                        new AuthorViewModel() { Name = "René Goscinny"},
                        new AuthorViewModel() {Name = "Albert Uderzo"}
                ],
                InStock = 100

            },
            new()
            {
                Title = "Spiderman",
                Authors =
                [
                    new AuthorViewModel() {Name = "Stan Lee"},
                    new AuthorViewModel() {Name = "Steve Ditko"}
                ],
                InStock = 15
            },
            new()
            {
                Title = "Superman",
                Authors =
                [
                    new(){Name = "Jerry Siegel"},
                    new(){Name = "Joe Shuster"}
                ],
                InStock = 1000
            }
        ];
        
        
    }
        

}
