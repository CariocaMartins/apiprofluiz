using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class CalcularFatorial : ControllerBase
    {

        [HttpGet]
        public string Calcular(int number)
        {
            int fatorial = 1;
            string conta = "1";

            for (int i = 2; i <= number; i++)
            {
                fatorial *= i;
                conta += " * " + i;
            }

            return $"{conta} = {fatorial}";
        }

    }

}
