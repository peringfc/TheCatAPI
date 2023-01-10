using Microsoft.AspNetCore.Mvc;
using TheCatAPI_Lib.Desafio.search;

namespace TheCatAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class List_Raca_TemperamentController : Controller
    {
        /// <summary>
        /// Lista Racas registrada no banco de dados retorna no formato desajado pelo usuario Json ou XML
        /// </summary>
        /// <param name="Format"> Json ou XML</param>
        /// <returns></returns>
        [HttpGet(Name = "ListRacasTemperamentTotal")]
        public string ListBreedsTemperamentTotal(string Format)
        {
            string TxtRetorn = string.Empty;
            try
            {
                Cat oCat = new Cat();
                TxtRetorn = oCat.temperament_total(Format.ToUpper().Trim().TrimEnd());
            }
            catch (Exception)
            {
                throw;
            }
            return TxtRetorn;
        }

        [HttpPost(Name = "ListRacasTemperament")]
        public string ListBreedsTemperament(string p_temperament, string Format)
        {
            string TxtRetorn = string.Empty;
            try
            {
                Cat oCat = new Cat();
                TxtRetorn = oCat.filter_temperament(p_temperament.ToUpper().Trim().TrimEnd(),Format.ToUpper().Trim().TrimEnd());
            }
            catch (Exception)
            {
                throw;
            }
            return TxtRetorn;
        }
    }
}