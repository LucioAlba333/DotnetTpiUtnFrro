using Academia.Models;
using Microsoft.EntityFrameworkCore;

namespace Academia.Data;

public class ModuloUsuarioRepository
{
    private readonly Context _context;

    public ModuloUsuarioRepository(Context context)
    {
        _context = context;
    }

    public async Task Add(Usuario usuario)
    {
        var modulos = await _context.Modulos.ToListAsync();
        foreach (var modulo in modulos)
        {
            bool alta = false;
            bool baja = false;
            bool modificacion = false;
            bool consulta = false;
            switch (usuario.Persona.TipoPersona)
            {
                case TipoPersona.Administrador:
                    alta = baja = modificacion = consulta = true;
                    break;
            }
            ModuloUsuario moduloUsuario = new ModuloUsuario(
                0,
                usuario,
                modulo,
                alta,
                baja,
                modificacion,
                consulta);
            await _context.ModuloUsuarios.AddAsync(moduloUsuario);
            await _context.SaveChangesAsync();
        }
    }
}