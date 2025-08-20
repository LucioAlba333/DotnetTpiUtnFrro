
namespace Academia.Services.Interfaces
{
	public interface ICrud<T>
	{
		void New(T plan);
		bool Delete(int id);
		T? Get(int id);
		IEnumerable<T> GetAll();
		bool Update(T plan);
	}
}
