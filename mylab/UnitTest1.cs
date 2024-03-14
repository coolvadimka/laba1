using laba1;
using Xunit;
namespace mylab
{
    public class mylabtest
    {
        [Fact]
        public void sum5_6and3_7return53_42()
        {
            //arrange
            var p1 = new vadim(5, 6);
            var p2 = new vadim(3, 7);
            var res = new vadim(53, 42);
            //act
            var p3 = p1 + p2;
            //assert
            Assert.Equal(res.numerator / (double)res.denominator, p3.numerator / (double)p3.denominator);
        }
        [Fact]
        public void razn5_6and3_7return53_42()
        {
            //arrange
            var p1 = new vadim(5, 6);
            var p2 = new vadim(3, 7);
            var res = new vadim(17, 42);
            //act
            var p3 = p1 - p2;
            //assert
            Assert.Equal(res.numerator / (double)res.denominator, p3.numerator / (double)p3.denominator);
        }
        [Fact]
        public void proizv5_6and3_7return53_42()
        {
            //arrange
            var p1 = new vadim(5, 6);
            var p2 = new vadim(3, 7);
            var res = new vadim(5, 14);
            //act
            var p3 = p1 * p2;
            //assert
            Assert.Equal(res.numerator / (double)res.denominator, p3.numerator / (double)p3.denominator);
        }
        [Fact]
        public void del5_6and3_7return53_42()
        {
            //arrange
            var p1 = new vadim(5, 6);
            var p2 = new vadim(3, 7);
            var res = new vadim(35, 18);
            //act
            var p3 = p1 / p2;
            //assert
            Assert.Equal(res.numerator / (double)res.denominator, p3.numerator / (double)p3.denominator);
        }
        [Fact]
        public void ravenstvo()
        {
            //arrange
            var p1 = new vadim(5, 10);
            var p2 = new vadim(1, 2);
            var p3 = new vadim(1, 3);
            //act
            bool p4 = p1 == p2;
            bool p5 = p1 == p3;
            //assert
            Assert.Equal(p4, true);
            Assert.Equal(p5, false);
        }
        [Fact]
        public void neravenstvo()
        {
            //arrange
            var p1 = new vadim(5, 6);
            var p2 = new vadim(3, 7);
            var p3 = new vadim(5, 6);
            //act
            bool p4 = p1 != p2;
            bool p5 = p1 != p3;
            //assert
            Assert.Equal(p4, true);
            Assert.Equal(p5, false);
        }
        [Fact]
        public void bolshe()
        {
            //arrange
            var p1 = new vadim(5, 6);
            var p2 = new vadim(3, 7);
            var p3 = new vadim(10, 3);
            //act
            bool p4 = p1 > p2;
            bool p5 = p1 > p3;
            //assert
            Assert.Equal(p4, true);
            Assert.Equal(p5, false);

        }
        [Fact]
        public void menshe()
        {
            //arrange
            var p1 = new vadim(3, 9);
            var p2 = new vadim(3, 7);
            var p3 = new vadim(1, 9);
            //act
            bool p4 = p1 < p2;
            bool p5 = p1 < p3;
            //assert
            Assert.Equal(p4, true);
            Assert.Equal(p5, false);
        }
        [Fact]
        public void bolshe_or_ravno()
        {
            //arrange
            var p1 = new vadim(5, 6);
            var p2 = new vadim(3, 7);
            var p3 = new vadim(5, 6);
            //act
            bool p4 = p1 >= p2;
            bool p5 = p1 >= p3;
            //assert
            Assert.Equal(p4, true);
            Assert.Equal(p5, true);

        }
        [Fact]
        public void menshe_or_ravno()
        {
            //arrange
            var p1 = new vadim(3, 9);
            var p2 = new vadim(3, 7);
            var p3 = new vadim(3, 9);
            //act
            bool p4 = p1 <= p2;
            bool p5 = p1 <= p3;
            //assert
            Assert.Equal(p4, true);
            Assert.Equal(p5, true);
        }
        [Fact]
        public void vminus()
        {
            //arrange
            var p1 = new vadim(3, 7);
            var p2 = new vadim(-3, 7);
            //act
            var p3 = -p1;
            //assert
            Assert.Equal(p3.numerator / (double)p3.denominator, p2.numerator / (double)p2.denominator);

        }
    }
}