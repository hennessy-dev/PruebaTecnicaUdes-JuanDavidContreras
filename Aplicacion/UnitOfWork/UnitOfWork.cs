using System.Runtime.CompilerServices;
using Aplicacion.Repository;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.UnitOfWork;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly DbAppContext _context;
    public UnitOfWork(DbAppContext context)
    {
        _context = context;
    }
    UsuarioRepository _usuario;
    RolRepository _rol;

    public IUsuario Usuarios
    {
        get
        {
            if (_usuario is not null)
            {
                return _usuario;
            }
            return _usuario = new UsuarioRepository(_context);
        }
    }
    public IRol Roles
    {
        get
        {
            if (_rol is not null)
            {
                return _rol;
            }
            return _rol = new RolRepository(_context);
        }
    }

    public void Dispose()
    {
        _context.Dispose();
    }
    public async Task<int> SaveAsync()
    {
        return await _context.SaveChangesAsync();
    }
}
