﻿using Bootstrapping.Services.Contract.HAL.Dto;
using NSubstitute;
using NUnit.Framework;
using Tests.Unit.HAL.ControlLine.ControlLineSockets.SendOperationTests.Scenarios.Shared.Socket;

namespace Tests.Unit.HAL.ControlLine.ControlLineSockets.SendOperationTests.Scenarios
{
    public class When_Response_Retrieved_Successfully : When_Socket_Communication_Was_Successful
    {
        private OperationResponseDto _operationResponse;
        private OperationResponseDto _result;

        protected override void When()
        {
            Payload = new byte[] {115, 121, 2, 255, 255};
            Operation = new OperationDto
            {
                Operation = 115,
                Device = 121,
                Params = new[] {65535}
            };
            _operationResponse = new OperationResponseDto
            {
                Status = 115,
                Returns = 65535
            };

            MockSocketClient
                .Recieve()
                .Returns(new byte[] {115, 2, 255, 255, 0, 0, 0, 0});

            _result = SUT.SendOperation(Operation);
        }

        [Test]
        public void Then_Operation_Response_Is_Returned()
        {
            Assert.AreEqual(_operationResponse.Returns, _result.Returns);
            Assert.AreEqual(_operationResponse.Status, _result.Status);
        }
    }
}