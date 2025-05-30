using BandsApp.Webb.Models;

namespace BandsApp.Webb.Services;

public class BandService
{

    private List<Band> bands = new()
    {
        new Band {Id = 1, Name = "The Beatles", Description = "Pop and rock band", ImageName = "theBeatles.jpg" },
        new Band {Id = 2, Name = "Abba", Description = "Swedish pop group", ImageName = "abba.jpg" },
        new Band {Id = 3, Name = "Ghost", Description = "Swedish rock" , ImageName = "ghost.jpg"}
    };

    public Band? GetBandById(int id)
    {
        return bands.SingleOrDefault(b => b.Id == id);
    }
 
    public Band[] GetAllBands()
    {
        return bands.ToArray();
    }




}
