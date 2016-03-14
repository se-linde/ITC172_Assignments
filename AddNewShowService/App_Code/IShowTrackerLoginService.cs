using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IShowTrackerLoginService" in both code and config file together.
[ServiceContract]
public interface IShowTrackerLoginService
{
    [OperationContract]
    int VenueLogin(string password, string username);

    [OperationContract]
    int VenueRegistration(VenueLite r);

    [OperationContract]
    int AddArtist(NewArtist na);

    [OperationContract]
    int FanLogin(string password, string username);

    [OperationContract]
    int FanRegistration(FanLite r);

    [OperationContract]
    int AddShow(NewShow ns);

    [OperationContract]
    List<string> GetArtists();

    [OperationContract]
    List<string> GetVenue();

    [OperationContract]
    List<string> GetShow();

    [OperationContract]
    List<VenueShow> GetShowsByVenue(string venueName);

    [OperationContract]
    List<ArtistShows> GetShowsByArtist(string artistName);

}

[DataContract]
public class VenueLite
{
    [DataMember]
    public string VenueName { set; get; }

    [DataMember]
    public string VenueAddress { set; get; }

    [DataMember]
    public string VenueCity { set; get; }

    [DataMember]
    public string VenueState { set; get; }

    [DataMember]
    public string VenueZipCode { set; get; }

    [DataMember]
    public string VenuePhone { set; get; }

    [DataMember]
    public string VenueEmail { set; get; }

    [DataMember]
    public string VenueWebPage { set; get; }

    [DataMember]
    public int VenueAgeRestriction { set; get; }

    [DataMember]
    public string VenueLoginUserName { set; get; }

    [DataMember]
    public string VenueLoginPasswordPlain { set; get; }

}

[DataContract]
public class NewArtist
{
    [DataMember]
    public string ArtistName { set; get; }

    [DataMember]
    public string ArtistEmail { set; get; }

    [DataMember]
    public List<string> Artists { set; get; }

}

[DataContract]
public class FanLite
{
    [DataMember]
    public string FanName { set; get; }

    [DataMember]
    public string FanEmail { set; get; }

    [DataMember]
    public string FanLoginUserName { get; set; }

    [DataMember]
    public string FanLoginPasswordPlain { get; set; }
}

[DataContract]
public class NewShow
{
    [DataMember]
    public string ShowName { set; get; }

    [DataMember]
    public string VenueKey { set; get; }

    [DataMember]
    public string ShowKey { set; get; }

    [DataMember]
    public string ShowDate { set; get; }

    [DataMember]
    public string ShowTime { set; get; }

    [DataMember]
    public string ShowTicketInfo { set; get; }
    
    [DataMember]
    public string ShowDateEntered { set; get; }

    [DataMember]
    public string ShowDetailArtistStartTime { set; get; }

    [DataMember]
    public string ShowDetailAdditional { set; get; }

    [DataMember]
    public List<String> ShowDetails { set; get; }

    [DataMember]
    public string AritstKey { set; get; }

    [DataMember]
    public List<String> Shows { set; get; }


}

[DataContract]
public class VenueShow
{
    public string Name { set; get; }

    [DataMember]
    public string Date { set; get; }

    [DataMember]
    public string Time { set; get; }

}

[DataContract]
public class ArtistShows
{
    public string Name { set; get; }

    [DataMember]
    public string Date { set; get; }

    [DataMember]
    public string Time { set; get; }

    [DataMember]
    public string Venue { set; get; }

}