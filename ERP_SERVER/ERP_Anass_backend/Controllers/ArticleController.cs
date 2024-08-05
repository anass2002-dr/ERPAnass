using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;
using ERP_Anass_backend.Services.ArticleService;
using Microsoft.AspNetCore.Mvc;

namespace ERP_Anass_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly IArticleService _articleService;

        public ArticleController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        [HttpGet("GetArticles")]
        public ActionResult<IEnumerable<dynamic>> GetArticles()
        {
            return Ok(_articleService.GetArticlesDetails());
        }

        [HttpGet("GetArticleById/{id}")]
        public ActionResult<Article> GetArticleById(int id)
        {
            var article = _articleService.GetArticleById(id);
            if (article == null)
            {
                return NotFound();
            }
            return Ok(article);
        }

        [HttpPost("AddArticle")]
        public ActionResult<Article> AddArticle(ArticleDtos article)
        {
            //article.Familly = new Familly();
            //_articleService.AddArticle(article);
            return Ok(_articleService.AddArticle(article));
        }

        [HttpPut("UpdateArticle/{id}")]
        public ActionResult<Article> UpdateArticlePartial(int id,Article article)
        {
            try
            {
                var updatedArticle = _articleService.UpdateArticle(id, article);
                return Ok(updatedArticle);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpDelete("DeleteArticle/{id}")]
        public IActionResult DeleteArticle(int id)
        {
            var result = _articleService.DeleteArticle(id);
            if (!result)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
