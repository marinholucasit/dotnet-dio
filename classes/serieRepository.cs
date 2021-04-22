using System.Collections.Generic;
using Series.interfaces;

namespace Series
{
  public class serieRepository : IRepository<Serie>
  {
      private List<Serie> seriesList = new List<Serie>();

    public void Add(Serie entity)
    {
      seriesList.Add(entity);
    }

    public void Delete(int id)
    {
      seriesList[id].Delete();
    }

    public Serie FindById(int id)
    {
      return seriesList[id];
    }

    public List<Serie> List()
    {
      return seriesList;
    }

    public int NextId()
    {
      return seriesList.Count;
    }

    public void Update(int id, Serie entity)
    {
      seriesList[id] = entity;
    }
  }
}