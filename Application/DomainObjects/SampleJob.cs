﻿namespace NextDashboard.Application.DomainObjects
{
    public class SampleJob : Job
    {
        public SampleJob(string name, string status) : base(name, status)
        {
        }


        public override Job Refresh()
        {
            throw new System.NotImplementedException();
        }
    }
}