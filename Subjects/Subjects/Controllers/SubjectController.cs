using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Subjects.Controllers
{
    public class SubjectController : ApiController
    {
        // GET: api/Subject
        public IEnumerable<MainSubject> GetAll()
        {
            List<MainSubject> subjects = new List<MainSubject>();
            using (StreamReader r = new StreamReader("C:\\Users\\Groups\\Desktop\\משפטים\\Subjects\\Subjects\\subjects.json"))
            {
                string json = r.ReadToEnd();
                 subjects = JsonConvert.DeserializeObject<List<MainSubject>>(json);
            }
            return subjects;
        }

        // GET: api/Subject/5
        public IEnumerable<MainSubject> GetByValue(string value)
        {
            List<MainSubject> subjects = new List<MainSubject>();
            using (StreamReader r = new StreamReader("C:\\Users\\Groups\\Desktop\\מבחנים למקומות עבודה\\משפטים\\משפטים\\Subjects\\Subjects\\subjects.json"))
            {
                string json = r.ReadToEnd();
                subjects = JsonConvert.DeserializeObject<List<MainSubject>>(json);
            }
            return subjects.Where(s => s.name.Contains(value));
        }

        // POST: api/Subject
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Subject/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Subject/5
        public void Delete(int id)
        {
        }
    }
    public class Subject
    {
        public int id { get; set; }
        public string name { get; set; }
    }
    public class SubSubject
    {
        public int id { get; set; }
        public int mainSubjectId { get; set; }
        public string name { get; set; }
    }
    public class MainSubject
    {
        public int id { get; set; }
        public string name { get; set; }
        public int mainSubjectId { get; set; }
        //List<SubSubject> subSubject = new List<SubSubject>();
    }
}
