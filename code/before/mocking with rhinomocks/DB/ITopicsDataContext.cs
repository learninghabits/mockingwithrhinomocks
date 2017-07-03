using System.Data.Entity;

namespace mocking_with_rhinomocks.DB
{
    public interface ITopicsDataContext
    {
        IDbSet<Topic> Topics { get; set; }
        IDbSet<Tutorial> Tutorials { get; set; }
    }
}
