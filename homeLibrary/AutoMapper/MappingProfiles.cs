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
		}
	}
}

