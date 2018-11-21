using System;

namespace StarCorp.Project.Application
{
    public class StarCorpProjectApplication : IStarCorpProjectApplication
    {
        string IStarCorpProjectApplication.Calculate(int Number)
        {
            int mod3 = Number % 3;
            int mod5 = Number % 5;

            if (mod3 == 0 & mod5 == 0)
            {
                return "StarCorpianos";
            }
            else if (mod3 == 0)
            {
                return  "StarCorp";
            }
            else if (mod5 == 0)
            {
                return "IT";
            }
            else
            {
                return "Type Indefined";
            }
        }
    }
}
