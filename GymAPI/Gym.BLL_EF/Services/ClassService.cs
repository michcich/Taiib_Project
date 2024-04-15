using AutoMapper;
using Gym.BLL.Dto;
using Gym.BLL.IRepositories;
using Gym.BLL.IServices;
using Gym.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.BLL_EF.Services
{
    public class ClassService : IClassService
    { 
        private readonly IClassRepository _classRepository;
        private readonly IMapper _mapper;

        public ClassService(IClassRepository classRepository, IMapper mapper)
        {
            _classRepository = classRepository;
            _mapper = mapper;
        }

        public async Task AddClass(ClassDto classDto)
        {
            var cls = _mapper.Map<Class>(classDto);
            await _classRepository.CreateAsync(cls);
        }

        public async void DeleteClass(int id)
        {
            var cl = await _classRepository.GetByIdAsync(id);
            if (cl != null)
            {
                _classRepository.Delete(cl);
            }
        }

        public async void UpdateClass(ClassDto classDto)
        {
            var cl = await _classRepository.GetByIdAsync(classDto.Id);
            if (cl != null)
            {
                _mapper.Map(classDto, cl);
                _classRepository.Update(cl);
            }
        }

        async Task<List<ClassDto>> IClassService.GetClasses(int ClubId)
        {
            var list = await _classRepository.GetClassesByGymId(ClubId);
            return _mapper.Map<List<ClassDto>>(list);
        }
    }
}
