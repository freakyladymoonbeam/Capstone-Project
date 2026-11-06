using IoTPlatform.Domain.Entities;
using IoTPlatform.Domain.Exceptions;

namespace IoTPlatform.UnitTests.AlertRuleTests;

[TestClass]
public class AlertRuleTests
{
    /// <summary>
    /// Tests the constructor of the AlertRule class with a valid range.
    /// </summary>
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

    /// <summary>
    /// Tests the constructor of the AlertRule class with a negative minimum value.
    /// </summary>
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

    /// <summary>
    /// Tests the constructor of the AlertRule class with a minimum value greater than the maximum value.
    /// </summary>
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