namespace Academia.Models;

public abstract class BusinessEntity
{
	public BusinessEntity() { }
	public BusinessEntity(int id)
	{
	
		Id = id;
		//State = States.Activo;
	}
	public BusinessEntity(BusinessEntity entity)
	{
		this.Id = entity.Id;
		//this.State = entity.State;
	}

	public int Id { get; set; }
	//public States State { get; set; }
}
