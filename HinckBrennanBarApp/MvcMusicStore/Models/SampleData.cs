using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcMusicStore.Models
{
    public class SampleData : DropCreateDatabaseAlways<MusicStoreEntities>
    {
        protected override void Seed(MusicStoreEntities context)
        {
            var genres = new List<Genre>
            {
                new Genre { Name = "Cocktail" },
                new Genre { Name = "Beer" },
                new Genre { Name = "Wine" }
            };


            var artists = new List<Artist>
            {
                new Artist { Name = "Whiskey" },
                new Artist { Name = "Pabst" },
                new Artist { Name = "White Wine" },
                new Artist { Name = "Tequila" },
                new Artist { Name = "Red Wine" },
                
            };

            new List<Album>
            {
                new Album { Title = "PBR", Genre = genres.Single(g => g.Name == "Beer"), Price = 1.99M, Artist = artists.Single(a => a.Name == "Pabst"), AlbumArtUrl = "/Content/Images/pbr.png" },
                new Album { Title = "Old Fashioned", Genre = genres.Single(g => g.Name == "Cocktail"), Price = 3.99M, Artist = artists.Single(a => a.Name == "Whiskey"), AlbumArtUrl = "/Content/Images/oldFashioned.png" },
                new Album { Title = "Pinot Grigio", Genre = genres.Single(g => g.Name == "Wine"), Price = 4.99M, Artist = artists.Single(a => a.Name == "White Wine"), AlbumArtUrl = "/Content/Images/pinot.png" },
                new Album { Title = "Margarita", Genre = genres.Single(g => g.Name == "Cocktail"), Price = 6.99M, Artist = artists.Single(a => a.Name == "Tequila"), AlbumArtUrl = "/Content/Images/margarita.png" },
                new Album { Title = "Cabernet", Genre = genres.Single(g => g.Name == "Wine"), Price = 6.99M, Artist = artists.Single(a => a.Name == "Red Wine"), AlbumArtUrl = "/Content/Images/redWine.png" },
            }.ForEach(a => context.Albums.Add(a));
        }
    }
}