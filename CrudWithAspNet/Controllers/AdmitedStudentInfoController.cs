using CrudWithAspNet.Context;
using CrudWithAspNet.Model;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Runtime.Intrinsics.Arm;

namespace CrudWithAspNet.Controllers
{
   
    [ApiController]
    public class AdmitedStudentInfoController : ControllerBase
    {
        ApplicationDbContext _dbContext;
        public AdmitedStudentInfoController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        [HttpGet("getAdmittedStudentInfo")]
        public List<Admited_Student_Info> GelAllData()
        {
            List<Admited_Student_Info> admitedStudentInfo = new List<Admited_Student_Info>();
            SqlConnection con = new SqlConnection("Server=laptop-eoe2lieg;Database=School_Management;Trusted_Connection=True;TrustServerCertificate=True;");
            SqlCommand cmd = new SqlCommand("select * from admited_Student_Infos", con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Admited_Student_Info student = new Admited_Student_Info();
                student.Id = Convert.ToInt32(rdr["Id"]);
                student.Father_Name = rdr["Father_Name"].ToString();
                admitedStudentInfo.Add(student);
            }
            con.Close();
            return admitedStudentInfo;
        }



        [HttpPost("addStudent")]
        public Admited_Student_Info Add(Admited_Student_Info student_Info)
        {
            student_Info.CreatedDate = DateTime.Now;
            _dbContext.admited_Student_Infos.Add(student_Info);
            bool isSaved = _dbContext.SaveChanges() > 0;
            return isSaved ? student_Info : null;

        }

    }
}
