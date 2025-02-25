using Lab8.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.Test
{
    [TestFixture]
    public class ArrayUtilsTests
    {
        [Test]
        public void FindMax_ValidArray_ReturnsMaxValue()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int result = ArrayUtils.FindMax(numbers);
            Assert.That(result, Is.EqualTo(5)); // Kiểm tra giá trị max là 5
        }

        [Test]
        public void FindMin_ValidArray_ReturnsMinValue()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int result = ArrayUtils.FindMin(numbers);
            Assert.That(result, Is.EqualTo(1)); // Kiểm tra giá trị min là 1
        }

        [Test]
        public void FindMax_EmptyArray_ThrowsException()
        {
            int[] numbers = { };
            Assert.Throws<ArgumentException>(() => ArrayUtils.FindMax(numbers)); // Kiểm tra ngoại lệ với mảng trống
        }

        [Test]
        public void FindMin_EmptyArray_ThrowsException()
        {
            int[] numbers = { };
            Assert.Throws<ArgumentException>(() => ArrayUtils.FindMin(numbers)); // Kiểm tra ngoại lệ với mảng trống
        }
    }
}
