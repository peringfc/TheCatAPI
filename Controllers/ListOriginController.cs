using Microsoft.AspNetCore.Mvc;
using TheCatAPI_Lib.Desafio.search;

namespace TheCatAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ListOriginController : Controller
    {
        /// <summary>
        /// Total de Raca por Origem
        /// </summary>
        /// <param name="Format"></param>
        /// <returns></returns>
        [HttpGet(Name = "ListOrigintotal")]
        public string ListOriginTotal(string Format)
        {
            string TxtRetorn = string.Empty;
            try
            {
                Cat oCat = new Cat();
                TxtRetorn = oCat.OriginTotal(Format.ToUpper().Trim().TrimEnd());
            }
            catch (Exception)
            {
                throw;
            }
            return TxtRetorn;
        }

        /// <summary>
        ///  Pesquisa de Origen das Raca onde voce pode pesquisa pelo nome do Pais ou Codigo de Area
        /// </summary>
        /// <param name="p_origin"> Nome do Pais ou Sigla do Pais exemplo Egypt ou Sigla EG</param>
        /// <param name="Format"></param>
        /// <returns></returns>
        [HttpPost(Name = "ListOrigin")]
        public string ListOrigin(string p_origin, string Format)
        {
            string TxtRetorn = string.Empty;
            try
            {
                Cat oCat = new Cat();
                TxtRetorn = oCat.filter_origin(p_origin.ToUpper().Trim().TrimEnd(), Format.ToUpper().Trim().TrimEnd());
            }
            catch (Exception)
            {
                throw;
            }
            return TxtRetorn;
        }



      
    }
}