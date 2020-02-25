using System.Collections.Generic;
using Documo.Strategies;
using Documo.Strategies.HtmlProcessing;

namespace Documo.Services
{
    public static class PlaceholderStrategies
    {
        public static IEnumerable<IProcessPlaceholder> Get()
        {
            return new List<IProcessPlaceholder>
            {
                new ProcessObjectPlaceholder(), 
                new ProcessRepeatingSectionPlaceholders(),
                new ImagePlaceholderProcessor(),
                new ConditionalSectionProcessor()
            };
        }
    }
}