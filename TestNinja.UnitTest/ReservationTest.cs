using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTest
{
    class ReservationTest
    {
        Reservation _reservation;
        User _testAdmin;
        User _testUser;
        [SetUp]
        public void SetUp()
        {
            _reservation = new Reservation();
            _testAdmin = new User();
            _testAdmin.IsAdmin = true;
            _testUser = new User();
        }

        [Test]
        public void CanBeCancelledByUser_WhenCalled_ResultEqualsTrue()
        {
            //ARRANGE
            _testUser.IsAdmin = false;
            _reservation.MadeBy = _testUser;

            //ACT
            bool result = _reservation.CanBeCancelledBy(_testUser);

            //ASSERT

            Assert.IsTrue(result);
        }
        [Test]
        public void CanBeCancelledByAdmin_WhenCalled_ResultEqualsTrue()
        {
            //ARRANGE
            _testUser.IsAdmin = true;
            _reservation.MadeBy = _testUser;

            //ACT
            bool result = _reservation.CanBeCancelledBy(_testUser);

            //ASSERT

            Assert.IsTrue(result);
        }
        [Test]
        public void CanBeCancelledBy_WhenCalledByAdminOrCreator_ResultEqualsFalse()
        {
            //ACT
            bool result = _reservation.CanBeCancelledBy(_testUser);

            //ASSERT

            Assert.IsFalse(result);
        }
        
    }
}
