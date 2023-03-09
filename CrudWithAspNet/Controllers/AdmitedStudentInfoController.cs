using CrudWithAspNet.Context;
using CrudWithAspNet.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrudWithAspNet.Controllers
{
    [Route("action")]
    [ApiController]
    public class AdmitedStudentInfoController : ControllerBase
    {
        ApplicationDbContext _dbContext;
        public AdmitedStudentInfoController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        [HttpGet]
        public List<Admited_Student_Info> GelAllData()
        {
            var admitedStudentInfo = _dbContext.admited_Student_Infos.ToList();
            return admitedStudentInfo;
        }
    }
}
