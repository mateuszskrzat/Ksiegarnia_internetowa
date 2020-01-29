using Logic.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.DataLogic
{
    public abstract class BaseLogic : IDisposable
    {
        private RepositoryBase _repository;
        public RepositoryBase Repository { get => _repository; }

        public BaseLogic()
        {
            this._repository = new RepositoryBase();
        }

        public void Dispose()
        {
            this._repository.Dispose();
        }
    }
}
