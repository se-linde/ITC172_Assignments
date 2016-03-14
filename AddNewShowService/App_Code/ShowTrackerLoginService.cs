using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ShowTrackerLoginService" in code, svc and config file together.
public class ShowTrackerLoginService : IShowTrackerLoginService
{

    ShowTrackerEntities db = new ShowTrackerEntities();


    public int VenueLogin(string password, string username)
    {
        int result = db.usp_venueLogin(username, password);
        if (result != -1)
        {
            var key = from k in db.VenueLogins
                      where k.VenueLoginUserName.Equals(username)
                      select new { k.VenueLoginKey };
            foreach (var k in key)
            {
                result = (int)k.VenueLoginKey;
            }
        }

        return result;
    }

    public int VenueRegistration(VenueLite r)
    {
        int result = db.usp_RegisterVenue(r.VenueName, r.VenueAddress, r.VenueCity, r.VenueState, r.VenueZipCode, r.VenuePhone, r.VenueEmail, r.VenueWebPage, r.VenueAgeRestriction, r.VenueLoginUserName, r.VenueLoginPasswordPlain);

        return result;
    }
    public int FanLogin(string password, string username)
    {
        int result = db.usp_FanLogin(username, password);
        if (result != -1)
        {
            var key = from k in db.FanLogins
                      where k.FanLoginUserName.Equals(username)
                      select new { k.FanLoginKey };
            foreach (var k in key)
            {
                result = (int)k.FanLoginKey;
            }
        }

        return result;
    }

    public int FanRegistration(FanLite r)
    {
        int result = db.usp_RegisterFan(r.FanName, r.FanEmail, r.FanLoginUserName, r.FanLoginPasswordPlain);

        return result;
    }

    public int AddShow(NewShow ns)
    {
        Show show = new Show();
        ShowDetail showDetail = new ShowDetail();

        show.ShowName = ns.ShowName;
        show.VenueKey = int.Parse(ns.VenueKey);
        show.ShowDate = DateTime.Parse(ns.ShowDate);
        show.ShowTime = TimeSpan.Parse(ns.ShowTime);
        show.ShowTicketInfo = ns.ShowTicketInfo;
        show.ShowDateEntered = DateTime.Now;

        showDetail.Show = show;
        showDetail.ShowDetailArtistStartTime = TimeSpan.Parse(ns.ShowDetailArtistStartTime);
       // showDetail.ShowKey = int.Parse(ns.ShowKey);
        showDetail.ArtistKey = int.Parse(ns.AritstKey);
        showDetail.ShowDetailAdditional = ns.ShowDetailAdditional;

        db.Shows.Add(show);
        db.SaveChanges();

        db.ShowDetails.Add(showDetail);
        db.SaveChanges();

        return 0;
    }

    public int AddArtist(NewArtist na)
    {
        Artist a = new Artist();
        a.ArtistName = na.ArtistName;
        a.ArtistEmail = na.ArtistEmail;

        db.Artists.Add(a);
        db.SaveChanges();

        return 0;
    }

    public List<string> GetArtists()
    {
        var arts = from a in db.Artists
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
        var ven = from a in db.Venues
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
        var shs = from a in db.Shows
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
        var shws = from s in db.Shows
                   where s.Venue.VenueName.Equals(venueName)
                   select new { s.ShowName, s.ShowTime, s.ShowDate };

        List<VenueShow> venues = new List<VenueShow>();

        foreach (var a in shws)
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
        var shws = from s in db.Shows
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
 /*   public int ShowRegistration(NewShow ns)
    {
        //int result = db.usp_RegisterVenue(r.VenueName, r.VenueAddress, r.VenueCity, r.VenueState, r.VenueZipCode, r.VenuePhone, r.VenueEmail, r.VenueWebPage, r.VenueAgeRestriction, r.VenueLoginUserName, r.VenueLoginPasswordPlain);
        

        return result;
    }
    public int ShowDetailRegistration(ShowDetail sd)
    {
        //int result = db.usp_RegisterVenue(r.VenueName, r.VenueAddress, r.VenueCity, r.VenueState, r.VenueZipCode, r.VenuePhone, r.VenueEmail, r.VenueWebPage, r.VenueAgeRestriction, r.VenueLoginUserName, r.VenueLoginPasswordPlain);

        return result;
    }
  */
}
