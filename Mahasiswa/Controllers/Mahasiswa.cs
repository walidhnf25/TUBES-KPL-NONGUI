using Microsoft.AspNetCore.Mvc;

namespace Mahasiswa.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MahasiswaController : ControllerBase
    {

        static public List<Mahasiswa> listMhs = new List<Mahasiswa> {
            new Mahasiswa("M. Yaasin Rafi", "1302210055", "Hadir", new List<String>(){ "PBO", "BASDAT", "KPL"}, 2022),
            new Mahasiswa("Walid Hanif Ataullah", "1302213120", "Hadir", new List<String>(){ "PBO", "BASDAT", "KPL"}, 2022),
            new Mahasiswa("Muhammad Raffa Zuhayr", "1302210068", "Hadir", new List<String>(){ "PBO", "BASDAT", "KPL"}, 2022),
            new Mahasiswa("Sylvana Rheina Khrameliawaty", "1302210017", "Hadir", new List<String>(){ "PBO", "BASDAT", "KPL"}, 2022),
            new Mahasiswa("Nabiel P", "1302210049", "Hadir", new List<String>(){ "PBO", "BASDAT", "KPL"}, 2022)
        };


        // GET: api/<MahasiswaController>
        [HttpGet(Name = "GetMahasiswa")]
        public IEnumerable<Mahasiswa> Get()
        {
            return listMhs;
        }

        // GET api/<MahasiswaController>/5
        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return listMhs[id];
        }

        // POST api/<MahasiswaController>
        [HttpPost(Name = "PostMahasiswa")]
        public IActionResult Post(Mahasiswa value)
        {
            listMhs.Add(value);
            return Ok(listMhs);
        }


        // DELETE api/<MahasiswaController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            listMhs.RemoveAt(id);
            return Ok(listMhs);
        }
    }
}