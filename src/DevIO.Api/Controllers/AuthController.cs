using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevIO.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DevIO.Api.Controllers
{
    public class AuthController : MainController
    {
        public AuthController(INotificador notificador) : base(notificador)
        { }
    }
}