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
}