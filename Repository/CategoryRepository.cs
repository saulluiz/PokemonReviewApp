using PokemonReviewApp.Data;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DataContext _context;

        public CategoryRepository(DataContext context)
        {
            this._context = context;
        }
        public bool CategoryExist(int id)
        {
            return _context.Categories.Any(c => c.Id == id);
            //essa forma pode estar errada, eu fiz diferente do instrutor, mas preciso testar ela
           
        }

        public ICollection<Category> GetCategories()
        {
          return _context.Categories.OrderBy(c=>c.Name).ToList  ();
        }

        public Category GetCategory(int id)
        {
            return _context.Categories.Where(e => e.Id == id).FirstOrDefault();
        }

        public ICollection<Pokemon> GetPokemonByCategory(int categoryId)
        {
            return _context.PokemonCategories.Where(c=>c.CategoryId==categoryId).Select(c=>c.Pokemon).ToList ();

        }
    }
}
