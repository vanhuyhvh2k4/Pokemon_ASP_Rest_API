using PokemonReview.App.Models;

namespace PokemonReview.App.Interfaces
{
    public interface IReviewerRepository
    {
        ICollection<Reviewer> GetReviewers();

        Reviewer GetReviewer(int id);

        bool ReviewerExists(int reviewerId);

        ICollection<Review> GetReviewsByReviewerId(int reviewerId);

        bool CreateReviewer(Reviewer reviewer);

        bool UpdateReviewer(Reviewer reviewer);

        bool DeleteReviewer(Reviewer reviewer);

        bool Save();
    }
}
