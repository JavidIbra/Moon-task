using CoreTask2_Moon.Models.Entity;
using System.Collections.Generic;

namespace CoreTask2_Moon.ViewModel
{
    public class HomeViewModel
    {
        public Banner banner { get; set; }
        public List<AppDetail> appDetails { get; set; }
        public List<Category> categories { get; set; }
        public List<Project> projects { get; set; }
        public List<News> news { get; set; }
        public List<Service> services { get; set; }    
        public List<Audience> audiences { get; set; }    
        public List<SocialMedia> socialMedias { get; set; }    
        public List<Pricing> pricings { get; set; }    
        public List<Client> clients { get; set; }    

    }
}
