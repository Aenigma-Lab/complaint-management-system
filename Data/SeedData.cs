using ComplaintMngSys.Helpers;
using ComplaintMngSys.Models;
using ComplaintMngSys.Models.UserAccountViewModel;

namespace ComplaintMngSys.Data
{
    public class SeedData
    {
        public IEnumerable<ComplaintCategory> GetComplaintCategoryList()
        {
            return new List<ComplaintCategory>
            {
                new ComplaintCategory { Name = "Software", Description = "Software"},
                new ComplaintCategory { Name = "Hardware", Description = "Hardware"},
                new ComplaintCategory { Name = "Network", Description = "Network"},
                new ComplaintCategory { Name = "Finance", Description = "Finance"},
                new ComplaintCategory { Name = "Commercial", Description = "Commercial"},
                new ComplaintCategory { Name = "Marketing", Description = "Marketing"},
                new ComplaintCategory { Name = "HR", Description = "HR"},
                new ComplaintCategory { Name = "Default", Description = "Default"},
                new ComplaintCategory { Name = "Representing the customer problem", Description = "Representing the customer problem"},
                new ComplaintCategory { Name = "Unavailable or out of stock product", Description = "Unavailable or out of stock product"},
            };
        }

        public IEnumerable<ComplaintStatus> GetComplaintStatusList()
        {
            return new List<ComplaintStatus>
            {
                new ComplaintStatus { Name = "New", Description = "New Status"},
                new ComplaintStatus { Name = "Submited", Description = "Submited Status"},
                new ComplaintStatus { Name = "In Progress", Description = "In Progress Status"},

                new ComplaintStatus { Name = "Pending", Description = "Pending Status"},
                new ComplaintStatus { Name = "Resolved", Description = "Resolved Status"},
                new ComplaintStatus { Name = "Rejected", Description = "Rejected Status"},
                new ComplaintStatus { Name = "Blocker", Description = "Blocker Status"},
                new ComplaintStatus { Name = "Closed", Description = "Closed Status"},
                new ComplaintStatus { Name = "ToDo", Description = "ToDo Status"}
            };
        }

