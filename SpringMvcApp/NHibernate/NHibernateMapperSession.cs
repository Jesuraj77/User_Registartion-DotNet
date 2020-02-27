﻿using NHibernate;
using SpringMvcApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpringMvcApp.DataLayer.NHibernate
{
    public class NHibernateMapperSession : IMapperSession
    {
        private readonly ISession _session;
        private ITransaction _transaction;

        public NHibernateMapperSession(ISession session)
        {
            _session = session;
        }

        public IQueryable<User> products => _session.Query<User>();

        IQueryable<User> IMapperSession.user => throw new NotImplementedException();

        public void BeginTransaction()
        {
            _transaction = _session.BeginTransaction();
        }

        public async System.Threading.Tasks.Task Commit()
        {
            await _transaction.CommitAsync();
        }

        public async System.Threading.Tasks.Task Rollback()
        {
            await _transaction.RollbackAsync();
        }

        public void CloseTransaction()
        {
            if (_transaction != null)
            {
                _transaction.Dispose();
                _transaction = null;
            }
        }

        public async System.Threading.Tasks.Task Save(List<User> entity)
        {
            await _session.SaveOrUpdateAsync(entity);
        }

        public async System.Threading.Tasks.Task Delete(User entity)
        {
            await _session.DeleteAsync(entity);
        }
    }
}
