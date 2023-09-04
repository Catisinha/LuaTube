using LuaTube.Models;

namespace LuaTube.Interfaces;

public interface IVideoRepository : IRepository<Video>
{
    List<Video> ReadAllDetailed();

    Video ReadByIdDetailed(int id);
}