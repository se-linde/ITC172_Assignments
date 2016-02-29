using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IService
{
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