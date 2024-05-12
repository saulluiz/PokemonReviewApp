using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface IReviwerRepository
    {
        ICollection<Reviewer> GetReviewers();
        Reviewer GetReviewer(int reviewerId);
        ICollection<Review> GetReviewsByReviewer(int reviewerId);
        bool ReviewerExists(int reviewerId);
    }
}
