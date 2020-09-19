using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess;
using DataAccess.Implementations;
using DomainModels;
using Mappers;
using Services.Interfaces;
using ViewModels;

namespace Services.Implementations
{
    public class SizeService : ISizeService
    {
        private readonly IRepository<Size> _sizeRepository;

        public SizeService(IRepository<Size> sizeRepository)
        {
            _sizeRepository = sizeRepository;
        }

        public List<SizeViewModel> GetAll()
        {
            return _sizeRepository.GetAll().Select(x => x.ToViewModel()).ToList();
        }

        public SizeViewModel GetById(int id)
        {
            Size size = _sizeRepository.GetById(id);

            if (size == null)
            {
                throw new Exception($"Size with id {id} not found");
            }

            return size.ToViewModel();
        }

        public void Save(SizeViewModel sizeViewModel)
        {
            Size existingSize = _sizeRepository.GetById(sizeViewModel.Id);

            if (existingSize == null)
            {
                Size newSize = new Size
                {
                    Id = sizeViewModel.Id,
                    Name = sizeViewModel.Name,
                    Description = sizeViewModel.Description
                };

                _sizeRepository.Insert(newSize);
            }
            else
            {
                existingSize.Name = sizeViewModel.Name;
                existingSize.Description = sizeViewModel.Description;

                _sizeRepository.Update(existingSize);
            }
        }

        public void Delete(int id)
        {
            _sizeRepository.Delete(id);
        }
    }
}
