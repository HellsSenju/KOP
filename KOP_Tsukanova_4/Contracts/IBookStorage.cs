namespace Contracts
{
    public interface IBookStorage
    {
        List<BookViewModel> GetFullList();
        List<BookViewModel> GetFilteredList(BookBindingModel model);
        BookViewModel GetElement(BookBindingModel model);

        void Insert(BookBindingModel model);
        void Update(BookBindingModel model);
        void Delete(BookBindingModel model);
    }
}
