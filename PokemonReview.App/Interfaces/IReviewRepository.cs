﻿using PokemonReview.App.Models;

namespace PokemonReview.App.Interfaces
{
    public interface IReviewRepository
    {
        ICollection<Review> GetReviews();

        Review GetReview(int id);

        bool ReviewExists(int reviewId);

        ICollection<Review> GetReviewOfAPokemon(int pokeId);

        bool CreateReview(Review review);

        bool UpdateReview(Review review);

        bool DeleteReview(Review review);

        bool Save();
    }
}
