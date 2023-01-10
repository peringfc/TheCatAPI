using Microsoft.AspNetCore.Mvc;
using TheCatAPI_Lib.Desafio.search;

namespace TheCatAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BreedController : Controller
    {
        /// <summary>
        /// Lista Racas registrada no banco de dados retorna no formato desajado pelo usuario Json ou XML
        /// </summary>
        /// <param name="Format"> Json ou XML</param>
        /// <returns></returns>
        [HttpPost(Name = "ListBreeds")]
        public string ListBreeds(string p_breed, string Format)
        {
            string TxtRetorn = string.Empty;
            try
            {
                Cat oCat = new Cat();
                TxtRetorn = oCat.info_breed(p_breed, Format.ToUpper().Trim().TrimEnd());
            }
            catch (Exception)
            {
                throw;
            }
            return TxtRetorn;
        }
    }
}
