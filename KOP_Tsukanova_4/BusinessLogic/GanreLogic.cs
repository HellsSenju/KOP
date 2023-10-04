using Contracts.Ganre;

namespace BusinessLogic
{
    public class GanreLogic : IGanreLogic
    {
        private readonly IGanreStorage _ganreStorage;

        public GanreLogic(IGanreStorage skillStorage)
        {
            _ganreStorage = skillStorage;
        }

        public void CreateOrUpdate(GanreBindingModel model)
        {
            var element = _ganreStorage.GetElement(
                new GanreBindingModel
                {
                    Name = model.Name
                });
            if (element != null && element.Id != model.Id)
            {
                throw new Exception("Такой Жанр уже существует");
            }
            if (model.Id.HasValue)
            {
                _ganreStorage.Update(model);
            }
            else
            {
                _ganreStorage.Insert(model);
            }
        }

        public void Delete(GanreBindingModel model)
        {
            var element = _ganreStorage.GetElement(new GanreBindingModel { Id = model.Id });
            if (element == null)
            {
                throw new Exception("Жанр не найден");
            }
            _ganreStorage.Delete(model);
        }

        public List<GanreViewModel> Read(GanreBindingModel model)
        {
            if (model == null)
            {
                return _ganreStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<GanreViewModel> { _ganreStorage.GetElement(model) };
            }
            return _ganreStorage.GetFilteredList(model);
        }
    }
}
