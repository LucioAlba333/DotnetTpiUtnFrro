
namespace Academia.Data.Interfaces
{
	public interface ICrud<T>
	{
		void New(T entity);
		bool Delete(int id);
		T? Get(int id);
		IEnumerable<T> GetAll();
		bool Update(T entity);
	}
}
