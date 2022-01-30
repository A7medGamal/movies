﻿using System.ComponentModel.DataAnnotations;

namespace movies.Models
{
    public class Movie
    {
        

        public int Id { get; set; }
        [Required,MaxLength(250)]
        public string Title { get; set; }
        public int Year { get; set; }
        public double Rate { get; set; }
        [Required,MaxLength(2500)]
        public string StoryLine { get; set; }
        [Required]
        public byte[] Poster { get; set; }
        public int GenreId { get; set; }
        public genre Genre { get; set; }


    }
}