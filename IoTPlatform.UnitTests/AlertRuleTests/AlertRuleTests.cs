using IoTPlatform.Domain.Entities;
using IoTPlatform.Domain.Exceptions;

namespace IoTPlatform.UnitTests.AlertRuleTests;

[TestClass]
public class AlertRuleTests
{
    [TestMethod]
    public void Constructor_ValidRange_CreatesRule()
    {
        var rule = new AlertRule(
            Guid.NewGuid(),
            "Temperature Limit",
            10,
            100);

        Assert.AreEqual(10, rule.MinValue);
        Assert.AreEqual(100, rule.MaxValue);
    }

    [TestMethod]
    public void Constructor_NegativeMinimum_ThrowsException()
    {
        try
        {
            new AlertRule(
                Guid.NewGuid(),
                "Temperature Limit",
                -10,
                100);

            Assert.Fail("Expected DomainException was not thrown.");
        }
        catch (DomainException)
        {
            // Test passes because the expected exception occurred.
        }
    }

    [TestMethod]
    public void Constructor_MinimumGreaterThanMaximum_ThrowsException()
    {
        try
        {
            new AlertRule(
                Guid.NewGuid(),
                "Temperature Limit",
                200,
                100);
                
            Assert.Fail("Expected DomainException was not thrown.");
        }
        catch (DomainException)
        {
            // Test passes because the expected exception occurred.
        }
    }
}