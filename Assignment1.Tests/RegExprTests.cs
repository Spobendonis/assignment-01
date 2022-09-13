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
}