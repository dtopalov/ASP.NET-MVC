namespace MvcApp.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Movie
    {
        [Key]
        public int MovieId { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Title must be between 2 and 100 characters long", MinimumLength = 2)]
        public string Title { get; set; }

        [Range(1900, 2020, ErrorMessage = "The year must be between 1900 and 2020")]
        public int Year { get; set; }

        public int? DirectorId { get; set; }

        public virtual Director Director { get; set; }

        public int? MaleActorId { get; set; }

        public virtual MaleActor MaleActor { get; set; }

        public int? FemaleActorId { get; set; }

        public virtual FemaleActor FemaleActor { get; set; }

        public int? StudioId { get; set; }

        public virtual Studio Studio { get; set; }
    }
}
