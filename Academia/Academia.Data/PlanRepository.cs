using Academia.Models;
using Microsoft.EntityFrameworkCore;

namespace Academia.Data;

public class PlanRepository
{
	private readonly Context _context;

	public PlanRepository(Context context)
	{
		_context = context;
	}

	public async Task Add(Plan plan)
	{
		_context.Planes.Add(plan);
		await _context.SaveChangesAsync();
	}

	public async Task<bool> Delete(int id)
	{
		var entity = await _context.Planes.FindAsync(id);
		if (entity == null)
			return false;
		_context.Planes.Remove(entity);
		await _context.SaveChangesAsync();
		return true;
	}

	public async Task<Plan?> Get(int id)
	{
		return await _context.Planes
			.Include(p => p.Especialidad)
			.FirstOrDefaultAsync(p => p.Id == id);
	}

	public async Task<IEnumerable<Plan>> GetAll()
	{
		return await _context.Planes
			.Include(p=> p.Especialidad)
			.OrderBy(p => p.Id).ToListAsync();
	}
	public async Task<bool> Update(Plan entity)
	{
		var plan = await _context.Planes.FindAsync(entity.Id);
		if (plan == null)
			return false;
		_context.Entry(plan).CurrentValues.SetValues(entity);
		await _context.SaveChangesAsync();
		return true;
	}
	public async Task<bool> PlanExists(string descripcion, int? excludeId = null)
	{
		var query = _context.Planes
			.Where(p => p.Descripcion.ToLower() == descripcion.ToLower());
		if (excludeId.HasValue)
		{
			query = query.Where(c => c.Id != excludeId.Value);
		}
		return await query.AnyAsync();
	}
}
