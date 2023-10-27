using DAL.DatabaseContext;
using Microsoft.AspNetCore.Mvc;
[Route("api/[controller]")]
[ApiController]
public class EmployeesController : ControllerBase
{
    private readonly AppDbContext _context;

    public EmployeesController(AppDbContext context)
    {
        _context = context;
    }

    // Реализация методов для управления сотрудниками
}