using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using contatos.Models;

namespace contatos.Controllers;

public class ContactController : Controller
{
   public IActionResult Index()
    {
        return View();
    }

    public IActionResult Create()
    {
        return View();
    }
    public IActionResult Edit()
    {
        return View();
    }
    public IActionResult DeleteConfirm()
    {
        return View();
    }
}
