namespace MvcApp.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;

    using MvcApp.Data.Models;

    public class MovieViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Title must be between 2 and 100 characters long", MinimumLength = 2)]
        public string Title { get; set; }

        [Range(1900, 2020, ErrorMessage = "The year must be between 1900 and 2020")]
        public int Year { get; set; }

        public string DirectorName { get; set; }

        public int? DirectorId { get; set; }

        public string MaleActorName { get; set; }

        public int? MaleActorId { get; set; }

        public string FemaleActorName { get; set; }

        public int? FemaleActorId { get; set; }

        public string StudioName { get; set; }

        public int? StudioId { get; set; }

        [UIHint("MovieMaleActor")]
        public MaleActorViewModel MaleActor { get; set; }

        [UIHint("MovieFemaleActor")]
        public FemaleActorViewModel FemaleActor { get; set; }

        [UIHint("MovieStudio")]
        public StudioViewModel Studio { get; set; }

        [UIHint("Director")]
        public DirectorViewModel Director { get; set; }
    }
}