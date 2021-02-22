﻿using BLL.Common.Sequence;
using NSubstitute;
using NUnit.Framework;

namespace BLL.Common.Tests.Integration.RunSequenceWithinSequence.RunTests
{
    public class When_All_Tasks_Complete_Successfully : Given_Two_Sequences_Are_Built
    {
        private SequenceResultEnum _result;

        public override void When()
        {
            MockLowerSequenceTask
                .Run()
                .Returns(SequenceResultEnum.Success);
            MockUpperSequenceSecondTask
                .Run()
                .Returns(SequenceResultEnum.Success);

            _result = SUT.Run();
        }

        [Test]
        public void Then_Task_In_Lower_Sequence_Ran()
        {
            MockLowerSequenceTask
                .Received(1)
                .Run();
        }

        [Test]
        public void Then_Second_Task_In_Upper_Sequence_Ran()
        {
            MockUpperSequenceSecondTask
                .Received(1)
                .Run();
        }

        [Test]
        public void Then_Sequence_Is_Successful()
        {
            Assert.AreEqual(_result, SequenceResultEnum.Success);
        }
    }
}