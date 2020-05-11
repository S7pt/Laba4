using System;
using System.Collections;
using System.Collections.Generic;
using Laba4Task3.models;
using Microsoft.VisualBasic.CompilerServices;

namespace Laba4Task3.manager
{
    public class PerformanceManagerUtils
    {
        class Dota: IComparer <Performance>
        {
            public int Compare(Performance performance1, Performance performance2)
            {
                return String.Compare(performance1.GetSurname(), performance2.GetSurname());
            }
        }
        

        public static void SortByName(List<Performance> performanceList,SortType sortType)
        {
            Dota dotaComparer=new Dota();
            if (sortType == SortType.ASCENDING)
            {
               performanceList.Sort(dotaComparer);
            }
        }
    }
}