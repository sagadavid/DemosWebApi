using NuGet.Protocol;

namespace FirstWebApi.Models;

public class PostService : IPostService
{
  private static readonly List<Post> AllPosts = new();//an empty list ready to be added

  public Task CreatePost(Post item)
  {
    AllPosts.Add(item);
    return Task.CompletedTask;
  }

  public Task<List<Post>> GetAllPosts()
  {
    return Task.FromResult(AllPosts);
  }

  public Task<Post?> GetPost(int id)
  {

    return Task.FromResult(AllPosts.FirstOrDefault(x => x.Id == id));
  }

  public Task DeletePost(int id)
  {
    var toDelete = AllPosts.FirstOrDefault(x => x.Id == id);
    if (toDelete != null) { AllPosts.Remove(toDelete); }
    return Task.CompletedTask;
  }

  public Task<Post?> UpdatePost(int id, Post item)
  {
    var toUpdate = AllPosts.FirstOrDefault(x => x.Id == id);
    if (toUpdate != null)
    {
      toUpdate.Body = item.Body;
      toUpdate.Title = item.Title;
      toUpdate.UserId = item.UserId;
    }
    return Task.FromResult(toUpdate);
  }
}
