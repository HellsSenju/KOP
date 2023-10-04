namespace Contracts.Ganre
{
    public interface IGanreStorage
    {
        List<GanreViewModel> GetFullList();
        List<GanreViewModel> GetFilteredList(GanreBindingModel model);
        GanreViewModel GetElement(GanreBindingModel model);

        void Insert(GanreBindingModel model);
        void Update(GanreBindingModel model);
        void Delete(GanreBindingModel model);
    }
}
