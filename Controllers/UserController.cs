using CP2_.NET.Data;
using CP2_.NET.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CP2_.NET.Controllers;

public class UserController : Controller
{

    private readonly ILogger<UserController> _logger;
    private readonly DataContext _dataContext;

    public UserController(ILogger<UserController> logger, DataContext dataContext)
    {
        _dataContext = dataContext;
        _logger = logger;
    }


    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Register(User resquest)
    {
        var user = _dataContext.MVC_USUARIOS.FirstOrDefault(x => x.UserEmail == resquest.UserEmail);
        if (user != null)
        {
            return BadRequest("Usuário ja existe");
        }
        User newUser = new User
        {
            Id = resquest.Id,
            UserEmail = resquest.UserEmail,
            UserName = resquest.UserName,
            UserPassword = resquest.UserPassword,
        };
        _dataContext.Add(newUser);
        _dataContext.SaveChanges();
        return View();
    }

    

}