using Microsoft.AspNetCore.Mvc;
using TheCatAPI_Lib.Structure.Tools;
using TheCatAPI_Lib.TheCatAPI.SiteAPI;
using TheCatAPI_Lib.Desafio.search;

namespace TheCatAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class List_RacasController : Controller
    {
        /// <summary>
        /// Lista Racas registrada no banco de dados retorna no formato desajado pelo usuario Json ou XML
        /// </summary>
        /// <param name="Format"> Json ou XML</param>
        /// <returns></returns>
        [HttpPost(Name = "ListRacas")]
        public string ListBreeds(string Format)
        {
            string TxtRetorn = string.Empty;
            try
            {
                Cat oCat = new Cat();
                TxtRetorn = oCat.breeds(Format.ToUpper().Trim().TrimEnd());
            }
            catch (Exception)
            {
                throw;
            }
            return TxtRetorn;
        }
    }
}

