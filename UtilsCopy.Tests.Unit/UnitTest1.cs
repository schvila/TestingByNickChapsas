using FluentAssertions;
using Xunit;
using Utils;
namespace UtilsCopy.Tests.Unit;

public class UnitTest1
{
    [Fact]
    public void PlayerData_DeepCloneJson()
    {
        PlayerData pd1 = new PlayerData()
        {
            AccountFrom = DateTime.Now,
            AccountTo = new DateTime(2024,10,1),
            BankAccount = "mbank",
            BankAccountIsValid = Player.eValidState.Valid,
            Card = "visa",
            City = "Zlin",
            Country = "CR"
        };
        var result = CopyLib.DeepCloneJson<PlayerData>(pd1);
        result.Should().BeEquivalentTo(pd1);

    }
    [Fact]
    public void VectorOfInt_DeepCloneJson()
    {
        List<List<int>> vector = new List<List<int>>()
        {
            {new List<int>(){1, 2, 3}},
            {new List<int>(){4, 5, 6}}
        };        
        var result = CopyLib.DeepCloneJson<List<List<int>>>(vector);
        result.Should().BeEquivalentTo(vector);

    }
}