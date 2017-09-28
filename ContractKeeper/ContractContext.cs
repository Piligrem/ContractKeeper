using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;

namespace ContractKeeper
{
    public class ContractContext : DbContext, IDbContext
    {
        protected ContractContext()
			: this(GetConnectionString())
		{
        }

        public static string GetConnectionString()
        {
            if (DataSettings.Current.IsValid())
            {
                return DataSettings.Current.DataConnectionString;
            }

            throw new Exception("A connection string could not be resolved for the parameterless constructor of the derived DbContext. Either the database is not installed, or the file 'Settings.txt' does not exist or contains invalid content.");
        }

        public string Alias { get; internal set; }

        public bool AutoCommitEnabled { get; set; }

        public bool AutoDetectChangesEnabled
        {
            get
            {
                return this.Configuration.AutoDetectChangesEnabled;
            }

            set
            {
                this.Configuration.AutoDetectChangesEnabled = value;
            }
        }

        public bool ForceNoTracking { get; set; }

        public bool HasChanges
        {
            get
            {
                return this.ChangeTracker.Entries()
                           .Where(x => x.State > System.Data.Entity.EntityState.Unchanged)
                           .Any();
            }
        }

        public bool HooksEnabled { get; set; }

        public bool LazyLoadingEnabled
        {
            get
            {
                return this.Configuration.LazyLoadingEnabled;
            }

            set
            {
                this.Configuration.LazyLoadingEnabled = value;
            }
        }

        public bool ProxyCreationEnabled
        {
            get
            {
                return this.Configuration.ProxyCreationEnabled;
            }
            set
            {
                this.Configuration.ProxyCreationEnabled = value;
            }
        }

        public bool ValidateOnSaveEnabled
        {
            get
            {
                return this.Configuration.ValidateOnSaveEnabled;
            }
            set
            {
                this.Configuration.ValidateOnSaveEnabled = value;
            }
        }

        public TEntity Attach<TEntity>(TEntity entity) where TEntity : BaseEntity
        {
            var dbSet = Set<TEntity>();
            var alreadyAttached = dbSet.Local.FirstOrDefault(x => x.Id == entity.Id);

            if (alreadyAttached == null)
            {
                dbSet.Attach(entity);
                return entity;
            }

            return alreadyAttached;
        }

        public ITransaction BeginTransaction(IsolationLevel isolationLevel = IsolationLevel.Unspecified)
        {
            var dbContextTransaction = this.Database.BeginTransaction(isolationLevel);
            return new DbContextTransactionWrapper(dbContextTransaction);
        }

        public void ChangeState<TEntity>(TEntity entity, EntityState newState) where TEntity : BaseEntity
        {
            this.Entry(entity).State = newState;
        }

        public int DetachEntities(Func<object, bool> predicate, bool unchangedEntitiesOnly = true)
        {
            Guard.NotNull(predicate, nameof(predicate));

            Func<DbEntityEntry, bool> predicate2 = x =>
            {
                if (x.State > System.Data.Entity.EntityState.Detached && predicate(x.Entity))
                {
                    return unchangedEntitiesOnly
                        ? x.State == System.Data.Entity.EntityState.Unchanged
                        : true;
                }

                return false;
            };

            var attachedEntities = this.ChangeTracker.Entries().Where(predicate2).ToList();
            attachedEntities.Each(entry => entry.State = System.Data.Entity.EntityState.Detached);
            return attachedEntities.Count;
        }

        public int DetachEntities<TEntity>(bool unchangedEntitiesOnly = true) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public void DetachEntity<TEntity>(TEntity entity) where TEntity : BaseEntity
        {
            throw new NotImplementedException();
        }

        public int ExecuteSqlCommand(string sql, bool doNotEnsureTransaction = false, int? timeout = default(int?), params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public int ExecuteSqlThroughSmo(string sql)
        {
            throw new NotImplementedException();
        }

        public IList<TEntity> ExecuteStoredProcedureList<TEntity>(string commandText, params object[] parameters) where TEntity : BaseEntity, new()
        {
            throw new NotImplementedException();
        }

        public IDictionary<string, object> GetModifiedProperties(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public bool IsAttached<TEntity>(TEntity entity) where TEntity : BaseEntity
        {
            throw new NotImplementedException();
        }

        public void ReloadEntity<TEntity>(TEntity entity) where TEntity : BaseEntity
        {
            throw new NotImplementedException();
        }

        public new DbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity
        {
            return base.Set<TEntity>();
        }

        public IEnumerable<TElement> SqlQuery<TElement>(string sql, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public void UseTransaction(DbTransaction transaction)
        {
            throw new NotImplementedException();
        }
        #region Nested classes

        private class DbContextTransactionWrapper : ITransaction
        {
            private readonly DbContextTransaction _tx;

            public DbContextTransactionWrapper(DbContextTransaction tx)
            {
                if (tx == null)
                    throw new ArgumentNullException(nameof(tx));
                _tx = tx;
            }

            public void Commit()
            {
                _tx.Commit();
            }

            public void Rollback()
            {
                _tx.Rollback();
            }

            public void Dispose()
            {
                _tx.Dispose();
            }
        }

        #endregion
    }

}
