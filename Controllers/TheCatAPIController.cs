using Microsoft.AspNetCore.Mvc;
using TheCatAPI_Lib.Structure.SiteTheCatAPI;
using TheCatAPI_Lib.Structure.Tools;
using TheCatAPI_Lib.TheCatAPI.SiteAPI; 

namespace TheCatAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TheCatAPIController : Controller
    {
        /// <summary>
        /// Metodo estara realizando um pesquisa na fonte de dados e retornado um objeto 
        /// normatizado e serelizado
        /// </summary>
        /// <returns> Objeto na estrutura de POC Stru_Breed de nossa biblioteca normatizada</returns>
        [HttpPost(Name = "Load_Data_TheCatAPI_SIT")]
        public List<Stru_Log> LoadTheCatAPI()
        {
            List<Stru_Log> ListStruLog = new List<Stru_Log>();
            try
            {
                
                Synchronism oSynchronism = new Synchronism();
                ListStruLog = oSynchronism.LoadTheCatAPI();
            }
            catch (Exception)
            {

                throw;
            }
            return ListStruLog; 
        }
    }
}
