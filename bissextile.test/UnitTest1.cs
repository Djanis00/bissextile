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

    [Fact]
    public void Annee_1700_est_non_bissextile()
    {
        var result = DateUtils.IsBissextile(1700);
        Assert.False(result);
    }


    [Fact]
    public void Annee_1900_est_non_bissextile()
    {
        var result = DateUtils.IsBissextile(1900);
        Assert.False(result);
    }

    [Fact]
    public void Annee_2024_est_bissextile()
    {
        var result = DateUtils.IsBissextile(2024);
        Assert.True(result);
    }

    [Fact]
    public void Annee_1996_est_bissextile()
    {
        var result = DateUtils.IsBissextile(1996);
        Assert.True(result);
    }

    [Fact]
    public void Annee_2023_est_non_bissextile()
    {
        var result = DateUtils.IsBissextile(2023);
        Assert.True(result);
    }

    [Fact]
    public void Annee_2019_est_non_bissextile()
    {
        var result = DateUtils.IsBissextile(2019);
        Assert.True(result);
    }

}
