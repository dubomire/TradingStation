﻿using AuthenticationService.Interfaces;
using Kernel;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationService.Commands
{
    public class LogoutCommand : ICommand<int>
    {
        private readonly ITokensEngine tokensEngine;

        public LogoutCommand([FromServices] ITokensEngine tokensEngine)
        {
            this.tokensEngine = tokensEngine;
        }

        public void Execute(int data)
        {
            CommonValidations.ValidateId(data);

            tokensEngine.DeleteToken(data);
        }
    }
}
