using Academia.Models;
using Microsoft.EntityFrameworkCore;

namespace Academia.Data;

public class UsuarioRepository
{
    private readonly Context _context;

    public UsuarioRepository(Context context)
    {
        _context = context;
    }

    public async Task Add(Usuario usuario)
    {
        await _context.Usuarios.AddAsync(usuario);
        await _context.SaveChangesAsync();
    }

    public async Task<bool> Delete(int id)
    {
        var usuario = await _context.Usuarios.FindAsync(id);
        if (usuario == null)
            return false;
        _context.Usuarios.Remove(usuario);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<Usuario?> Get(int id)
    {
        return await _context.Usuarios.Include(e => e.Persona).FirstOrDefaultAsync(e => e.Id == id);
    }

    public async Task<Usuario?> GetByUsername(string username)
    {
        return await _context.Usuarios
            .Include(e => e.Permisos)
            .ThenInclude(p => p.Modulo)
            .Include(e => e.Persona).FirstOrDefaultAsync(e => e.NombreUsuario == username);
    }

    public async Task<IEnumerable<Usuario>> GetAll()
    {
        return await _context.Usuarios
            .Include(e => e.Persona)
            .OrderByDescending(e => e.Id)
            .ToListAsync();
    }

    public async Task<bool> Update(Usuario usuario)
    {
        var usuarioToUpdate = await _context.Usuarios.FindAsync(usuario.Id); 
        if (usuarioToUpdate == null)
            return false;
        _context.Entry(usuarioToUpdate).CurrentValues.SetValues(usuario);
        await _context.SaveChangesAsync();
        return true;
    }
    
}