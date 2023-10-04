namespace Contracts.Ganre
{
    public interface IGanreLogic
    {
        List<GanreViewModel> Read(GanreBindingModel model);
        void CreateOrUpdate(GanreBindingModel model);
        void Delete(GanreBindingModel model);
    }
}
