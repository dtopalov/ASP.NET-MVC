namespace MvcApp.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class MaleActor
    {
        private ICollection<Movie> movies;

        public MaleActor()
        {
            this.movies = new HashSet<Movie>();    
        }

        [Key]
        public int MaleActorId { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "First name must be between 2 and 30 characters long", MinimumLength = 2)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Last name be between 2 and 30 characters long", MinimumLength = 2)]
        public string LastName { get; set; }

        public DateTime? BirthDate { get; set; }

        public virtual ICollection<Movie> Movies {
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