namespace MvcApp.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Director
    {
        private ICollection<Movie> movies;

        public Director()
        {
            this.movies = new HashSet<Movie>();
        }

        [Key]
        public int DirectorId { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "First name must be between 2 and 30 characters long", MinimumLength = 2)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Last name be between 2 and 30 characters long", MinimumLength = 2)]
        public string LastName { get; set; }

        [Required]
        public Gender Gender { get; set; }

        public DateTime? BirthDate { get; set; }

        public virtual ICollection<Movie> Movies
        {
            get
            {
                return this.movies;
            }
            set
            {
                this.movies = value;
            }
        }
    }
}