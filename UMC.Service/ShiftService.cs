using System.Collections.Generic;
using System.Threading.Tasks;
using UMC.Data.Infrastructure;
using UMC.Data.Repositories;
using UMC.Model.Models;

namespace UMC.Service
{
    public interface IShiftService
    {
        Task<Shift> Add(Shift shift);

        //void Update(Shift shift);

        //void Delete(int id);

        Task<IEnumerable<Shift>> GetAll();

        //int GetById(int id);

        Task SaveAsync();

    }
    public class ShiftService : IShiftService
    {
        private IShiftRepository _shiftRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ShiftService(IShiftRepository shiftRepository, IUnitOfWork unitOfWork)
        {
            this._shiftRepository = shiftRepository;
            this._unitOfWork = unitOfWork;
        }

        public async Task<Shift> Add(Shift shift)
        {
            return await Task.FromResult(_shiftRepository.Add(shift));
            //return _shiftRepository.Add(shift);
        }
        public async Task<IEnumerable<Shift>> GetAll()
        {          
           return await _shiftRepository.GetAll();
        }
        public async Task SaveAsync()
        {
            await _unitOfWork.CommitAsync();
        }
    }
}
