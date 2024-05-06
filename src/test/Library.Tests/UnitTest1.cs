using NUnit.Framework;
namespace Library.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void AllZero()
    {
        //A, B, C
        GarageGate gate = new GarageGate(false, false, false);
        Assert.That(gate.OpenDoor(), Is.EqualTo("Door closed"));
        
    }
    [Test]
    public void OneZeroZero()
    {
        //A, B, C
        GarageGate gate = new GarageGate(true, false, false);
        Assert.That(gate.OpenDoor(), Is.EqualTo("Door closed"));
        
    }
    [Test]
    public void ZeroOneZero()
    {
        //A, B, C
        GarageGate gate = new GarageGate(false, true, false);
        Assert.That(gate.OpenDoor(), Is.EqualTo("Door closed"));
        
    }
    [Test]
    public void OneOneZero()
    {
        //A, B, C
        GarageGate gate = new GarageGate(true, true, false);
        Assert.That(gate.OpenDoor(), Is.EqualTo("Door closed"));
        
    }
    [Test]
    public void ZeroZeroOne()
    {
        //A, B, C
        GarageGate gate = new GarageGate(false, false, true);
        Assert.That(gate.OpenDoor(), Is.EqualTo("Opening door"));
        
    }
    [Test]
    public void OneZeroOne()
    {
        //A, B, C
        GarageGate gate = new GarageGate(true, false, true);
        Assert.That(gate.OpenDoor(), Is.EqualTo("Door closed"));
        
    }
    [Test]
    public void ZeroOneOne()
    {
        //A, B, C
        GarageGate gate = new GarageGate(false, true, true);
        Assert.That(gate.OpenDoor(), Is.EqualTo("Door closed"));
        
    }
    [Test]
    public void OneOneOne()
    {
        //A, B, C
        GarageGate gate = new GarageGate(true, true, true);
        Assert.That(gate.OpenDoor(), Is.EqualTo("Opening door"));
        
    }
}