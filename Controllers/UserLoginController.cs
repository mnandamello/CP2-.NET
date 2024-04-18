using CP2_.NET.Data;
using CP2_.NET.Models;
using Microsoft.AspNetCore.Mvc;

namespace CP2_.NET.Controllers
{
    public class UserLoginController : Controller


    {
        private readonly ILogger<UserLoginController> _logger;
        private readonly DataContext _dataContext;

        public UserLoginController(ILogger<UserLoginController> logger, DataContext dataContext)
        {
            _dataContext = dataContext;
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult FLogin(User request)
        {
            var user = _dataContext.MVC_USUARIOS.FirstOrDefault(x => x.UserEmail == request.UserEmail);
            if (user == null)
            {
                return BadRequest("Usuário não encontrado");
            }

            if (user.UserPassword != request.UserPassword)
            {
                return BadRequest("Senha incorreta");
            }

            // Aqui você pode adicionar a lógica para iniciar a sessão do usuário, se desejar

            return View(); // Redireciona para a página inicial após o login
        }
    }
}
