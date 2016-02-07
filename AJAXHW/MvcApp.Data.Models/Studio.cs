namespace MvcApp.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Studio
    {
        private ICollection<Movie> movies;

        public Studio()
        {
            this.movies = new HashSet<Movie>();
        }

        [Key]
        public int StudioId { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Name must be between 2 and 100 characters long", MinimumLength = 2)]
        public string Name { get; set; }

        [Required]
        [StringLength(300, ErrorMessage = "Address must be between 10 and 300 characters long", MinimumLength = 10)]
        public string Address { get; set; }

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