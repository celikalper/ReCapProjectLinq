﻿using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ColorManager:IColorService
    {
        private IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }


        public Color GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(Color color)
        {
           _colorDal.Add(color);
        }

        public void Update(Color color)
        {
            _colorDal.Update(color);
        }

        public void Delete(Color color)
        {
            _colorDal.Delete(color);
        }

        public List<Color> GetAll()
        {
           return _colorDal.GetAll();
        }

        
    }
}
