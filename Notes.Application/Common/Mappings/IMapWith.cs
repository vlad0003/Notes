using AutoMapper;

namespace Notes.Application.Common.Mapping
{
    public interface IMapWith<T>
    {
        void MapWith(Profile profile) => profile.CreateMap(typeof(T), GetType());
    }
}
