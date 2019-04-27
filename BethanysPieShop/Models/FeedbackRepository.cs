using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class FeedbackRepository : IFeedbackRepository
    {
        private readonly AppDBContext appDBContext;

        public FeedbackRepository(AppDBContext appDBContext)
        {
            this.appDBContext = appDBContext;
        }

        public void AddFeedback(Feedback feedback)
        {
            appDBContext.Feedbacks.Add(feedback);
            appDBContext.SaveChanges();
        }
    }
}
