using DevFast.Net.Collection.Implementations.ReSizing;

namespace DevFast.Net.Collection.Tests.Implementations.ReSizing;

[TestFixture]
public class NoResizingTest
{
    [Test]
    public void Default_Instance_Is_Unique()
    {
        That(ReferenceEquals(NoResizing.Default, NoResizing.Default), Is.True);
    }

    [Test]
    public void CanResize_Always_Returns_False()
    {
        That(NoResizing.Default.CanResize, Is.False);
    }

    [Test]
    public void TryComputeNewSize_Always_Returns_False_With_NewSize_As_Zero()
    {
        That(NoResizing.Default.TryComputeNewSize(0, out int newSize), Is.False);
        That(newSize, Is.EqualTo(0));
        That(NoResizing.Default.TryComputeNewSize(10, out newSize), Is.False);
        That(newSize, Is.EqualTo(0));
        That(NoResizing.Default.TryComputeNewSize(int.MinValue, out newSize), Is.False);
        That(newSize, Is.EqualTo(0));
    }
}
