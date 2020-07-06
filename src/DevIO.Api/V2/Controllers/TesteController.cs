using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevIO.Api.Controllers;
using DevIO.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DevIO.Api.V2.Controllers
{
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class TesteController : MainController
    {
        private readonly ILogger _logger;
        public TesteController(ILogger logger, INotificador notificador, IUser AppUser) : base(notificador, AppUser)
        {
            _logger = logger;
        }

        
        [HttpGet]
        public IActionResult Index()
        {
            _logger.LogTrace("Log de Trace");
            _logger.LogDebug("Log de Debug");
            _logger.LogInformation("Log de Informação");
            _logger.LogWarning("Log de Aviso");
            _logger.LogError("Log de erro");
            _logger.LogCritical("Log de Problema Critico");

            return CustomResponse("Esta é uma Controller V2");
        }
    }
}