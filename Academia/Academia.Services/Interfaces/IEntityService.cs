
namespace Academia.Services.Interfaces
{
	public interface IEntityService<T>
	{
		Task New(T dto);
		Task<bool> Delete(int id);
		Task<T?> Get(int id);
		Task<IEnumerable<T>> GetAll();
		Task<bool> Update(T dto);
	}
}
