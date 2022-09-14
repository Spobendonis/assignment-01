namespace Assignment1.Tests;

public class RegExprTests
{
    [Fact]
    public void SplitLine_on_Hello_World_Cupcake_and___and_Handshake___25_Pizza_gives_Hello_World_Cupcake_Handshake_25_Pizza() {
        //Arrange
        var list = new List<string> {"Hello World Cupcake", " ", "Handshake   25 Pizza"};
        var answer = new List<string> {"Hello", "World", "Cupcake", "Handshake", "25", "Pizza"};

        //Act
        var output = RegExpr.SplitLine(list);

        //Assert
        Assert.Equal(answer, output);
    }

    [Fact]
    public void Resolutions_1920x1080___1024x768_800x600_640x480_Gives_Correct_Answer() {
        //Arrange
        var list = new List<string> {"1920x1080", "1024x768, 800x600, 640x480"};
        var answer = new List<(int, int)> {(1920, 1080), (1024, 768), (800, 600), (640, 480)};

        //Act
        var output = RegExpr.Resolution(list);

        //Assert
        Assert.Equal(answer, output);
    }

    [Fact]
    public void Inner_Text_On_HTML_GIVES_theoretical_computer_science_formal_language_characters_pattern_string_searching_algorithms_strings() {
        //Arrange
        var HTML = "<div><p>A <b>regular expression</b>, <b>regex</b> or <b>regexp</b> (sometimes called a <b>rational expression</b>) is, in <a href=\"https://en.wikipedia.org/wiki/Theoretical_computer_science\" title=\"Theoretical computer science\">theoretical computer science</a> and <a href=\"https://en.wikipedia.org/wiki/Formal_language\" title=\"Formal language\">formal language</a> theory, a sequence of <a href=\"https://en.wikipedia.org/wiki/Character_(computing)\" title=\"Character (computing)\">characters</a> that define a <i>search <a href=\"https://en.wikipedia.org/wiki/Pattern_matching\" title=\"Pattern matching\">pattern</a></i>. Usually this pattern is then used by <a href=\"https://en.wikipedia.org/wiki/String_searching_algorithm\" title=\"String searching algorithm\">string searching algorithms</a> for \"find\" or \"find and replace\" operations on <a href=\"https://en.wikipedia.org/wiki/String_(computer_science)\" title=\"String (computer science)\">strings</a>.</p></div>";
        var answer = new List<string> {"theoretical computer science", "formal language", "characters", "pattern", "string searching algorithms", "strings"};
        //Act
        var output = RegExpr.InnerText(HTML, "a");

        //Assert
        Assert.Equal(answer, output);
    }

    [Fact]
    public void Urls_On_HTML_Gives_Correct_Answer() {
        //Arrange
        var HTML = "<div><p>A <b>regular expression</b>, <b>regex</b> or <b>regexp</b> (sometimes called a <b>rational expression</b>) is, in <a href=\"https://en.wikipedia.org/wiki/Theoretical_computer_science\" title=\"Theoretical computer science\">theoretical computer science</a> and <a href=\"https://en.wikipedia.org/wiki/Formal_language\" title=\"Formal language\">formal language</a> theory, a sequence of <a href=\"https://en.wikipedia.org/wiki/Character_(computing)\" title=\"Character (computing)\">characters</a> that define a <i>search <a href=\"https://en.wikipedia.org/wiki/Pattern_matching\" title=\"Pattern matching\">pattern</a></i>. Usually this pattern is then used by <a href=\"https://en.wikipedia.org/wiki/String_searching_algorithm\">string searching algorithms</a> for \"find\" or \"find and replace\" operations on <a href=\"https://en.wikipedia.org/wiki/String_(computer_science)\">strings</a>.</p></div>";
        var answer = new List<(Uri , string)> {(new Uri("https://en.wikipedia.org/wiki/Theoretical_computer_science"), "Theoretical computer science"), (new Uri("https://en.wikipedia.org/wiki/Formal_language"), "Formal language"), (new Uri("https://en.wikipedia.org/wiki/Character_(computing)"), "Character (computing)"), (new Uri("https://en.wikipedia.org/wiki/Pattern_matching"), "Pattern matching"), (new Uri("https://en.wikipedia.org/wiki/String_searching_algorithm"), "string searching algorithms"), (new Uri("https://en.wikipedia.org/wiki/String_(computer_science)"), "strings")}; 
        
        //Act
        var output = RegExpr.Urls(HTML);

        //Assert
        Assert.Equal(answer, output);
    }

}