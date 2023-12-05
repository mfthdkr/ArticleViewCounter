using ArticleViewCounter.DTOs.ViewModels;
using ArticleViewCounter.Entities;
using AutoMapper;

namespace ArticleViewCounter.Mappings
{
    public class ArticleProfile : Profile
    {
        public ArticleProfile()
        {
            CreateMap<Article,ArticleDetailVM>();
            CreateMap<Article,ArticleVM>();
        }
    }
}
