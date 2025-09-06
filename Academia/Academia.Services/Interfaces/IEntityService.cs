
namespace Academia.Services.Interfaces
{
	public interface IEntityService<T>
	{
		void New(T dto);
		bool Delete(int id);
		T? Get(int id);
		IEnumerable<T> GetAll();
		bool Update(T dto);
	}
}
