using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;

public class HomeController : Controller
{

  [HttpGet("/")]
  public ActionResult Index()
  {
      return View();
  }

}
