using Code_First_Repository_Pattern.Models;
using Code_First_Repository_Pattern.Repository;
using System.Net;
using System.Web.Http;

namespace Code_First_Repository_Pattern.Controllers.Api
{
    public class CategoriesController : ApiController
    {
        CategoryRepository catrepo = new CategoryRepository();
        public IHttpActionResult Get()
        {
            return Ok(catrepo.GetAll());
        }
        public IHttpActionResult Get(int id)
        {
            var category = catrepo.Get(id);

            if (category == null)
            {
                return StatusCode(HttpStatusCode.NoContent);
            }
            return Ok(category);
        }

        public IHttpActionResult Post(Category category)
        {
            catrepo.Insert(category);
            return Created("/api/Categories" + category.CategoryId, category);
        }

        public IHttpActionResult Put([FromUri]int id,[FromBody]Category category)
        {
            category.CategoryId = id;
            catrepo.Update(category);
            return Ok(category);
        }

        public IHttpActionResult Delete(int id)
        {
           
            catrepo.Delete(id);
            return StatusCode(HttpStatusCode.NoContent);
        }



    }
}
