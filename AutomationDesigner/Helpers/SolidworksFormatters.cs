using System.Linq;

namespace AutomationDesigner.Helpers
{
    public class SolidworksFormatters
    {
        public static string RemoveDocumentNameFromDimension(string dimension)
        {
            if (dimension.Count(x => x == '@') == 2)
            {
                var dimArray = dimension.Split('@');

                var newDim = $"{dimArray[0]}@{dimArray[1]}";

                return newDim;
            }

            return dimension;
        }
    }
}
