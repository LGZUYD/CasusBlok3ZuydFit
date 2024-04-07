﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CasusZuydFitV0._1.DAL;

namespace CasusZuydFitV0._1
{
    public class Feedback
    {
        public int FeedbackId { get; set; }
        public Trainer Trainer { get; set; }
        public Athlete Athlete { get; set; }
        public Activity Activity { get; set; }
        public string FeedbackInfo { get; set; }

        public Feedback(int feedbackId, Trainer trainer, Athlete athlete, Activity activity, string feedbackInfo)
        {
            FeedbackId = feedbackId;
            Trainer = trainer;
            Athlete = athlete;
            Activity = activity;
            FeedbackInfo = feedbackInfo;
        }
        
        public void AddTrainer(Trainer trainer)
        {
            Trainer = trainer;
        }

        public void AddRecipient(Athlete user) // dit klopt niet in class diagram
        {
            Athlete = user;
        }

        public void AddActivity(Activity activity)
        {
            Activity = activity;

        }

        public void ShowFeedback()
        {

        }

        public void CreateFeedback() 
        {
            FeedbackDAL Dal = new FeedbackDAL();
            Dal.CreateFeedback(this);
        }
    }
}
