using Xunit;
using bissextile;

public class BissextileTests
{
    [Fact]
    public void Annee_1600_est_bissextile()
    {
        var result = DateUtils.IsBissextile(1600);
        Assert.True(result);
    }

    [Fact]
    public void Annee_2000_est_bissextile()
    {
        var result = DateUtils.IsBissextile(2000);
        Assert.True(result);
    }

    [Fact]
    public void Annee_2400_est_bissextile()
    {
        var result = DateUtils.IsBissextile(2400);
        Assert.True(result);
    }

}
