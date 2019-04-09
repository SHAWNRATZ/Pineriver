using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PineriverASPNETPage.Models;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using static PineriverASPNETPage.Models.MemberJson;

namespace PineriverASPNETPage.Pages
{
    public class MembersModel : PageModel
    {
        [BindProperty]
        public MemberList Members { get; set; }

        [BindProperty]
        public SteamUserJson SUJ { get; set; }

        public void OnGet()
        {

            string url = "https://steamcommunity.com/groups/PineRiverdk/memberslistxml/&xml=1";
            XmlSerializer ser = new XmlSerializer(typeof(MemberList));
            WebClient client = new WebClient();
            string data = Encoding.Default.GetString(client.DownloadData(url));
            Stream stream = new MemoryStream(Encoding.UTF8.GetBytes(data));
            Members = (MemberList)ser.Deserialize(stream);

            string baseUrl = "https://api.steampowered.com/ISteamUser/GetPlayerSummaries/v2/?key=B1A6C42979B2D9635D54FA3D96C2CACE&format=json&steamids=";

            for (int i = 0; i < Members.Members.SteamID64.Count; i++)
            {
                if (i < Members.Members.SteamID64.Count)
                {
                    baseUrl += Members.Members.SteamID64[i] + ", ";
                }

                else
                {
                    baseUrl += Members.Members.SteamID64[i];
                }
            }

            using (WebClient httpClient = new WebClient())
            {
                var jsonData = httpClient.DownloadString(baseUrl);
                SUJ = JsonConvert.DeserializeObject<SteamUserJson>(jsonData);
                SUJ.response.players = SUJ.response.players.OrderBy(o => o.personaname).ToList();
            }
        }
    }
}