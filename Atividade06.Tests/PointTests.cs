using Xunit;
using Atividade06;

namespace Atividade06.Tests;

public class DistanceToTests{

    [Fact]
    public void DistanceTo_WithNullArgument_ThrowsArgumentNullException()
    {
        var point = new Point(0, 0);
        Assert.Throws<ArgumentNullException>(() => point.DistanceTo(null));
    }

    [Fact]
    public void DistanceTo_WithPointAtOrigin_ReturnsCorrectDistance()
    {
        var point = new Point(0, 0);
        var other = new Point(3, 4);
        Assert.Equal(5, point.DistanceTo(other));
    }

    [Fact]
    public void DistanceTo_WithPointAtOrigin_ReturnsCorrectDistance2()
    {
        var point = new Point(0, 0);
        var other = new Point(5, 12);
        Assert.Equal(13, point.DistanceTo(other));
    }
    
}
