using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mobiShop.Models;

namespace mobiShop.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    [HttpGet]
    public IActionResult About()
    {
        return View();
    }

    public IActionResult Contact()
    {
        return View();
    }

    [HttpPost]
public IActionResult Contact(Message model)
{
    // Проверка валидности формы
    if (ModelState.IsValid)
    {
        Console.WriteLine($"Имя: {model.Name}");
        Console.WriteLine($"Почта: {model.Email}");
        Console.WriteLine($"Телефон: {model.Phone}");
        Console.WriteLine($"Сообщение: {model.MessageText}");

        // Допустим, отправляем сообщение или сохраняем в базу данных

        // Показать сообщение пользователю
        ViewBag.Success = "Спасибо за ваше сообщение!";

        // Можем вернуть ту же страницу
        return View();
    }

    // Если невалидно, возвращаем форму с ошибками
    return View(model);
}

    public IActionResult Brand()
    {
        return View();
    }

    public IActionResult Special()
    {
        return View();
    }
    
}
