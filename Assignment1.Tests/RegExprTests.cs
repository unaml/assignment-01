namespace Assignment1.Tests;
using static Assignment1.RegExpr;

public class RegExprTests
{
    [Fact]
    public void splitline_given_sentence_returns_word_list()
    {
        //Arrange
        var expected = new List<string> { "Hej", "med", "dig", "007" };
        var test = new List<string> { "Hej med", "dig 007" };

        //Act
        var result = SplitLine(test);

        //Assert
        Assert.Equal(expected, result);

    }

    [Fact]
    public void resolution_given_string_return_int_tuple_list()
    {
        //Arrange
        var expected = new List<(int, int)> {(1920,1080), (1024,768), (800,600), (640,480),
                                            (320,200), (320,240), (800,600), (1280,960)};
        var test = "1920x1080 1024x768, 800x600, 640x480 320x200, 320x240, 800x600 1280x960";

        //Act
        var result = Resolution(test);

        //Assert
        Assert.Equal(expected, result);

    }

    [Fact]
    public void innterText_given_html_returns_content_from_given_tag()
    {
        //Arrange
        var expected = new List<string>() { "theoretical computer science", "formal language", "characters", "pattern", "string searching algorithms", "strings" };
        var html = "<p>A <b>regular expression</b>, <b>regex</b> or <b>regexp</b> (sometimes called a <b>rational expression</b>) is, in <a href=\"/wiki/Theoretical_computer_science\" title=\"Theoretical computer science\">theoretical computer science</a> and <a href=\"/wiki/Formal_language\" title=\"Formal language\">formal language</a> theory, a sequence of <a href=\"/wiki/Character_(computing)\" title=\"Character (computing)\">characters</a> that define a <i>search <a href=\"/wiki/Pattern_matching\" title=\"Pattern matching\">pattern</a></i>. Usually this pattern is then used by <a href=\"/wiki/String_searching_algorithm\" title=\"String searching algorithm\">string searching algorithms</a> for \"find\" or \"find and replace\" operations on <a href=\"/wiki/String_(computer_science)\" title=\"String (computer science)\">strings</a>.</p>";
        var tag = "a";

        //Act
        var result = InnerText(html, tag);

        //Assert
        Assert.Equal(expected, result);

    }

    
    [Fact]
    public void innterText_given_NESTED_html_returns_content_from_given_tag()
    {
        //Arrange

        
        var expected = new List<string>() { "The phrase regular expressions (and consequently, regexes) is often used to mean the specific, standard textual syntax for representing patterns that matching text need to conform to."};
        var html = "<div><p>The phrase <i>regular expressions</i> (and consequently, regexes) is often used to mean the specific, standard textual syntax for representing <u>patterns</u> that matching <em>text</em> need to conform to.</p></div>";
        var tag = "p";

        //Act
        var result = InnerText(html, tag);

        //Assert
        Assert.Equal(expected, result);

    }
}