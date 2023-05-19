using laTercera.Models;
using laTercera.Repositories.IRepositories;
using Microsoft.AspNetCore.Mvc;

namespace laTercera.Controllers;

[ApiController]
[Route("[controller]")]
public class FieldController : ControllerBase
{
    private readonly IFieldRepository fieldRepository;

    public FieldController(IFieldRepository fieldRepository)
    {
        this.fieldRepository = fieldRepository;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<Field>))]
    public async Task<ActionResult> GetFields()
    {
        List<Field> fields = await fieldRepository.GetAll();
        return new OkObjectResult(fields);
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult> GetField(int id)
    {
        Field field = await fieldRepository.Get(it => it.Id == id);
        return Ok(field);
    }
}