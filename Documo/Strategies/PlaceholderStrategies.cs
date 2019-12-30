using System.Collections.Generic;
using Documo.Strategies;

namespace Documo.Services
{
    public static class PlaceholderStrategies
    {
        public static IEnumerable<IProcessPlaceholder> Get()
        {
            return new List<IProcessPlaceholder>
            {
                new ProcessObjectPlaceholder(), 
                new ProcessRepeatingSectionPlaceholders()
            };
        }
    }
}