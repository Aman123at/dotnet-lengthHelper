using LengthHelper;

namespace LengthHelperTest
{
    public class UnitTest1
    {
        [Fact]
        public void stringLengthIsCorrect()
        {
            MyLengthFinder myLengthFinder = new MyLengthFinder();
            Assert.Equal(0, myLengthFinder.findLength(""));
            Assert.Equal(3, myLengthFinder.findLength("123"));
            Assert.Equal(12, myLengthFinder.findLength("123456789010"));
           

        }

        [Fact]

        public void checkNullString()
        {
            string expectedErrorMessage = "String is null.";
            MyLengthFinder myLengthFinder = new MyLengthFinder();

            var ex = Assert.Throws<NullReferenceException>(() => myLengthFinder.findLength(null));
            Assert.Equal(expectedErrorMessage, ex.Message);
        }

        //"", "123", "123456789010", NULL


        //[Fact]
        //public void stringLengthIsInCorrect()
        //{
        //    MyLengthFinder myLengthFinder = new MyLengthFinder();
        //    Assert.NotEqual(3, myLengthFinder.findLength("aman"));

        //}
    }
}