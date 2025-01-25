using MicrosoftWebSite.Business.Dtos;

namespace MicrosoftWebSite.Business.Interfaces;

public interface IHomeService
{
    HomeDto getHomeInfo();
}