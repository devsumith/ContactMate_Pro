﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactMate_Pro
{
    public class ContactDetails
    {
        // PROPERTIES FOR OVERVIEW INFORMATION : ESSENTIAL TO BE FILLED
        public string Nickname { get; set; }
        public string Relationship { get; set; }
        public string ContactNumbers { get; set; }
        public string GmailAddresses {  get; set; }

        // PROPERTIES FOR PERSONAL INFORMATION
        public string LastName { get; set; } 
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string ExtensionName { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }
        public string Birthday { get; set; }
        public string StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string Barangay { get; set; }
        public string City { get; set; }
        public string Province { get; set; }

        // PROPERTIES FOR SOCIAL MEDIA INFORMATION
        private string _facebookLink;
        public string FacebookLink
        {
            get { return _facebookLink; }
            set
            {
                // Regular expression pattern for a valid Facebook profile link.
                string pattern = @"^(https?://)?(www\.)?facebook\.com/[\w.-]+/?$";


            }
        }

        private string _instagramLink;
        public string InstagramLink
        {
            get { return _instagramLink; }
            set
            {
                // Regular expression pattern for a valid Instagram profile link.
                string pattern = @"^(https?://)?(www\.)?instagram\.com/[\w.-]+/?$";
            }
        }

        private string _twitterLink;
        public string TwitterLink
        {
            get { return _twitterLink; }
            set
            {
                // Regular expression pattern for a valid Twitter profile link.
                string pattern = @"^(https?://)?(www\.)?twitter\.com/[\w.]+/?$";
            }
        }

        private string _linkedInLink;
        public string LinkedInLink
        {
            get { return _linkedInLink; }
            set
            {
                // Regular expression pattern for a valid LinkedIn profile link.
                string pattern = @"^(https?://)?(www\.)?linkedin\.com/in/[\w-]+/?$";
            }
        }

        private string _gitHubLink;
        public string GitHubLink
        {
            get { return _gitHubLink; }
            set
            {
                // Regular expression pattern for a valid GitHub profile link.
                string pattern = @"^(https?://)?(www\.)?github\.com/[\w-]+/?$";
            }
        }
    }
}