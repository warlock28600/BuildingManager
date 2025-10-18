using BuldingManager.Services.Compound;
using Microsoft.AspNetCore.Mvc;

namespace BuldingManager.Controllers
{
    [Controller]
    [Route("/api/v1/[controller]")]
    public class CompoundController:ControllerBase
    {
        private readonly ILogger<CompoundController> _logger;
        private readonly ICompoundService _compoundService;
        public CompoundController(ILogger<CompoundController> logger,ICompoundService compoundService)
        {
            _logger = logger;
            _compoundService = compoundService;
        }


    
    }
}
