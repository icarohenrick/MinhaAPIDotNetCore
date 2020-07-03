using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevIO.Api.Controllers;
using DevIO.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DevIO.Api.V1.Controllers
{
    [ApiVersion("1.0", Deprecated = true)]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class TesteController : MainController
    {
        private readonly INotificador _notificador;
        public TesteController(INotificador notificador, IUser AppUser) : base(notificador, AppUser)
        {
            _notificador = notificador;
        }

        
        [HttpGet]
        public IActionResult Index()
        {
            return CustomResponse("Esta é uma Controller V1");
        }
    }
}