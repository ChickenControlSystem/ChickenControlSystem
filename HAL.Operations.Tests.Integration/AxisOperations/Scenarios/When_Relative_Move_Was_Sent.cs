﻿using HAL.Models.Device;
using HAL.Operations.Enum;
using NUnit.Framework;

namespace HAL.Operations.Tests.Integration.AxisOperations.Scenarios
{
    public class When_Relative_Move_Was_Sent : Given_Operation_Was_Called
    {
        [Test]
        public void Then_No_Exception_Is_Thrown()
        {
            Assert.DoesNotThrow(() => SUT.MoveAxisRelative(new DoorAxis(), 28536));
        }

        [Test]
        public void Then_Move_Is_Move_Result()
        {
            Assert.AreEqual(OperationResultEnum.Succeess, SUT.MoveAxisRelative(new DoorAxis(), 28536));
        }
    }
}