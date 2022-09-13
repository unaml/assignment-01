namespace Assignment1.Tests;
using static Assignment1.Iterators;

public class IteratorsTests
{

    [Fact]
    public void given_2dArray_flatten_to_1dArray()
    {
        // Arrange
        var matrix = new List<List<int>>();
        var row1 = new List<int> { 1, 2, 3 };
        var row2 = new List<int> { 4, 5, 6 };
        matrix.Add(row1);
        matrix.Add(row2);

        var expected = new List<int> { 1, 2, 3, 4, 5, 6 };
        // Act

        var result = Flatten(matrix);

        // Asert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void filter_Ienumerable_with_predicate()
    {
        // Arrange
        var lst = new List<int>() { 1, 2, 3, 4, 5, 6 };
        var expected = new List<int>() { 2, 4, 6 };

        Predicate<int> even = Even;
        bool Even(int i) => i % 2 == 0;
       
        // Act
        var result = Filter(lst, even);

        // Assert
        Assert.Equal(expected, result);
    }

}