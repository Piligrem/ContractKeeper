using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;

namespace ContractKeeper
{
    public class ContractContext : DbContext, IDbContext
    {
        public ContractContext()
			: base(GetConnectionString())
		{
        }

        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["DbConnect"].ConnectionString;        
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


        public void ChangeState<TEntity>(TEntity entity, EntityState newState) where TEntity : BaseEntity
        {
            this.Entry(entity).State = newState;
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

    }

}
