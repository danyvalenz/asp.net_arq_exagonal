using Microsoft.AspNetCore.Mvc;
using ejemplo_01.Services;


namespace ejemplo_01.Controllers
{
    [Route("api/[controller]")]
    public class DemoController : ControllerBase
    {
        readonly ServiceTransient _serviceTransient;
        readonly ServiceTransient _serviceTransient2;
        readonly ServiceScope _scope;
        readonly ServiceScope _scope2;

        readonly ServiceSingleton _serviceSingleton;
        readonly ServiceSingleton _serviceSingleton2;

        public DemoController(ServiceTransient serviceTransient, ServiceScope scope, ServiceScope scope2, ServiceTransient serviceTransient2, ServiceSingleton serviceSingleton, ServiceSingleton serviceSingleton2)
        {
            this._serviceTransient = serviceTransient;  
            this._scope = scope;    
            this._scope2 = scope2;
            this._serviceTransient2 = serviceTransient2;
            this._serviceSingleton = serviceSingleton;
            this._serviceSingleton2 = serviceSingleton2;
        }

        [HttpPost]
        public IActionResult ExecuteExample()
        {
            _serviceTransient.Print();
            _serviceTransient2.Print();
            _scope.PrintScope();
            _scope2.PrintScope();
            _serviceSingleton.PrintSingleton();
            _serviceSingleton2.PrintSingleton();
            return Ok("ejecute");
        }
    }
}
