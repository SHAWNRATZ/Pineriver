using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace PineriverASPNETPage.Models
{
    [XmlRoot(ElementName = "groupDetails")]
    public class GroupDetails
    {
        [XmlElement(ElementName = "groupName")]
        public string GroupName { get; set; }
        [XmlElement(ElementName = "groupURL")]
        public string GroupURL { get; set; }
        [XmlElement(ElementName = "headline")]
        public string Headline { get; set; }
        [XmlElement(ElementName = "summary")]
        public string Summary { get; set; }
        [XmlElement(ElementName = "avatarIcon")]
        public string AvatarIcon { get; set; }
        [XmlElement(ElementName = "avatarMedium")]
        public string AvatarMedium { get; set; }
        [XmlElement(ElementName = "avatarFull")]
        public string AvatarFull { get; set; }
        [XmlElement(ElementName = "memberCount")]
        public string MemberCount { get; set; }
        [XmlElement(ElementName = "membersInChat")]
        public string MembersInChat { get; set; }
        [XmlElement(ElementName = "membersInGame")]
        public string MembersInGame { get; set; }
        [XmlElement(ElementName = "membersOnline")]
        public string MembersOnline { get; set; }
    }

    [XmlRoot(ElementName = "members")]
    public class Members
    {
        [XmlElement(ElementName = "steamID64")]
        public List<string> SteamID64 { get; set; }
    }

    [XmlRoot(ElementName = "memberList")]
    public class MemberList
    {
        [XmlElement(ElementName = "groupID64")]
        public string GroupID64 { get; set; }
        [XmlElement(ElementName = "groupDetails")]
        public GroupDetails GroupDetails { get; set; }
        [XmlElement(ElementName = "memberCount")]
        public string MemberCount { get; set; }
        [XmlElement(ElementName = "totalPages")]
        public string TotalPages { get; set; }
        [XmlElement(ElementName = "currentPage")]
        public string CurrentPage { get; set; }
        [XmlElement(ElementName = "startingMember")]
        public string StartingMember { get; set; }
        [XmlElement(ElementName = "members")]
        public Members Members { get; set; }
    }

}
