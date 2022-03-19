using System;
using AutoMapper;
using Notes.Application.Interfaces;
using Notes.Application.Common.Mapping;
using Notes.Persistence;
using Xunit;

namespace Notes.Test.Common
{
    public class QueryTestFixture : IDisposable
    {
        public INotesDbContext Context;
        public IMapper Mapper;

        public QueryTestFixture()
        {
            Context = NotesContextFactory.Create();
            var configurationProvidr = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AssemblyMappingProfile(
                    typeof(INotesDbContext).Assembly));
            });
            Mapper = configurationProvidr.CreateMapper();
        }

        public void Dispose()
        {
            NotesContextFactory.Destroy((NotesDbContext)Context);
        }

        [CollectionDefinition("QueryCollection")]
        public class QueryCollection : ICollectionFixture<QueryTestFixture> { }
    }
}
