using System;
using Notes.Persistence;
using Microsoft.EntityFrameworkCore;
using Notes.Domain;

namespace Notes.Test.Common
{
    public class NotesContextFactory
    {
        public static Guid UserAId = Guid.NewGuid();
        public static Guid UserBId = Guid.NewGuid();

        public static Guid NoteIdForDelete = Guid.NewGuid();
        public static Guid NoteIdForUpdate = Guid.NewGuid();

        public static NotesDbContext Create()
        { 
            var options = new DbContextOptionsBuilder<NotesDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            var context = new NotesDbContext(options);
            context.Database.EnsureCreated();
            context.Notes.AddRange(
                new Note
                {
                    CreationDate = DateTime.Today,
                    Details = "Details1",
                    EditTime = null,
                    Id = Guid.Parse("EC63184A-BC4C-47A7-B98C-F8AA22C6C133"),
                    Title = "Title1",
                    UserId = UserAId
                },
                new Note
                {
                    CreationDate = DateTime.Today,
                    Details = "Details2",
                    EditTime = null,
                    Id = Guid.Parse("F0C697B3-0535-4E95-919A-2D9A3FB8C1A6"),
                    Title = "Title2",
                    UserId = UserBId
                },
                 new Note
                 {
                     CreationDate = DateTime.Today,
                     Details = "Details4",
                     EditTime = null,
                     Id = NoteIdForDelete, 
                     Title = "Title3",
                     UserId = UserAId
                 },

                  new Note
                  {
                      CreationDate = DateTime.Today,
                      Details = "Details4",
                      EditTime = null,
                      Id = NoteIdForUpdate, 
                      Title = "Title4",
                      UserId = UserBId
                  }
             );
            context.SaveChanges();
            return context;
        }

        public static void Destroy(NotesDbContext context)
        { 
            context.Database.EnsureDeleted();
            context.Dispose();
        }
    }
}
