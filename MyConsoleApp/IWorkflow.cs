using System.Collections.Generic;

namespace MyConsoleApp
{
    public interface IWorkflow
    {
        IEnumerable<IActivity> GetActivities();
    }
}