using Xunit;
using bissextile;

public class BissextileTests
{
    [Fact]
    public void Annee_divisible_par_400_est_bissextile()
    {
        var result = DateUtils.IsBissextile(2000);
        Assert.True(result);
    }
}
