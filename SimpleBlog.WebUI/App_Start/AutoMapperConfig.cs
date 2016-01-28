using AutoMapper;
using SimpleBlog.DAL.Object_Model;
using SimpleBlog.DAL.ViewModel;

namespace SimpleBlog.WebUI
{
    /// <summary>
    /// Mapping Types
    /// </summary>
    public class AutoMapperConfig
    {
        /// <summary>
        /// Registers the mappings.
        /// </summary>
        public static void RegisterMappings()
        {
            Mapper.CreateMap<Post, PostViewModel>().ReverseMap();
            Mapper.CreateMap<Tag, TagViewModel>().ReverseMap();
            Mapper.CreateMap<ApplicationUser, UserViewModel>().ReverseMap();
        } 
    }
}