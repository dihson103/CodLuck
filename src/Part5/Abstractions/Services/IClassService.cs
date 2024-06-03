using Part5.Dtos.Class;

namespace Part5.Abstractions.Services;

public interface IClassService
{
    Task CreateNewClass(CreateClassRequest request);
    Task<List<ClassResponse>> GetAllClass();
}
