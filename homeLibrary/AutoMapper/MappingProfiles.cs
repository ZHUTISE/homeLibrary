using AutoMapper;
using homeLibrary.Models;
using HomeLibrary.DTO;

namespace HomeLibrary.AutoMapper
{
	public class MappingProfiles : Profile
	{
		public MappingProfiles()
		{
			CreateMap<Book, BookDTO>();
			CreateMap<Author, AuthorDTO>();
			CreateMap<Form, FormDTO>();
			CreateMap<Status, StatusDTO>();
			CreateMap<VolumeSet, VolumeSetDTO>();
		}
	}
}