        public IEnumerable<Priority> GetPriorityList()
        {
            return new List<Priority>
            {
                new Priority { Name = "High", Description = "High Priority"},
                new Priority { Name = "Low", Description = "Priority Priority"},
                new Priority { Name = "Medium", Description = "Medium Priority"},

                new Priority { Name = "Critical", Description = "Critical Priority"},
                new Priority { Name = "Moderate", Description = "Moderate Priority"},
                new Priority { Name = "Major", Description = "Major Priority"},
                new Priority { Name = "Others", Description = "Major Others"},
            };
        }
        public IEnumerable<Complaint> GetComplaintList()
        {
            return new List<Complaint>
            {
                new Complaint { Name = "Test Complaint 01", Description = "TBD", Category = 1, Status = 1, Priority = 1 },
                new Complaint { Name = "Test Complaint 01", Description = "TBD", Category = 1, Status = 1, Priority = 1 },
                new Complaint { Name = "Test Complaint 01", Description = "TBD", Category = 1, Status = 1, Priority = 1 },
                new Complaint { Name = "Test Complaint 01", Description = "TBD", Category = 2, Status = 1, Priority = 1 },
                new Complaint { Name = "Test Complaint 01", Description = "TBD", Category = 2, Status = 1, Priority = 1 },

                new Complaint { Name = "Test Complaint 01", Description = "TBD", Category = 3, Status = 3, Priority = 2 },
                new Complaint { Name = "Test Complaint 01", Description = "TBD", Category = 3, Status = 3, Priority = 2 },

                new Complaint { Name = "Test Complaint XYZ_1", Description = "TBD", Category = 4, Status = 4, Priority = 2 },
                new Complaint { Name = "Test Complaint XYZ_2", Description = "TBD", Category = 5, Status = 5, Priority = 2 },
            };
        }
        public IEnumerable<UserProfileCRUDViewModel> GetUserProfileList()
        {
            return new List<UserProfileCRUDViewModel>
            {
                new UserProfileCRUDViewModel { FirstName = "Shop5", LastName = "User", Email = "Shop5@gmail.com", PasswordHash = "123", ConfirmPassword = "123", PhoneNumber= StaticData.RandomDigits(11), ProfilePicturePath = "/images/DefaultUser/U1.png", Address = "California", Country = "USA" },
                new UserProfileCRUDViewModel { FirstName = "Shop4", LastName = "User", Email = "Shop4@gmail.com", PasswordHash = "123", ConfirmPassword = "123", PhoneNumber= StaticData.RandomDigits(11), ProfilePicturePath = "/images/DefaultUser/U2.png", Address = "California", Country = "USA"  },
                new UserProfileCRUDViewModel { FirstName = "Shop3", LastName = "User", Email = "Shop3@gmail.com", PasswordHash = "123", ConfirmPassword = "123", PhoneNumber= StaticData.RandomDigits(11), ProfilePicturePath = "/images/DefaultUser/U3.png", Address = "California", Country = "USA"  },
                new UserProfileCRUDViewModel { FirstName = "Shop2", LastName = "User", Email = "Shop2@gmail.com", PasswordHash = "123", ConfirmPassword = "123", PhoneNumber= StaticData.RandomDigits(11), ProfilePicturePath = "/images/DefaultUser/U4.png", Address = "California", Country = "USA"  },
                new UserProfileCRUDViewModel { FirstName = "Shop1", LastName = "User", Email = "Shop1@gmail.com", PasswordHash = "123", ConfirmPassword = "123", PhoneNumber= StaticData.RandomDigits(11), ProfilePicturePath = "/images/DefaultUser/U5.png", Address = "California", Country = "USA"  },

                new UserProfileCRUDViewModel { FirstName = "Accountants1", LastName = "User", Email = "accountants1@gmail.com", PasswordHash = "123", ConfirmPassword = "123", PhoneNumber= StaticData.RandomDigits(11), ProfilePicturePath = "/images/DefaultUser/U6.png", Address = "California", Country = "USA" },
                new UserProfileCRUDViewModel { FirstName = "Accountants2", LastName = "User", Email = "accountants2@gmail.com", PasswordHash = "123", ConfirmPassword = "123", PhoneNumber= StaticData.RandomDigits(11), ProfilePicturePath = "/images/DefaultUser/U7.png", Address = "California", Country = "USA" },
                new UserProfileCRUDViewModel { FirstName = "Accountants3", LastName = "User", Email = "accountants3@gmail.com", PasswordHash = "123", ConfirmPassword = "123", PhoneNumber= StaticData.RandomDigits(11), ProfilePicturePath = "/images/DefaultUser/U8.png", Address = "California", Country = "USA" },
                new UserProfileCRUDViewModel { FirstName = "Accountants4", LastName = "User", Email = "accountants4@gmail.com", PasswordHash = "123", ConfirmPassword = "123", PhoneNumber= StaticData.RandomDigits(11), ProfilePicturePath = "/images/DefaultUser/U9.png", Address = "California", Country = "USA" },
                new UserProfileCRUDViewModel { FirstName = "Accountants5", LastName = "User", Email = "accountants5@gmail.com", PasswordHash = "123", ConfirmPassword = "123", PhoneNumber= StaticData.RandomDigits(11), ProfilePicturePath = "/images/DefaultUser/U10.png", Address = "California", Country = "USA" },
            };
        }
        public CompanyInfo GetCompanyInfo()
        {
            return new CompanyInfo
            {
                Name = "XYZ Company Limited",
                ApplicationTitle = "Complaint Mng Sys",
                CompanyLogoImagePath = "/upload/blank_logo.png",
                Currency = "৳",
                Address = "Dhaka, Bangladesh",
                City = "Dhaka",
                Country = "Bangladesh",
                Phone = "132546789",
                Fax = "9999",
                Email = "XYZ@GMAIL.COM",
                Website = "www.wyx.com",
            };
        }
    }
}
