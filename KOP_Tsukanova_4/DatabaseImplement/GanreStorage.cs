using Contracts.Ganre;

namespace DatabaseImplement
{
    public class GanreStorage : IGanreStorage
    {
        public void Delete(GanreBindingModel model)
        {
            var context = new Database();
            var ganre = context.Ganres.FirstOrDefault(rec => rec.Id == model.Id);
            if (ganre != null)
            {
                context.Ganres.Remove(ganre);
                context.SaveChanges();
            }
            else
                throw new Exception("Жанр не найден");
        }

        public GanreViewModel GetElement(GanreBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using var context = new Database();

            var ganre = context.Ganres
                    .ToList()
                    .FirstOrDefault(rec => rec.Id == model.Id || rec.Name == model.Name);
            return ganre != null ? CreateModel(ganre) : null;
        }

        public List<GanreViewModel> GetFilteredList(GanreBindingModel model)
        {
            if (model == null)
                return null;

            using var context = new Database();
            return context.Ganres
                .Where(rec => rec.Name.Contains(model.Name))
                .Select(CreateModel)
                .ToList();
        }

        public List<GanreViewModel> GetFullList()
        {
            using var context = new Database();
            return context.Ganres
                .Select(CreateModel)
                .ToList();
        }

        public void Insert(GanreBindingModel model)
        {
            var context = new Database();
            var transaction = context.Database.BeginTransaction();
            try
            {
                context.Ganres.Add(CreateModel(model, new Ganre()));
                context.SaveChanges();
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }

        public void Update(GanreBindingModel model)
        {
            var context = new Database();
            var transaction = context.Database.BeginTransaction();
            try
            {
                var skill = context.Ganres.FirstOrDefault(rec => rec.Id == model.Id);
                if (skill == null)
                {
                    throw new Exception("Жанр не найден");
                }
                CreateModel(model, skill);
                context.SaveChanges();
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }

        private static Ganre CreateModel(GanreBindingModel model, Ganre ganre)
        {
            ganre.Name = model.Name;
            return ganre;
        }

        private static GanreViewModel CreateModel(Ganre ganre)
        {
            return new GanreViewModel
            {
                Id = ganre.Id,
                Name = ganre.Name
            };
        }
    }
}
