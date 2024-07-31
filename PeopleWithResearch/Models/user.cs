using Microsoft.Datasync.Client;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PeopleWithResearch
{
    /// <summary>
    /// User Object
    /// </summary>
    public class user : DatasyncClientData
    {
        string? id;
        string? title;
        //Byte[]? version;
        string? firstName;
        string? surname;
        string? gender;
        string? age;
        string? ethnicity;
        string? email;
        string? password;
        string? addressLineOne;
        string? addressLineTwo;
        string? postcode;
        string? town;
        string? city;
        string? phoneNumber;
        string? regStatus;
        int loweragebracket;
        int upperagebracket;
        string? signupid;
        string? height;
        string? weight;
        DateTimeOffset createdAt;
        string? make;
        string? model;
        string? referral;
        string? advertID;
        string? role;
        string? dashboard;
        bool imagevisible;
        bool clinicaltrails;
        string? EPID;
        string? GPID;
        string? PWID;
        bool clinicalinfo;
        string? activationDT;
        string? changesignupid;
        bool emailNotifications;
        string dob;
        string audio;
        string video;
        string written;
        string podcasts;
        string articles;
        string images;
        string presentations;
        string emails;
        string digitalmeetings;
        string userprefs;


        /// <summary>
        /// ID getter/setter
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id
        {
            get { return id; }
            set { id = value; }
        }


        [JsonProperty(PropertyName = "Title")]
        public string? Title
        {
            get { return title; }
            set { title = value; }
        }


        /// <summary>
        /// First Name getter/setter
        /// </summary>
        [JsonProperty(PropertyName = "Firstname")]
        public string? FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }


        /// <summary>
        /// Surname getter/setter
        /// </summary>
        [JsonProperty(PropertyName = "Surname")]
        public string? Surname
        {
            get { return surname; }
            set { surname = value; }
        }


        /// <summary>
        /// Gender getter/setter
        /// </summary>
        [JsonProperty(PropertyName = "Gender")]
        public string? Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        /// <summary>
        /// Age getter/setter
        /// </summary>
        [JsonProperty(PropertyName = "age")]
        public string Age
        {
            get { return age; }
            set { age = value; }
        }

        /// <summary>
        /// Ethnicity getter/setter
        /// </summary>
        [JsonProperty(PropertyName = "ethnicity")]
        public string Ethnicity
        {
            get { return ethnicity; }
            set { ethnicity = value; }
        }

        /// <summary>
        /// Email getter/setter
        /// </summary>
        [JsonProperty(PropertyName = "Email")]
        public string? Email
        {
            get { return email; }
            set { email = value; }
        }

        /// <summary>
        /// Password getter/setter
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        /// <summary>
        /// Address Line One getter/setter
        /// </summary>
        [JsonProperty(PropertyName = "addresslineone")]
        public string? AddressLineOne
        {
            get { return addressLineOne; }
            set { addressLineOne = value; }
        }

        /// <summary>
        /// Address Line Two getter/setter
        /// </summary>
        [JsonProperty(PropertyName = "addresslinetwo")]
        public string? AddressLineTwo
        {
            get { return addressLineTwo; }
            set { addressLineTwo = value; }
        }


        /// <summary>
        /// Postcode getter/setter
        /// </summary>
        [JsonProperty(PropertyName = "postcode")]
        public string? Postcode
        {
            get { return postcode; }
            set { postcode = value; }
        }


        /// <summary>
        /// Town getter/setter
        /// </summary>
        [JsonProperty(PropertyName = "town")]
        public string? Town
        {
            get { return town; }
            set { town = value; }
        }

        /// <summary>
        /// City getter/setter
        /// </summary>
        [JsonProperty(PropertyName = "city")]
        public string? City
        {
            get { return city; }
            set { city = value; }
        }

        /// <summary>
        /// Phone Number getter/setter
        /// </summary>
        [JsonProperty(PropertyName = "phonenumber")]
        public string? PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        /// <summary>
        /// Registration Status getter/setter
        /// </summary>
        [JsonProperty(PropertyName = "regstatus")]
        public string? RegStatus
        {
            get { return regStatus; }
            set { regStatus = value; }
        }

        /// <summary>
        /// Registration Status getter/setter
        /// </summary>
        [JsonProperty(PropertyName = "loweragebracket")]
        public int Loweragebracket
        {
            get { return loweragebracket; }
            set { loweragebracket = value; }
        }

        /// <summary>
        /// Registration Status getter/setter
        /// </summary>
        [JsonProperty(PropertyName = "upperagebracket")]
        public int Upperagebracket
        {
            get { return upperagebracket; }
            set { upperagebracket = value; }
        }


        /// <summary>
        /// ID getter/setter
        /// </summary>
        [JsonProperty(PropertyName = "signupid")]
        public string? Signupid
        {
            get { return signupid; }
            set { signupid = value; }
        }

        [JsonProperty(PropertyName = "height")]
        public string? Height
        {
            get { return height; }
            set { height = value; }
        }

        [JsonProperty(PropertyName = "weight")]
        public string? Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        [JsonProperty(PropertyName = "createdAt")]
        public DateTimeOffset Createdat
        {
            get { return createdAt; }
            set { createdAt = value; }
        }

        //	[JsonIgnore]
        //public string DOB
        //{
        //get { return dob; }
        //set { dob = value; }
        //	}

        [JsonProperty(PropertyName = "make")]
        public string? Make
        {
            get { return make; }
            set { make = value; }
        }

        [JsonProperty(PropertyName = "model")]
        public string? Model
        {
            get { return model; }
            set { model = value; }
        }

        [JsonProperty(PropertyName = "referral")]
        public string? Referral
        {
            get { return referral; }
            set { referral = value; }
        }

        [JsonProperty(PropertyName = "advertID")]
        public string? AdvertID
        {
            get { return advertID; }
            set { advertID = value; }
        }

        [JsonProperty(PropertyName = "role")]
        public string? Role
        {
            get { return role; }
            set { role = value; }
        }

        [JsonProperty(PropertyName = "dashboard")]
        public string? Dashboard
        {
            get { return dashboard; }
            set { dashboard = value; }
        }

        [Newtonsoft.Json.JsonIgnore]
        public bool Imagevisible
        {
            get { return imagevisible; }
            set { imagevisible = value; }
        }

        [JsonProperty(PropertyName = "clinicaltrails")]
        public bool Clinicaltrails
        {
            get { return clinicaltrails; }
            set { clinicaltrails = value; }
        }

        [JsonProperty(PropertyName = "EPID")]
        public string? Epid
        {
            get { return EPID; }
            set { EPID = value; }
        }

        [JsonProperty(PropertyName = "GPID")]
        public string? Gpid
        {
            get { return GPID; }
            set { GPID = value; }
        }

        [JsonProperty(PropertyName = "PWID")]
        public string? Pwid
        {
            get { return PWID; }
            set { PWID = value; }
        }

        [JsonProperty(PropertyName = "clinicalinfo")]
        public bool Clinicalinfo
        {
            get { return clinicalinfo; }
            set { clinicalinfo = value; }
        }

        [JsonProperty(PropertyName = "activationDT")]
        public string? ActivationDT
        {
            get { return activationDT; }
            set { activationDT = value; }
        }

        [Newtonsoft.Json.JsonIgnore]
        public string? Changesignupid
        {
            get { return changesignupid; }
            set { changesignupid = value; }
        }


        [JsonProperty(PropertyName = "emailNotifications")]
        public bool EmailNotifications
        {
            get { return emailNotifications; }
            set { emailNotifications = value; }
        }

        //[JsonProperty(PropertyName = "audio")]
        //public string Audio
        //{
        //	get { return audio; }
        //	set { audio = value; }
        //}

        //[JsonProperty(PropertyName = "video")]
        //public string Video
        //{
        //	get { return video; }
        //	set { video = value; }
        //}

        //[JsonProperty(PropertyName = "written")]
        //public string WrittenBlogsNews
        //{
        //	get { return written; }
        //	set { written = value; }
        //}

        //[JsonProperty(PropertyName = "podcasts")]
        //public string Podcasts
        //{
        //	get { return podcasts; }
        //	set { podcasts = value; }
        //}

        //[JsonProperty(PropertyName = "articles")]
        //public string HealthArticles
        //{
        //	get { return articles; }
        //	set { articles = value; }
        //}

        //[JsonProperty(PropertyName = "images")]
        //public string Images
        //{
        //	get { return images; }
        //	set { images = value; }
        //}

        //[JsonProperty(PropertyName = "presentations")]
        //public string Presentations
        //{
        //	get { return presentations; }
        //	set { presentations = value; }
        //}

        //[JsonProperty(PropertyName = "emails")]
        //public string EmailComms
        //{
        //	get { return emails; }
        //	set { emails = value; }
        //}

        //[JsonProperty(PropertyName = "virtualmeet")]
        //public string VirtualMeet
        //{
        //	get { return digitalmeetings; }
        //	set { digitalmeetings = value; }
        //}

        //[JsonProperty(PropertyName = "userprefs")]
        //public string UserPrefernces
        //{
        //    get { return userprefs; }
        //    set { userprefs = value; }
        //}
    }


}
