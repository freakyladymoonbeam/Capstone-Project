using IoTPlatform.Domain.Entities;
using IoTPlatform.Domain.Enums;
using IoTPlatform.Domain.Exceptions;

namespace IoTPlatform.UnitTests.DeviceAssetTests;

[TestClass]
public class DeviceAssetTests
{
    [TestMethod]
    public void Constructor_ValidSerialNumber_CreatesDevice()
    {
        var device = new DeviceAsset(
            "DEV-12345",
            "Conveyor Belt",
            DateTime.UtcNow);

        Assert.AreEqual("DEV-12345", device.SerialNumber);
    }

    [TestMethod]
    public void Constructor_InvalidSerialNumber_ThrowsException()
    {
        try
        {
            new DeviceAsset(
                "BAD-12345",
                "Conveyor Belt",
                DateTime.UtcNow);

            Assert.Fail("Expected DomainException was not thrown.");
        }
        catch (DomainException)
        {
            // Test passes because the expected exception occurred.
        }
    }

    [TestMethod]
    public void ChangeStatus_RegisteredToActive_Succeeds()
    {
        var device = new DeviceAsset(
            "DEV-12345",
            "Robot Arm",
            DateTime.UtcNow);

        device.ChangeStatus(DeviceStatus.Active);

        Assert.AreEqual(
            DeviceStatus.Active,
            device.Status);
    }

    [TestMethod]
    public void ChangeStatus_RegisteredToRetired_ThrowsException()
    {
        try
        {
            var device = new DeviceAsset(
                "DEV-12345",
                "Robot Arm",
                DateTime.UtcNow);

            device.ChangeStatus(DeviceStatus.Retired);

            Assert.Fail("Expected DomainException was not thrown.");
        }
        catch (DomainException)
        {
            // Test passes because the expected exception occurred.
        }
    }
}