﻿using System;
using Bootstrapping.Services.Contract.HAL.Enum;
using Bootstrapping.Services.Contract.HAL.Interface;
using Crosscutting.CodeContracts;

namespace HAL.Operations
{
    public class ErrorService : IErrorService
    {
        /// <exception cref="ArgumentException"></exception>
        public OperationResultEnum Validate(byte errorCode)
        {
            //PRECONDITION
            CodeContract.PreCondition<ArgumentException>(() =>
            {
                switch (errorCode)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                        return true;
                    default:
                        return false;
                }
            });

            //TODO LOGGING BASED ON ERROR CODE

            return errorCode == 1 ? OperationResultEnum.Succeess : OperationResultEnum.Failiure;
        }
    }
}