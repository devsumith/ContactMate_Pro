using ContactMate_Pro.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                //string pattern = @"^(https?://)?(www\.)?facebook\.com/[\w.-]+/?$";

                // Validation for Facebook link.
                Validate("facebook", ref _facebookLink, value, "Facebook Link");
            }
        }

        private string _instagramLink;
        public string InstagramLink
        {
            get { return _instagramLink; }
            set
            {
                // Regular expression pattern for a valid Instagram profile link.
                //string pattern = @"^(https?://)?(www\.)?instagram\.com/[\w.-]+/?$";

                // Validation for Instagram link.
                Validate("instagram", ref _instagramLink, value, "Instagram Link");
            }
        }

        private string _linkedInLink;
        public string LinkedInLink
        {
            get { return _linkedInLink; }
            set
            {
                // Regular expression pattern for a valid LinkedIn profile link.
                //string pattern = @"^(https?://)?(www\.)?linkedin\.com/in/[\w-]+/?$";

                // Validation for LinkedIn link.
                Validate("linkedin", ref _linkedInLink, value, "LinkedIn Link");
            }
        }

        private string _twitterLink;
        public string TwitterLink
        {
            get { return _twitterLink; }
            set
            {
                // Regular expression pattern for a valid Twitter profile link.
                //string pattern = @"^(https?://)?(www\.)?twitter\.com/[\w.]+/?$";

                // Validation for Twitter link.
                Validate("twitter", ref _twitterLink, value, "Twitter Link");
            }
        }

        private string _gitHubLink;
        public string GitHubLink
        {
            get { return _gitHubLink; }
            set
            {
                // Regular expression pattern for a valid GitHub profile link.
                //string pattern = @"^(https?://)?(www\.)?github\.com/[\w-]+/?$";

                // Validation for GitHub link.
                Validate("github", ref _gitHubLink, value, "GitHub Link");
            }
        }

        private string _threadsLink;
        public string ThreadsLink
        {
            get { return _threadsLink; }
            set
            {
                // Regular expression pattern for a valid Threads profile link.
                //string pattern = @"^(https?://)?(www\.)?github\.com/[\w-]+/?$";

                // Validation for GitHub link.
                Validate("threads", ref _threadsLink, value, "Threads Link");
            }
        }

        // This method is defined to validate a given value against a regular expression pattern.
        // If the value matches the pattern, it's assigned to the specified privateHolder variable.
        // If the value doesn't match, an error message is displayed and the privateHolder variable is set to null.
        public void Validate(string pattern, ref string privateHolder, string value, string name)
        {
            Functionality functions = new Functionality();
            pattern = $"^(https?://)?(www\\.)?{pattern}\\.com/[\\w-]+/?$";

            // Check if the provided value matches the specified regular expression pattern.
            if (Regex.IsMatch(value, pattern))
                privateHolder = value; // Assign the value to the privateHolder if it's valid.
            else
            {
                // Display an error message using string interpolation to include the invalid value and the expected type.
                functions.Alert($"Invalid {name}", AlertForm.Type.Error);
                privateHolder = null; // Set the privateHolder to null since the value is invalid.
            }
        }

        // PROPERTIES FOR EMPLOYMENT INFORMATION
        public string CompanyName { get; set; }
        public string JobTitle { get; set; }
        public string WorkContactNumber { get; set; } 
        public string WorkAddress {  get; set; }    
        public string WorkEmailAddress { get; set; }
    }
}
