namespace SpaAndBeautyWebsite.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Email { get; set; } = "";
        public string Username { get; set; } = "";
        public string Phone { get; set; } = "";

        // Employee specific fields (will be empty for Customers)
        public string JobTitle { get; set; } = "";
        public string Location { get; set; } = "";

        // Helper to know which table to save back to
        public string UserType { get; set; } = ""; // "Customer" or "Employee"
    }
}