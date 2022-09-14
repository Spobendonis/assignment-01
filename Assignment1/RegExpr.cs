namespace Assignment1;

using System.Text.RegularExpressions;
public static class RegExpr
{
    public static IEnumerable<string> SplitLine(IEnumerable<string> lines) {
        var pattern = @"[a-zA-Z0-9]+";
        Regex rg = new Regex(pattern);
        foreach (var line in lines) {
            foreach(var item in rg.Matches(line)) {
                yield return item.ToString();
            }
        }
    }

    public static IEnumerable<(int width, int height)> Resolution(IEnumerable<string> resolutions) {
        var pattern = @"(?<width>[0-9]+)x(?<height>[0-9]+)";
        Regex rg = new Regex(pattern);
        foreach (var r in SplitLine(resolutions)) {
            Match match = rg.Match(r);
            if (match.Success) {
                yield return (int.Parse(match.Groups["width"].Value), int.Parse(match.Groups["height"].Value));
            }
        }
    }

    public static IEnumerable<string> InnerText(string html, string tag) {
        var pattern = $@"<({tag})[^>]+>(?<inner>[ a-zA-Z0-9]+)</\1>";
        foreach (Match match in Regex.Matches(html, pattern)) {
            yield return match.Groups["inner"].Value;
        }
    }

    public static IEnumerable<(Uri url, string title)> Urls(string html) {
        var pattern = @"href=""(?<link>.+?)"".*?(title=""(?<title>.+?)"")*?>(?<inner>.*?)<";
        foreach (Match match in Regex.Matches(html, pattern)) {
            yield return (new Uri(match.Groups["link"].Value), (match.Groups["title"].Success ? match.Groups["title"].Value : match.Groups["inner"].Value));
        }
    }
}