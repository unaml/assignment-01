namespace Assignment1;
using System.Text.RegularExpressions;



public static class RegExpr
{
    public static IEnumerable<string> SplitLine(IEnumerable<string> lines)
    {
        string pattern = @"(?=[A-Za-z0-9])([A-Za-z0-9]*)(?<=[A-Za-z0-9])";

        foreach (string line in lines)
        {
            foreach (Match m in Regex.Matches(line, pattern))
            {
                yield return m.Value;
            }
        }
    }

    public static IEnumerable<(int width, int height)> Resolution(string resolutions)
    {   
        string pattern = @"(?<width>[0-9]+)x(?<height>[0-9]+)";

        foreach (Match m in Regex.Matches(resolutions, pattern))
        {
            var height = Int32.Parse(m.Groups["width"].Value);
            var width = Int32.Parse(m.Groups["height"].Value);
            yield return (height, width);
        }
    }
    public static IEnumerable<string> InnerText(string html, string tag)
    {
        string pattern = $@"<({tag}).*?>(?'content'.*?)<\/\1>*";

        foreach (Match m in Regex.Matches(html, pattern))
        {
            yield return Regex.Replace(m.Groups["content"].Value, @"<.*?>", "");
        }
    }
}