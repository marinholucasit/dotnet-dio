using System.Collections.Generic;
using Series.interfaces;

namespace Series
{
  public class serieRepository : IRepository<Serie>
  {
      private List<Serie> seriesList = new List<Serie>();

    public void Add(Serie entity)
    {
      throw new System.NotImplementedException();
    }

    public void Delete(int id)
    {
      throw new System.NotImplementedException();
    }

    public Serie FindById(int id)
    {
      throw new System.NotImplementedException();
    }

    public List<Serie> List()
    {
      throw new System.NotImplementedException();
    }

    public int NextId()
    {
      throw new System.NotImplementedException();
    }

    public void Update(int id, Serie entity)
    {
      throw new System.NotImplementedException();
    }
  }
}