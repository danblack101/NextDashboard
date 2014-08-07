﻿using System.Collections.Generic;
using NextDashboard.Application.DomainObjects;

namespace NextDashboard.Application
{
    public class JobRepository : IJobRepository
    {
        public List<Job> SelectAll()
        {
            return new List<Job>
            {
                new JenkinsJob("Test Job 1", "Passing"),
                new JenkinsJob("Code Reviews", "25 Completed this week, 9 Pending")
            };
        }
    }
}