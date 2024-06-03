using AutoMapper;
using Part5.Abstractions.Repositories;
using Part5.Abstractions.Services;
using Part5.Dtos.Class;
using Part5.Entities;

namespace Part5.Services;

public sealed class ClassService(IClassRepository _classRepository, IUnitOfWork _unitOfWork, IMapper _mapper)
    : IClassService
{
    public async Task CreateNewClass(CreateClassRequest request)
    {
        var course = Class.Create(request);

        _classRepository.Add(course);
        await _unitOfWork.SaveChangesAsync();
    }

    public async Task<List<ClassResponse>> GetAllClass()
    {
        var courses = await _classRepository.GetAll();

        return courses.ConvertAll(c => _mapper.Map<ClassResponse>(c));
    }
}
