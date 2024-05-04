using Microsoft.AspNetCore.Mvc;

namespace modul10_1302220362.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : Controller
    {
        private static List<Mahasiswa> mahasiswaList = new List<Mahasiswa>
        {
            new Mahasiswa("Francisca Isabella Manope", "1302223062",["KPL","PBO"],2024),
            new Mahasiswa("Muhammad Faqih Ainulyaqin", "1302220086",["KPL","PBO"],2024),
            new Mahasiswa("Helmy Farikh Alfarizhi", "1302220077",["KPL","PBO"],2024),
            new Mahasiswa("Irham Baehaqi", "1302220077",["KPL","PBO"],2024),
            new Mahasiswa("Ayu lestari", "1302223008",["KPL","PBO"],2024),
            new Mahasiswa("Naufal Ammar Zaidan", "1302220052",["KPL","PBO"],2024)

        };

        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return mahasiswaList;
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return mahasiswaList[id];
        }

        [HttpPost]
        public void Post([FromBody] Mahasiswa mahasiswa)
        {
            mahasiswaList.Add(mahasiswa);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            mahasiswaList.RemoveAt(id);
        }
    }
}
