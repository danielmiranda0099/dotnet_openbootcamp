using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using API.DataAccess;
using API.Models.DataModels;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase {
    private readonly UniversityDBContext _context;

    public UsersController(UniversityDBContext context) {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<User>>> GetUsers() {
        return await _context.Users.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<User>> GetUser(int Id) {
        var user = await _context.Users.FindAsync(Id);

        if(user == null){
            return NotFound();
        }

        return user;
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutUser(int Id, User user) {
        if( Id != user.Id ){
            return BadRequest();
        }

        _context.Entry( user ).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if(!UserExists(Id)){
                return NotFound();
            }else{
                throw;
            }
        }

        return NoContent();
    }

    [HttpPost]
    public async Task<ActionResult<User>> PostUser(User user){
        _context.Users.Add(user);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetUser", new { Id = user.Id}, user);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteUser(int Id){
        var user = await _context.Users.FindAsync(Id);

        if( user == null ){
            return NotFound();
        }

        _context.Users.Remove(user);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool UserExists(int Id){
        return _context.Users.Any( user => user.Id == Id);
    }
}