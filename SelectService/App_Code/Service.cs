using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    ShowTrackerEntities ste = new ShowTrackerEntities();
    public List<string> GetArtists()
    {
        var arts = from a in ste.Artists
                   orderby a.ArtistName
                   select new { a.ArtistName };


        List<string> artists = new List<string>();
        foreach (var ar in arts)
        {
            artists.Add(ar.ArtistName.ToString());//it 
        }

        return artists;//it will return all the authors
    }


    public List<string> GetVenue()
    {
        var ven = from a in ste.Venues
                  orderby a.VenueName
                  select new { a.VenueName };


        List<string> venues = new List<string>();
        foreach (var ve in ven)
        {
            venues.Add(ve.VenueName.ToString());//it 
        }

        return venues;//it will return all the authors
    }


    public List<string> GetShow()
    {
        var shs = from a in ste.Shows
                  orderby a.ShowName
                  select new { a.ShowName };


        List<string> shows = new List<string>();
        foreach (var sh in shs)
        {
            shows.Add(sh.ShowName.ToString());//it 
        }

        return shows;//it will return all the authors
    }


    public List<VenueShow> GetShowsByVenue(string venueName)
    {
        var shws = from s in ste.Shows
                   where s.Venue.VenueName.Equals(venueName)
                   select new { s.ShowName, s.ShowTime, s.ShowDate };

        List<VenueShow> venues =  new List<VenueShow>();

        foreach (var a in shws )
        {
        VenueShow vlite = new VenueShow();
        vlite.Name = a.ShowName;
        vlite.Time = a.ShowTime.ToString();
        vlite.Date = a.ShowDate.ToShortDateString();

        venues.Add(vlite);
        
        }
        return venues;
    }

    public List<ArtistShows> GetShowsByArtist(string artistName)
    {
        var shws = from s in ste.Shows
                   from sd in s.ShowDetails
                   where sd.Artist.ArtistName.Equals(artistName)
                   select new { s.ShowName, s.ShowTime, s.ShowDate, s.Venue.VenueName };

        List<ArtistShows> ArtistShows = new List<ArtistShows>();

        foreach (var a in shws)
        {
            ArtistShows alite = new ArtistShows();
            alite.Name = a.ShowName;
            alite.Time = a.ShowTime.ToString();
            alite.Date = a.ShowDate.ToShortDateString();
            alite.Venue = a.VenueName;

            ArtistShows.Add(alite);

        }
        return ArtistShows;
    }
}

