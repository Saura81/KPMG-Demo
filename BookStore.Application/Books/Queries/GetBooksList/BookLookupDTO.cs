﻿using AutoMapper;
using BookStore.Application.Common.Mappings;
using BookStore.Domain.Entities;

namespace BookStore.Application.Books.Queries.GetBooksList
{
    public class BookLookupDTO : IMapFrom
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public AuthorDTO Author { get; set; }

        public int AuthorId { get; set; }

        public string ISBN { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Book, BookLookupDTO>();
        }
    }
}