using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace Notes.Application.Common.Mapping
{
    public interface IMapWith<T>
    {
        void MapWith(Profile profile) => profile.CreateMap(typeof(T), GetType());
    }
}
