using BookStore.Services.BookAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Services.BookAPI.EntityTypeConfiguration
{
    public class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.HasData(new Genre[] {
                new Genre() {Id = 1, Name = "History", Description = 
                "Nonfiction history books include any books that lay out the " +
                "known facts about a particular, time, culture, or event in history."},

                new Genre() {Id = 2, Name = "Memoir", Description =
                "Memoirs are one type of autobiography. In this type of book, " +
                "the author puts emphasis on specific moments or events that " +
                "brought about specific life lessons. "},

                new Genre() {Id = 3, Name = "Politics", Description =
                "Political nonfiction books can include books written by career politicians, " +
                "books that explore political systems, or books that discuss the " +
                "politics of a certain period."},

                new Genre() {Id = 4, Name = "Self-Help", Description =
                "Self-help books aim to aid the reader in improving some part of her life. " +
                "Common topics covered by self-help books include relationships, " +
                "finances, and mental health. "},

                new Genre() {Id = 5, Name = "Crime Thriller", Description =
                "Thrillers are suspenseful stories, which makes a crime thriller a book " +
                "that has a crime as its main subject while keeping readers on edge. " +
                "The main characters are often fighting for justice."},

                new Genre() {Id = 6, Name = "Science Fiction", Description =
                "Also known as Sci-Fi, science fiction deals with the imagined future " +
                "in terms of science or technology advances. This genre includes things " +
                "like time travel, outer space, and intelligent life."},

                new Genre() {Id = 7, Name = "Humor", Description =
                "The world can be a dark place at times, and we all need something light-hearted to " +
                "entertain and distract us. Happily, there are a host of witty, satirical and downright hilarious books out there, " +
                "waiting to put a smile back on our face."},

                new Genre() {Id = 8, Name = "Horror", Description =
                "Horror is a genre of literature, film, and television that is meant to scare," +
                " startle, shock, and even repulse audiences. The key focus of a horror novel, " +
                "horror film, or horror TV show is to elicit a sense of dread in the reader through frightening images, themes, and situations."},

                new Genre() {Id = 9, Name = "Classic", Description =
                "A classic book can be simply defined as a book which has been recognized by " +
                "critics and the public to be excellent, and a “must-read.” Traditionally, " +
                "the term was only used to describe books originally written in Greek or Latin, but " +
                "the definition has been expanded to include books written in all languages."},

                new Genre() {Id = 10, Name = "Biography", Description =
                "A biography is simply the story of a real person's life. It could " +
                "be about a person who is still alive, someone who lived centuries ago," +
                " someone who is globally famous, an unsung hero forgotten by history, " +
                "or even a unique group of people."},
            });
        }
    }
}
