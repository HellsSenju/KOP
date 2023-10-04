namespace Contracts.Book
{
    public interface IBookLogic
    {
        List<BookViewModel> Read(BookBindingModel model);
        void CreateOrUpdate(BookBindingModel model);
        void Delete(BookBindingModel model);
    }
}
