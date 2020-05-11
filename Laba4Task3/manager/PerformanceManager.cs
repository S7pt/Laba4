using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Laba4Task3.menu;
using Laba4Task3.models;

namespace Laba4Task3.manager
{
    public class PerformanceManager
    {
        public List<Performance> SearchByGroup(List<Performance> performanceList, string group)
        {
            List<Performance> filteredList=new List<Performance>();
            foreach (Performance performanceUnit in performanceList)
            {
                if (performanceUnit.GetGroup() == group)
                {
                    filteredList.Add(performanceUnit);
                }  
            }

            return filteredList;
        }
        
    }
}