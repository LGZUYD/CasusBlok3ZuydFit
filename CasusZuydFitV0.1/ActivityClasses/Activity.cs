﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasusZuydFitV0._1.RemainingClasses;
using CasusZuydFitV0._1.UserClasses;
using static CasusZuydFitV0._1.DAL.DAL;

namespace CasusZuydFitV0._1.ActivityClasses
{
    public abstract class Activity
    {
        public int ActivityId { get; set; }
        public string ActivityName { get; set; }
        public int ActivityDurationMinutes { get; set; }
        public string ActivityStartingTime { get; set; }
        public Trainer Trainer { get; set; }
        public string ActivityDescription { get; set; }
        public List<Equipment> Equipments { get; set; } = new List<Equipment>();

        public Activity()
        {

        }

        public Activity(int activityId, string activityName, int activityDurationMinutes, string activityStartingTime, Trainer trainer, string activityDescription)
        {
            ActivityId = activityId;
            ActivityName = activityName;
            ActivityDurationMinutes = activityDurationMinutes;
            ActivityStartingTime = activityStartingTime;
            Trainer = trainer;
            ActivityDescription = activityDescription;
        }

        public Activity(string activityName, int activityDurationMinutes, string activityStartingTime, Trainer trainer, string activityDescription)
        {
            ActivityName = activityName;
            ActivityDurationMinutes = activityDurationMinutes;
            ActivityStartingTime = activityStartingTime;
            Trainer = trainer;
            ActivityDescription = activityDescription;

        }

    }
}
