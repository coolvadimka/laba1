using laba1;
namespace TestProject2
{
    [TestFixture]

    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        [TestCase(1, 2, "1 / 2")]
        [TestCase(5, 10, "1 / 2")]
        [TestCase(10, 5, "2")]
        [TestCase(-1, 2, "-1 / 2")]
        [TestCase(1, -2, "-1 / 2")]
        [TestCase(-2, 1, "-2")]
        public void Test_ToString(int n1, int d1, string res)
        {
            var ch1 = new vadim(n1, d1);
            Assert.That(ch1.ToString() == res, Is.True);
            
        }
        [Test]
        [TestCase(1, 2, 3, 4, 5, 4)]
        [TestCase(1, 2, -3, 4, 1, -4)]
        [TestCase(-1, -2, -3, -4, 5, 4)]
        [TestCase(-1, 2, -3, 4, 5, -4)]
        [TestCase(1, 2, 1, 2, 1, 1)]
        public void Test_Sums(int n1, int d1, int n2, int d2, int r1, int r2)
        {
            var ch1 = new vadim(n1, d1);
            var ch2 = new vadim(n2, d2);
            var res = ch1 + ch2;
            Assert.That(res.Numerator == r1, Is.True);
            Assert.That(res.Denominator == r2, Is.True);
        }
        [Test]
        [TestCase(1, 2, 3, 4, 1, -4)]
        [TestCase(1, 2, -3, 4, 5, 4)]
        [TestCase(-1, -2, -3, -4, 1, -4)]
        [TestCase(-1, 2, -3, 4, 1, 4)]
        [TestCase(1, 2, 1, 2, 0, 1)]
        public void Test_Difference(int n1, int d1, int n2, int d2, int r1, int r2)
        {
            var ch1 = new vadim(n1, d1);
            var ch2 = new vadim(n2, d2);
            var res = ch1 - ch2;
            Assert.That(res.Numerator == r1, Is.True);
            Assert.That(res.Denominator == r2, Is.True);
        }

        [Test]
        [TestCase(1, 2, 3, 4, 3, 8)]
        [TestCase(1, 2, -3, 4, 3, -8)]
        [TestCase(-1, -2, -3, -4, 3, 8)]
        [TestCase(-1, 2, -3, 4, 3, 8)]
        [TestCase(1, 2, 1, 2, 1, 4)]
        [TestCase(0, 4, 1, 4, 0, 1)]
        public void Test_Ñomposition(int n1, int d1, int n2, int d2, int r1, int r2)
        {
            var ch1 = new vadim(n1, d1);
            var ch2 = new vadim(n2, d2);
            var res = ch1 * ch2;
            Assert.That(res.Numerator == r1, Is.True);
            Assert.That(res.Denominator == r2, Is.True);
        }

        [Test]
        [TestCase(1, 2, 3, 4, 2, 3)]
        [TestCase(1, 2, -3, 4, -2, 3)]
        [TestCase(-1, -2, -3, -4, 2, 3)]
        [TestCase(-1, 2, -3, 4, 2, 3)]
        [TestCase(1, 2, 1, 2, 1, 1)]
        [TestCase(0, 4, 1, 4, 0, 1)]
        public void Test_Division(int n1, int d1, int n2, int d2, int r1, int r2)
        {
            var ch1 = new vadim(n1, d1);
            var ch2 = new vadim(n2, d2);
            var res = ch1 / ch2;
            Assert.That(res.Numerator == r1, Is.True);
            Assert.That(res.Denominator == r2, Is.True);
        }

        [Test]
        [TestCase(5, 6, 4, 7, false)]
        [TestCase(1, 8, 2, 16, true)]
        [TestCase(1, -2, -5, 10, true)]
        [TestCase(-2, -7, -4, -14, true)]
        public void Ravenstvo(int n1, int d1, int n2, int d2, bool res)
        {
            var ch1 = new vadim(n1, d1);
            var ch2 = new vadim(n2, d2);
            Assert.That((ch1 == ch2) == res, Is.True);
        }

        [Test]
        [TestCase(5, 6, 4, 7, true)]
        [TestCase(1, 8, 2, 16, false)]
        [TestCase(1, -2, -5, 10, false)]
        [TestCase(-2, -7, -4, -14, false)]
        public void Neravenstvo(int n1, int d1, int n2, int d2, bool res)
        {
            var ch1 = new vadim(n1, d1);
            var ch2 = new vadim(n2, d2);
            Assert.That((ch1 != ch2) == res, Is.True);
        }

        [Test]
        [TestCase(5, 6, 4, 7, true)]
        [TestCase(1, 8, 2, 16, false)]
        [TestCase(1, -2, -5, 10, false)]
        [TestCase(-2, -7, -4, -14, false)]
        [TestCase(17, 19, 19, 19, false)]
        public void Bolshe(int n1, int d1, int n2, int d2, bool res)
        {
            var ch1 = new vadim(n1, d1);
            var ch2 = new vadim(n2, d2);
            Assert.That((ch1 > ch2) == res, Is.True);
        }

        [Test]
        [TestCase(5, 6, 4, 7, false)]
        [TestCase(1, 8, 2, 16, false)]
        [TestCase(1, -2, -5, 10, false)]
        [TestCase(-2, -7, -4, -14, false)]
        [TestCase(17, 19, 19, 19, true)]
        public void Menshe(int n1, int d1, int n2, int d2, bool res)
        {
            var ch1 = new vadim(n1, d1);
            var ch2 = new vadim(n2, d2);
            Assert.That((ch1 < ch2) == res, Is.True);
        }
        [Test]
        [TestCase(5, 6, 4, 7, true)]
        [TestCase(1, 8, 2, 16, true)]
        [TestCase(1, -2, -5, 10, true)]
        [TestCase(-2, -7, -4, -14, true)]
        [TestCase(17, 19, 19, 19, false)]
        public void Bolshe_or_ravno(int n1, int d1, int n2, int d2, bool res)
        {
            var ch1 = new vadim(n1, d1);
            var ch2 = new vadim(n2, d2);
            Assert.That((ch1 >= ch2) == res, Is.True);
        }

        [Test]
        [TestCase(5, 6, 4, 7, false)]
        [TestCase(1, 8, 2, 16, true)]
        [TestCase(1, -2, -5, 10, true)]
        [TestCase(-2, -7, -4, -14, true)]
        [TestCase(17, 19, 19, 19, true)]
        public void Menshe_or_ravno(int n1, int d1, int n2, int d2, bool res)
        {
            var ch1 = new vadim(n1, d1);
            var ch2 = new vadim(n2, d2);
            Assert.That((ch1 <= ch2) == res, Is.True);
        }

        [Test]
        [TestCase(1, 2, 1, -2)]
        [TestCase(-1, -2, 1, -2)]
        [TestCase(-5, 10, 1, 2)]
        public void Unar_minus(int n1, int d1, int r1, int r2)
        {
            var ch1 = new vadim(n1, d1);
            var res = -ch1;
            Assert.That(res.Numerator == r1, Is.True);
            Assert.That(res.Denominator == r2, Is.True);
        }
        [Test]
        [TestCase(20, 0)]
        [TestCase(-20, 0)]
        [TestCase(0, 0)]
        [TestCase(1, -0)]
        public void Test_non_zero(int a, int b)
        {
            Assert.Throws<ArgumentException>(() => new vadim(a, b));
        }
    }
}