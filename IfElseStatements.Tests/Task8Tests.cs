﻿using System.Diagnostics;
using NUnit.Framework;

namespace IfStatements.Tests
{
    [TestFixture]
    public class Task8Tests
    {
        [TestCase(0, 0, ExpectedResult = 0)]
        [TestCase(0, 1, ExpectedResult = 1)]
        [TestCase(0, 2, ExpectedResult = 2)]
        [TestCase(0, 3, ExpectedResult = 3)]
        [TestCase(0, 4, ExpectedResult = 4)]
        [TestCase(0, 5, ExpectedResult = 5)]
        [TestCase(0, 6, ExpectedResult = 6)]
        [TestCase(0, 7, ExpectedResult = 7)]
        [TestCase(0, 8, ExpectedResult = 8)]
        [TestCase(0, 9, ExpectedResult = 9)]
        [TestCase(0, 10, ExpectedResult = 10)]
        [TestCase(0, -1, ExpectedResult = -1)]
        [TestCase(0, -2, ExpectedResult = -2)]
        [TestCase(0, -3, ExpectedResult = 3)]
        [TestCase(0, -4, ExpectedResult = 4)]
        [TestCase(0, -5, ExpectedResult = 5)]
        [TestCase(0, -6, ExpectedResult = 6)]
        [TestCase(0, -7, ExpectedResult = 7)]
        [TestCase(0, -8, ExpectedResult = 8)]
        [TestCase(0, -9, ExpectedResult = 9)]
        [TestCase(0, -10, ExpectedResult = 10)]
        [TestCase(1, 0, ExpectedResult = -1)]
        [TestCase(1, 1, ExpectedResult = 0)]
        [TestCase(1, 2, ExpectedResult = 1)]
        [TestCase(1, 3, ExpectedResult = 2)]
        [TestCase(1, 4, ExpectedResult = 3)]
        [TestCase(1, 5, ExpectedResult = 4)]
        [TestCase(1, 6, ExpectedResult = 7)]
        [TestCase(1, 7, ExpectedResult = 8)]
        [TestCase(1, 8, ExpectedResult = 9)]
        [TestCase(1, 9, ExpectedResult = 10)]
        [TestCase(1, 10, ExpectedResult = 11)]
        [TestCase(1, -1, ExpectedResult = -2)]
        [TestCase(1, -2, ExpectedResult = -3)]
        [TestCase(1, -3, ExpectedResult = 5)]
        [TestCase(1, -4, ExpectedResult = 6)]
        [TestCase(1, -5, ExpectedResult = 7)]
        [TestCase(1, -6, ExpectedResult = 8)]
        [TestCase(1, -7, ExpectedResult = 9)]
        [TestCase(1, -8, ExpectedResult = 10)]
        [TestCase(1, -9, ExpectedResult = 11)]
        [TestCase(1, -10, ExpectedResult = 12)]
        [TestCase(2, 0, ExpectedResult = -4)]
        [TestCase(2, 1, ExpectedResult = -3)]
        [TestCase(2, 2, ExpectedResult = -2)]
        [TestCase(2, 3, ExpectedResult = -1)]
        [TestCase(2, 4, ExpectedResult = 0)]
        [TestCase(2, 5, ExpectedResult = 1)]
        [TestCase(2, 6, ExpectedResult = 8)]
        [TestCase(2, 7, ExpectedResult = 9)]
        [TestCase(2, 8, ExpectedResult = 10)]
        [TestCase(2, 9, ExpectedResult = 11)]
        [TestCase(2, 10, ExpectedResult = 12)]
        [TestCase(2, -1, ExpectedResult = -5)]
        [TestCase(2, -2, ExpectedResult = -6)]
        [TestCase(2, -3, ExpectedResult = 7)]
        [TestCase(2, -4, ExpectedResult = 8)]
        [TestCase(2, -5, ExpectedResult = 9)]
        [TestCase(2, -6, ExpectedResult = 10)]
        [TestCase(2, -7, ExpectedResult = 11)]
        [TestCase(2, -8, ExpectedResult = 12)]
        [TestCase(2, -9, ExpectedResult = 13)]
        [TestCase(2, -10, ExpectedResult = 14)]
        [TestCase(3, 0, ExpectedResult = -9)]
        [TestCase(3, 1, ExpectedResult = -8)]
        [TestCase(3, 2, ExpectedResult = -7)]
        [TestCase(3, 3, ExpectedResult = -6)]
        [TestCase(3, 4, ExpectedResult = -5)]
        [TestCase(3, 5, ExpectedResult = -4)]
        [TestCase(3, 6, ExpectedResult = 9)]
        [TestCase(3, 7, ExpectedResult = 10)]
        [TestCase(3, 8, ExpectedResult = 11)]
        [TestCase(3, 9, ExpectedResult = 12)]
        [TestCase(3, 10, ExpectedResult = 13)]
        [TestCase(3, -1, ExpectedResult = -10)]
        [TestCase(3, -2, ExpectedResult = -11)]
        [TestCase(3, -3, ExpectedResult = 9)]
        [TestCase(3, -4, ExpectedResult = 10)]
        [TestCase(3, -5, ExpectedResult = 11)]
        [TestCase(3, -6, ExpectedResult = 12)]
        [TestCase(3, -7, ExpectedResult = 13)]
        [TestCase(3, -8, ExpectedResult = 14)]
        [TestCase(3, -9, ExpectedResult = 15)]
        [TestCase(3, -10, ExpectedResult = 16)]
        [TestCase(4, 0, ExpectedResult = -16)]
        [TestCase(4, 1, ExpectedResult = -15)]
        [TestCase(4, 2, ExpectedResult = -14)]
        [TestCase(4, 3, ExpectedResult = -13)]
        [TestCase(4, 4, ExpectedResult = -12)]
        [TestCase(4, 5, ExpectedResult = -11)]
        [TestCase(4, 6, ExpectedResult = 10)]
        [TestCase(4, 7, ExpectedResult = 11)]
        [TestCase(4, 8, ExpectedResult = 12)]
        [TestCase(4, 9, ExpectedResult = 13)]
        [TestCase(4, 10, ExpectedResult = 14)]
        [TestCase(4, -1, ExpectedResult = -17)]
        [TestCase(4, -2, ExpectedResult = -18)]
        [TestCase(4, -3, ExpectedResult = 11)]
        [TestCase(4, -4, ExpectedResult = 12)]
        [TestCase(4, -5, ExpectedResult = 13)]
        [TestCase(4, -6, ExpectedResult = 14)]
        [TestCase(4, -7, ExpectedResult = 15)]
        [TestCase(4, -8, ExpectedResult = 16)]
        [TestCase(4, -9, ExpectedResult = 17)]
        [TestCase(4, -10, ExpectedResult = 18)]
        [TestCase(5, 0, ExpectedResult = -25)]
        [TestCase(5, 1, ExpectedResult = -24)]
        [TestCase(5, 2, ExpectedResult = -23)]
        [TestCase(5, 3, ExpectedResult = -22)]
        [TestCase(5, 4, ExpectedResult = -21)]
        [TestCase(5, 5, ExpectedResult = -20)]
        [TestCase(5, 6, ExpectedResult = 11)]
        [TestCase(5, 7, ExpectedResult = 12)]
        [TestCase(5, 8, ExpectedResult = 13)]
        [TestCase(5, 9, ExpectedResult = 14)]
        [TestCase(5, 10, ExpectedResult = 15)]
        [TestCase(5, -1, ExpectedResult = -26)]
        [TestCase(5, -2, ExpectedResult = -27)]
        [TestCase(5, -3, ExpectedResult = 13)]
        [TestCase(5, -4, ExpectedResult = 14)]
        [TestCase(5, -5, ExpectedResult = 15)]
        [TestCase(5, -6, ExpectedResult = 16)]
        [TestCase(5, -7, ExpectedResult = 17)]
        [TestCase(5, -8, ExpectedResult = 18)]
        [TestCase(5, -9, ExpectedResult = 19)]
        [TestCase(5, -10, ExpectedResult = 20)]
        [TestCase(6, 0, ExpectedResult = -36)]
        [TestCase(6, 1, ExpectedResult = -35)]
        [TestCase(6, 2, ExpectedResult = -34)]
        [TestCase(6, 3, ExpectedResult = -33)]
        [TestCase(6, 4, ExpectedResult = -32)]
        [TestCase(6, 5, ExpectedResult = -31)]
        [TestCase(6, 6, ExpectedResult = 12)]
        [TestCase(6, 7, ExpectedResult = 13)]
        [TestCase(6, 8, ExpectedResult = 14)]
        [TestCase(6, 9, ExpectedResult = 15)]
        [TestCase(6, 10, ExpectedResult = 16)]
        [TestCase(6, -1, ExpectedResult = -37)]
        [TestCase(6, -2, ExpectedResult = -38)]
        [TestCase(6, -3, ExpectedResult = 15)]
        [TestCase(6, -4, ExpectedResult = 16)]
        [TestCase(6, -5, ExpectedResult = 17)]
        [TestCase(6, -6, ExpectedResult = 18)]
        [TestCase(6, -7, ExpectedResult = 19)]
        [TestCase(6, -8, ExpectedResult = 20)]
        [TestCase(6, -9, ExpectedResult = 21)]
        [TestCase(6, -10, ExpectedResult = 22)]
        [TestCase(7, 0, ExpectedResult = -49)]
        [TestCase(7, 1, ExpectedResult = -48)]
        [TestCase(7, 2, ExpectedResult = -47)]
        [TestCase(7, 3, ExpectedResult = -46)]
        [TestCase(7, 4, ExpectedResult = -45)]
        [TestCase(7, 5, ExpectedResult = -44)]
        [TestCase(7, 6, ExpectedResult = 13)]
        [TestCase(7, 7, ExpectedResult = 14)]
        [TestCase(7, 8, ExpectedResult = 15)]
        [TestCase(7, 9, ExpectedResult = 16)]
        [TestCase(7, 10, ExpectedResult = 17)]
        [TestCase(7, -1, ExpectedResult = -50)]
        [TestCase(7, -2, ExpectedResult = -51)]
        [TestCase(7, -3, ExpectedResult = 17)]
        [TestCase(7, -4, ExpectedResult = 18)]
        [TestCase(7, -5, ExpectedResult = 19)]
        [TestCase(7, -6, ExpectedResult = 20)]
        [TestCase(7, -7, ExpectedResult = 21)]
        [TestCase(7, -8, ExpectedResult = 22)]
        [TestCase(7, -9, ExpectedResult = 23)]
        [TestCase(7, -10, ExpectedResult = 24)]
        [TestCase(8, 0, ExpectedResult = -64)]
        [TestCase(8, 1, ExpectedResult = -63)]
        [TestCase(8, 2, ExpectedResult = -62)]
        [TestCase(8, 3, ExpectedResult = -61)]
        [TestCase(8, 4, ExpectedResult = -60)]
        [TestCase(8, 5, ExpectedResult = -59)]
        [TestCase(8, 6, ExpectedResult = 14)]
        [TestCase(8, 7, ExpectedResult = 15)]
        [TestCase(8, 8, ExpectedResult = 16)]
        [TestCase(8, 9, ExpectedResult = 17)]
        [TestCase(8, 10, ExpectedResult = 18)]
        [TestCase(8, -1, ExpectedResult = -65)]
        [TestCase(8, -2, ExpectedResult = -66)]
        [TestCase(8, -3, ExpectedResult = 19)]
        [TestCase(8, -4, ExpectedResult = 20)]
        [TestCase(8, -5, ExpectedResult = 21)]
        [TestCase(8, -6, ExpectedResult = 22)]
        [TestCase(8, -7, ExpectedResult = 23)]
        [TestCase(8, -8, ExpectedResult = 24)]
        [TestCase(8, -9, ExpectedResult = 25)]
        [TestCase(8, -10, ExpectedResult = 26)]
        [TestCase(9, 0, ExpectedResult = 0)]
        [TestCase(9, 1, ExpectedResult = 9)]
        [TestCase(9, 2, ExpectedResult = 18)]
        [TestCase(9, 3, ExpectedResult = 27)]
        [TestCase(9, 4, ExpectedResult = 36)]
        [TestCase(9, 5, ExpectedResult = 45)]
        [TestCase(9, 6, ExpectedResult = 54)]
        [TestCase(9, 7, ExpectedResult = -40)]
        [TestCase(9, 8, ExpectedResult = -55)]
        [TestCase(9, 9, ExpectedResult = -72)]
        [TestCase(9, 10, ExpectedResult = -91)]
        [TestCase(9, -1, ExpectedResult = -9)]
        [TestCase(9, -2, ExpectedResult = -18)]
        [TestCase(9, -3, ExpectedResult = -27)]
        [TestCase(9, -4, ExpectedResult = -36)]
        [TestCase(9, -5, ExpectedResult = -45)]
        [TestCase(9, -6, ExpectedResult = -54)]
        [TestCase(9, -7, ExpectedResult = -63)]
        [TestCase(9, -8, ExpectedResult = 34)]
        [TestCase(9, -9, ExpectedResult = 36)]
        [TestCase(9, -10, ExpectedResult = 38)]
        [TestCase(10, 0, ExpectedResult = 0)]
        [TestCase(10, 1, ExpectedResult = 10)]
        [TestCase(10, 2, ExpectedResult = 20)]
        [TestCase(10, 3, ExpectedResult = 30)]
        [TestCase(10, 4, ExpectedResult = 40)]
        [TestCase(10, 5, ExpectedResult = 50)]
        [TestCase(10, 6, ExpectedResult = 60)]
        [TestCase(10, 7, ExpectedResult = -39)]
        [TestCase(10, 8, ExpectedResult = -54)]
        [TestCase(10, 9, ExpectedResult = -71)]
        [TestCase(10, 10, ExpectedResult = -90)]
        [TestCase(10, -1, ExpectedResult = -10)]
        [TestCase(10, -2, ExpectedResult = -20)]
        [TestCase(10, -3, ExpectedResult = -30)]
        [TestCase(10, -4, ExpectedResult = -40)]
        [TestCase(10, -5, ExpectedResult = -50)]
        [TestCase(10, -6, ExpectedResult = -60)]
        [TestCase(10, -7, ExpectedResult = -70)]
        [TestCase(10, -8, ExpectedResult = 36)]
        [TestCase(10, -9, ExpectedResult = 38)]
        [TestCase(10, -10, ExpectedResult = 40)]
        [TestCase(-1, 0, ExpectedResult = -1)]
        [TestCase(-1, 1, ExpectedResult = 0)]
        [TestCase(-1, 2, ExpectedResult = 1)]
        [TestCase(-1, 3, ExpectedResult = 2)]
        [TestCase(-1, 4, ExpectedResult = 3)]
        [TestCase(-1, 5, ExpectedResult = 4)]
        [TestCase(-1, 6, ExpectedResult = 5)]
        [TestCase(-1, 7, ExpectedResult = 6)]
        [TestCase(-1, 8, ExpectedResult = 7)]
        [TestCase(-1, 9, ExpectedResult = 8)]
        [TestCase(-1, 10, ExpectedResult = 9)]
        [TestCase(-1, -1, ExpectedResult = -2)]
        [TestCase(-1, -2, ExpectedResult = -3)]
        [TestCase(-1, -3, ExpectedResult = 1)]
        [TestCase(-1, -4, ExpectedResult = 2)]
        [TestCase(-1, -5, ExpectedResult = 3)]
        [TestCase(-1, -6, ExpectedResult = 4)]
        [TestCase(-1, -7, ExpectedResult = 5)]
        [TestCase(-1, -8, ExpectedResult = 6)]
        [TestCase(-1, -9, ExpectedResult = 7)]
        [TestCase(-1, -10, ExpectedResult = 8)]
        [TestCase(-2, 0, ExpectedResult = -4)]
        [TestCase(-2, 1, ExpectedResult = -3)]
        [TestCase(-2, 2, ExpectedResult = -2)]
        [TestCase(-2, 3, ExpectedResult = -1)]
        [TestCase(-2, 4, ExpectedResult = 0)]
        [TestCase(-2, 5, ExpectedResult = 1)]
        [TestCase(-2, 6, ExpectedResult = 4)]
        [TestCase(-2, 7, ExpectedResult = 5)]
        [TestCase(-2, 8, ExpectedResult = 6)]
        [TestCase(-2, 9, ExpectedResult = 7)]
        [TestCase(-2, 10, ExpectedResult = 8)]
        [TestCase(-2, -1, ExpectedResult = -5)]
        [TestCase(-2, -2, ExpectedResult = -6)]
        [TestCase(-2, -3, ExpectedResult = -1)]
        [TestCase(-2, -4, ExpectedResult = 0)]
        [TestCase(-2, -5, ExpectedResult = 1)]
        [TestCase(-2, -6, ExpectedResult = 2)]
        [TestCase(-2, -7, ExpectedResult = 3)]
        [TestCase(-2, -8, ExpectedResult = 4)]
        [TestCase(-2, -9, ExpectedResult = 5)]
        [TestCase(-2, -10, ExpectedResult = 6)]
        [TestCase(-3, 0, ExpectedResult = -9)]
        [TestCase(-3, 1, ExpectedResult = -8)]
        [TestCase(-3, 2, ExpectedResult = -7)]
        [TestCase(-3, 3, ExpectedResult = -6)]
        [TestCase(-3, 4, ExpectedResult = -5)]
        [TestCase(-3, 5, ExpectedResult = -4)]
        [TestCase(-3, 6, ExpectedResult = 3)]
        [TestCase(-3, 7, ExpectedResult = 4)]
        [TestCase(-3, 8, ExpectedResult = 5)]
        [TestCase(-3, 9, ExpectedResult = 6)]
        [TestCase(-3, 10, ExpectedResult = 7)]
        [TestCase(-3, -1, ExpectedResult = -10)]
        [TestCase(-3, -2, ExpectedResult = -11)]
        [TestCase(-3, -3, ExpectedResult = -3)]
        [TestCase(-3, -4, ExpectedResult = -2)]
        [TestCase(-3, -5, ExpectedResult = -1)]
        [TestCase(-3, -6, ExpectedResult = 0)]
        [TestCase(-3, -7, ExpectedResult = 1)]
        [TestCase(-3, -8, ExpectedResult = 2)]
        [TestCase(-3, -9, ExpectedResult = 3)]
        [TestCase(-3, -10, ExpectedResult = 4)]
        [TestCase(-4, 0, ExpectedResult = -16)]
        [TestCase(-4, 1, ExpectedResult = -15)]
        [TestCase(-4, 2, ExpectedResult = -14)]
        [TestCase(-4, 3, ExpectedResult = -13)]
        [TestCase(-4, 4, ExpectedResult = -12)]
        [TestCase(-4, 5, ExpectedResult = -11)]
        [TestCase(-4, 6, ExpectedResult = 2)]
        [TestCase(-4, 7, ExpectedResult = 3)]
        [TestCase(-4, 8, ExpectedResult = 4)]
        [TestCase(-4, 9, ExpectedResult = 5)]
        [TestCase(-4, 10, ExpectedResult = 6)]
        [TestCase(-4, -1, ExpectedResult = -17)]
        [TestCase(-4, -2, ExpectedResult = -18)]
        [TestCase(-4, -3, ExpectedResult = -5)]
        [TestCase(-4, -4, ExpectedResult = -4)]
        [TestCase(-4, -5, ExpectedResult = -3)]
        [TestCase(-4, -6, ExpectedResult = -2)]
        [TestCase(-4, -7, ExpectedResult = -1)]
        [TestCase(-4, -8, ExpectedResult = 0)]
        [TestCase(-4, -9, ExpectedResult = 1)]
        [TestCase(-4, -10, ExpectedResult = 2)]
        [TestCase(-5, 0, ExpectedResult = -5)]
        [TestCase(-5, 1, ExpectedResult = -6)]
        [TestCase(-5, 2, ExpectedResult = -7)]
        [TestCase(-5, 3, ExpectedResult = -8)]
        [TestCase(-5, 4, ExpectedResult = -9)]
        [TestCase(-5, 5, ExpectedResult = -10)]
        [TestCase(-5, 6, ExpectedResult = -11)]
        [TestCase(-5, 7, ExpectedResult = 19)]
        [TestCase(-5, 8, ExpectedResult = 21)]
        [TestCase(-5, 9, ExpectedResult = 23)]
        [TestCase(-5, 10, ExpectedResult = 25)]
        [TestCase(-5, -1, ExpectedResult = -4)]
        [TestCase(-5, -2, ExpectedResult = -3)]
        [TestCase(-5, -3, ExpectedResult = -2)]
        [TestCase(-5, -4, ExpectedResult = -1)]
        [TestCase(-5, -5, ExpectedResult = 0)]
        [TestCase(-5, -6, ExpectedResult = -1)]
        [TestCase(-5, -7, ExpectedResult = -2)]
        [TestCase(-5, -8, ExpectedResult = -3)]
        [TestCase(-5, -9, ExpectedResult = -4)]
        [TestCase(-5, -10, ExpectedResult = -5)]
        [TestCase(-6, 0, ExpectedResult = -6)]
        [TestCase(-6, 1, ExpectedResult = -7)]
        [TestCase(-6, 2, ExpectedResult = -8)]
        [TestCase(-6, 3, ExpectedResult = -9)]
        [TestCase(-6, 4, ExpectedResult = -10)]
        [TestCase(-6, 5, ExpectedResult = -11)]
        [TestCase(-6, 6, ExpectedResult = -12)]
        [TestCase(-6, 7, ExpectedResult = 20)]
        [TestCase(-6, 8, ExpectedResult = 22)]
        [TestCase(-6, 9, ExpectedResult = 24)]
        [TestCase(-6, 10, ExpectedResult = 26)]
        [TestCase(-6, -1, ExpectedResult = -5)]
        [TestCase(-6, -2, ExpectedResult = -4)]
        [TestCase(-6, -3, ExpectedResult = -3)]
        [TestCase(-6, -4, ExpectedResult = -2)]
        [TestCase(-6, -5, ExpectedResult = -1)]
        [TestCase(-6, -6, ExpectedResult = 0)]
        [TestCase(-6, -7, ExpectedResult = -1)]
        [TestCase(-6, -8, ExpectedResult = -2)]
        [TestCase(-6, -9, ExpectedResult = -3)]
        [TestCase(-6, -10, ExpectedResult = -4)]
        [TestCase(-7, 0, ExpectedResult = -7)]
        [TestCase(-7, 1, ExpectedResult = -8)]
        [TestCase(-7, 2, ExpectedResult = -9)]
        [TestCase(-7, 3, ExpectedResult = -10)]
        [TestCase(-7, 4, ExpectedResult = -11)]
        [TestCase(-7, 5, ExpectedResult = -12)]
        [TestCase(-7, 6, ExpectedResult = -13)]
        [TestCase(-7, 7, ExpectedResult = 21)]
        [TestCase(-7, 8, ExpectedResult = 23)]
        [TestCase(-7, 9, ExpectedResult = 25)]
        [TestCase(-7, 10, ExpectedResult = 27)]
        [TestCase(-7, -1, ExpectedResult = -6)]
        [TestCase(-7, -2, ExpectedResult = -5)]
        [TestCase(-7, -3, ExpectedResult = -4)]
        [TestCase(-7, -4, ExpectedResult = -3)]
        [TestCase(-7, -5, ExpectedResult = -2)]
        [TestCase(-7, -6, ExpectedResult = 1)]
        [TestCase(-7, -7, ExpectedResult = 0)]
        [TestCase(-7, -8, ExpectedResult = -1)]
        [TestCase(-7, -9, ExpectedResult = -2)]
        [TestCase(-7, -10, ExpectedResult = -3)]
        [TestCase(-8, 0, ExpectedResult = -8)]
        [TestCase(-8, 1, ExpectedResult = -9)]
        [TestCase(-8, 2, ExpectedResult = -10)]
        [TestCase(-8, 3, ExpectedResult = -11)]
        [TestCase(-8, 4, ExpectedResult = -12)]
        [TestCase(-8, 5, ExpectedResult = -13)]
        [TestCase(-8, 6, ExpectedResult = -14)]
        [TestCase(-8, 7, ExpectedResult = 22)]
        [TestCase(-8, 8, ExpectedResult = 24)]
        [TestCase(-8, 9, ExpectedResult = 26)]
        [TestCase(-8, 10, ExpectedResult = 28)]
        [TestCase(-8, -1, ExpectedResult = -7)]
        [TestCase(-8, -2, ExpectedResult = -6)]
        [TestCase(-8, -3, ExpectedResult = -5)]
        [TestCase(-8, -4, ExpectedResult = -4)]
        [TestCase(-8, -5, ExpectedResult = -3)]
        [TestCase(-8, -6, ExpectedResult = 2)]
        [TestCase(-8, -7, ExpectedResult = 1)]
        [TestCase(-8, -8, ExpectedResult = 0)]
        [TestCase(-8, -9, ExpectedResult = -1)]
        [TestCase(-8, -10, ExpectedResult = -2)]
        [TestCase(-9, 0, ExpectedResult = -9)]
        [TestCase(-9, 1, ExpectedResult = -10)]
        [TestCase(-9, 2, ExpectedResult = -11)]
        [TestCase(-9, 3, ExpectedResult = -12)]
        [TestCase(-9, 4, ExpectedResult = -13)]
        [TestCase(-9, 5, ExpectedResult = -14)]
        [TestCase(-9, 6, ExpectedResult = -15)]
        [TestCase(-9, 7, ExpectedResult = 23)]
        [TestCase(-9, 8, ExpectedResult = 25)]
        [TestCase(-9, 9, ExpectedResult = 27)]
        [TestCase(-9, 10, ExpectedResult = 29)]
        [TestCase(-9, -1, ExpectedResult = -8)]
        [TestCase(-9, -2, ExpectedResult = -7)]
        [TestCase(-9, -3, ExpectedResult = -6)]
        [TestCase(-9, -4, ExpectedResult = -5)]
        [TestCase(-9, -5, ExpectedResult = -4)]
        [TestCase(-9, -6, ExpectedResult = 3)]
        [TestCase(-9, -7, ExpectedResult = 2)]
        [TestCase(-9, -8, ExpectedResult = 1)]
        [TestCase(-9, -9, ExpectedResult = 0)]
        [TestCase(-9, -10, ExpectedResult = -1)]
        [TestCase(-10, 0, ExpectedResult = -10)]
        [TestCase(-10, 1, ExpectedResult = -11)]
        [TestCase(-10, 2, ExpectedResult = -12)]
        [TestCase(-10, 3, ExpectedResult = -13)]
        [TestCase(-10, 4, ExpectedResult = -14)]
        [TestCase(-10, 5, ExpectedResult = -15)]
        [TestCase(-10, 6, ExpectedResult = -16)]
        [TestCase(-10, 7, ExpectedResult = 24)]
        [TestCase(-10, 8, ExpectedResult = 26)]
        [TestCase(-10, 9, ExpectedResult = 28)]
        [TestCase(-10, 10, ExpectedResult = 30)]
        [TestCase(-10, -1, ExpectedResult = -9)]
        [TestCase(-10, -2, ExpectedResult = -8)]
        [TestCase(-10, -3, ExpectedResult = -7)]
        [TestCase(-10, -4, ExpectedResult = -6)]
        [TestCase(-10, -5, ExpectedResult = -5)]
        [TestCase(-10, -6, ExpectedResult = 4)]
        [TestCase(-10, -7, ExpectedResult = 3)]
        [TestCase(-10, -8, ExpectedResult = 2)]
        [TestCase(-10, -9, ExpectedResult = 1)]
        [TestCase(-10, -10, ExpectedResult = 0)]
        public int DoSomething_ReturnsInteger(int i1, int i2)
        {
            return Task8.DoSomething(i1, i2);
        }

        [Test]
        public void GenerateTestCases()
        {
            const string template = "[TestCase({0}, {1}, ExpectedResult = {2})]";

            for (int i1 = -1; i1 >= -10; i1--)
            {
                for (int i2 = 0; i2 <= 10; i2++)
                {
                    var expected = Task8.DoSomething(i1, i2);
                    var result = Task8.DoSomething(i1, i2);
                    Assert.AreEqual(expected, result, $"Test failed for inputs ({i1}, {i2})");
                    Debug.WriteLine(template, i1, i2, result);
                }

                for (int i2 = -1; i2 >= -10; i2--)
                {
                    var result = Task8.DoSomething(i1, i2);
                    Debug.WriteLine(template, i1, i2, result);
                }
            }
        }
    }
}
