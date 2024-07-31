using System;
using Microsoft.Datasync.Client;
using Newtonsoft.Json;
namespace PeopleWithResearch
{
    public class userconsent : DatasyncClientData
    {

        string id;
        bool deleted;
        string advertid;
        string userid;
        string consentid;
        bool consented;
        string area;
        string notes;
        DateTime createdAt;
        string updatedAt;
        string version;
        string timestring;
        string consentSelections;

        /// <summary>
        /// ID getter/setter
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        [JsonProperty(PropertyName = "deleted")]
        public bool Deleted
        {
            get { return deleted; }
            set { deleted = value; }
        }

        [JsonProperty(PropertyName = "advertid")]
        public string Advertid
        {
            get { return advertid; }
            set { advertid = value; }
        }

        [JsonProperty(PropertyName = "userid")]
        public string Userid
        {
            get { return userid; }
            set { userid = value; }
        }

        [JsonProperty(PropertyName = "consentid")]
        public string Consentid
        {
            get { return consentid; }
            set { consentid = value; }
        }

        [JsonProperty(PropertyName = "consented")]
        public bool Consented
        {
            get { return consented; }
            set { consented = value; }
        }

        [JsonProperty(PropertyName = "area")]
        public string Area
        {
            get { return area; }
            set { area = value; }
        }

        [JsonProperty(PropertyName = "notes")]
        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }

        [JsonIgnore]
        public string Timestring
        {
            get { return timestring; }
            set { timestring = value; }
        }

        //[JsonProperty(PropertyName = "notes")]
        //public string Notes
        //{
        //    get { return notes; }
        //    set { notes = value; }
        //}





        //db
        [JsonProperty(PropertyName = "createdAt")]
        public DateTime CreatedAt
        {
            get { return createdAt; }
            set { createdAt = value; }
        }

        [JsonProperty(PropertyName = "updatedAt")]
        public string UpdatedeAt
        {
            get { return updatedAt; }
            set { updatedAt = value; }
        }

        //[JsonProperty(PropertyName = "version")]
        //public string Version
        //{
        //    get { return version; }
        //    set { version = value; }
        //}

        [JsonProperty(PropertyName = "consentSelections")]
        public string ConsentSelections
        {
            get { return consentSelections; }
            set { consentSelections = value; }
        }
    }
}
