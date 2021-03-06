﻿using System.Collections.Generic;
using NextDashboard.Application.DomainObjects;
using NextDashboard.Application.Jobs.Jenkins;

namespace NextDashboard.Application.Repository
{
    public class FakeJobRepository : IJobRepository
    {
        private const string JenkinsBaseUrl = "http://jenkins.msohosting.local:8080";

        public List<Job> SelectAll()
        {
            return new List<Job>
            {
                new JenkinsJob("1", "Jenkins Auditing CI", "Passing", JenkinsBaseUrl, "BB - CI/job/Auditing CI","dblack", "5dd12d253bb6ff1376f3b5a5a9333712"),
                new JenkinsJob("2", "Jenkins Integration Tests", "Passing", JenkinsBaseUrl,"Tests/job/Kanga/job/Kanga - Integration Tests", "dblack", "5dd12d253bb6ff1376f3b5a5a9333712"),
                new SampleJob("3", "Code Reviews", "25 Completed this week, 9 Pending"),
                new SampleJob("4", "TP Sprint 3", "3 of 7 Stories Completed"),
                new SampleJob("5", "Test Job 4", "Passing")
            };
        }

        public Job Select(int jobId)
        {
            return new JenkinsJob("1", "Test Job 1", "Passing", JenkinsBaseUrl, "BB - CI/job/Auditing CI", "dblack","5dd12d253bb6ff1376f3b5a5a9333712");
        }
    }
}