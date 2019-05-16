using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
namespace Lab17
{
    public class MethodTest
    {
        [Fact]
        public void Test1()
        {
            int actual = Method.GetPrime(1);
            int expected = 2;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test2()
        {
            int actual = Method.GetPrime(2);
            int expected = 3;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test3()
        {
            int actual = Method.GetPrime(3);
            int expected = 5;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test4()
        {
            int actual = Method.GetPrime(4);
            int expected = 7;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test5()
        {
            int actual = Method.GetPrime(5);
            int expected = 11;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test6()
        {
            int actual = Method.GetPrime(6);
            int expected = 13;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test7()
        {
            int actual = Method.GetPrime(7);
            int expected = 17;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test8()
        {
            int actual = Method.GetPrime(8);
            int expected = 19;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test9()
        {
            int actual = Method.GetPrime(9);
            int expected = 23;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test10()
        {
            int actual = Method.GetPrime(10);
            int expected = 29;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test11()
        {
            int actual = Method.GetPrime(11);
            int expected = 31;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test12()
        {
            int actual = Method.GetPrime(12);
            int expected = 37;
            Assert.Equal(expected, actual);
        }


    }
}
