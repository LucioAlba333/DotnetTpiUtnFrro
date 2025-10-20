using Academia.Data;

namespace Academia.Services;

public class ComisionService
{
    private readonly ComisionRepository _comisionRepository;

    public ComisionService(ComisionRepository comisionRepository)
    {
        _comisionRepository = comisionRepository;
    }

}

