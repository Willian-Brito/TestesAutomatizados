using System.Data;
using System.Data.Common;
using System.Linq.Expressions;
using NHibernate;
using NHibernate.Engine;
using NHibernate.Stat;
using NHibernate.Type;

namespace TestesAutomatizados;

public class CriadorDeSessoes : ISession
{
    public FlushMode FlushMode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public CacheMode CacheMode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public ISessionFactory SessionFactory => throw new NotImplementedException();

    public DbConnection Connection => throw new NotImplementedException();

    public bool IsOpen => throw new NotImplementedException();

    public bool IsConnected => throw new NotImplementedException();

    public bool DefaultReadOnly { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public ITransaction Transaction => throw new NotImplementedException();

    public ISessionStatistics Statistics => throw new NotImplementedException();

    public ISession BancoDeTestes()
    {
        return this;
    }

    public ITransaction BeginTransaction()
    {
        throw new NotImplementedException();
    }

    public ITransaction BeginTransaction(IsolationLevel isolationLevel)
    {
        throw new NotImplementedException();
    }

    public void CancelQuery()
    {
        throw new NotImplementedException();
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public DbConnection Close()
    {
        throw new NotImplementedException();
    }

    public bool Contains(object obj)
    {
        throw new NotImplementedException();
    }

    public ICriteria CreateCriteria<T>() where T : class
    {
        throw new NotImplementedException();
    }

    public ICriteria CreateCriteria<T>(string alias) where T : class
    {
        throw new NotImplementedException();
    }

    public ICriteria CreateCriteria(Type persistentClass)
    {
        throw new NotImplementedException();
    }

    public ICriteria CreateCriteria(Type persistentClass, string alias)
    {
        throw new NotImplementedException();
    }

    public ICriteria CreateCriteria(string entityName)
    {
        throw new NotImplementedException();
    }

    public ICriteria CreateCriteria(string entityName, string alias)
    {
        throw new NotImplementedException();
    }

    public IQuery CreateFilter(object collection, string queryString)
    {
        throw new NotImplementedException();
    }

    public Task<IQuery> CreateFilterAsync(object collection, string queryString, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public IMultiCriteria CreateMultiCriteria()
    {
        throw new NotImplementedException();
    }

    public IMultiQuery CreateMultiQuery()
    {
        throw new NotImplementedException();
    }

    public IQuery CreateQuery(string queryString)
    {
        throw new NotImplementedException();
    }

    public ISQLQuery CreateSQLQuery(string queryString)
    {
        throw new NotImplementedException();
    }

    public void Delete(object obj)
    {
        throw new NotImplementedException();
    }

    public void Delete(string entityName, object obj)
    {
        throw new NotImplementedException();
    }

    public int Delete(string query)
    {
        throw new NotImplementedException();
    }

    public int Delete(string query, object value, IType type)
    {
        throw new NotImplementedException();
    }

    public int Delete(string query, object[] values, IType[] types)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(object obj, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(string entityName, object obj, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<int> DeleteAsync(string query, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<int> DeleteAsync(string query, object value, IType type, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<int> DeleteAsync(string query, object[] values, IType[] types, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public void DisableFilter(string filterName)
    {
        throw new NotImplementedException();
    }

    public DbConnection Disconnect()
    {
        throw new NotImplementedException();
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public IFilter EnableFilter(string filterName)
    {
        throw new NotImplementedException();
    }

    public void Evict(object obj)
    {
        throw new NotImplementedException();
    }

    public Task EvictAsync(object obj, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public void Flush()
    {
        throw new NotImplementedException();
    }

    public Task FlushAsync(CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public object Get(Type clazz, object id)
    {
        throw new NotImplementedException();
    }

    public object Get(Type clazz, object id, LockMode lockMode)
    {
        throw new NotImplementedException();
    }

    public object Get(string entityName, object id)
    {
        throw new NotImplementedException();
    }

    public T Get<T>(object id)
    {
        throw new NotImplementedException();
    }

    public T Get<T>(object id, LockMode lockMode)
    {
        throw new NotImplementedException();
    }

    public Task<object> GetAsync(Type clazz, object id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<object> GetAsync(Type clazz, object id, LockMode lockMode, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<object> GetAsync(string entityName, object id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<T> GetAsync<T>(object id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<T> GetAsync<T>(object id, LockMode lockMode, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public LockMode GetCurrentLockMode(object obj)
    {
        throw new NotImplementedException();
    }

    public IFilter GetEnabledFilter(string filterName)
    {
        throw new NotImplementedException();
    }

    public string GetEntityName(object obj)
    {
        throw new NotImplementedException();
    }

    public Task<string> GetEntityNameAsync(object obj, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public object GetIdentifier(object obj)
    {
        throw new NotImplementedException();
    }

    public IQuery GetNamedQuery(string queryName)
    {
        throw new NotImplementedException();
    }

    public ISession GetSession(EntityMode entityMode)
    {
        throw new NotImplementedException();
    }

    public ISessionImplementor GetSessionImplementation()
    {
        throw new NotImplementedException();
    }

    public bool IsDirty()
    {
        throw new NotImplementedException();
    }

    public Task<bool> IsDirtyAsync(CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public bool IsReadOnly(object entityOrProxy)
    {
        throw new NotImplementedException();
    }

    public void JoinTransaction()
    {
        throw new NotImplementedException();
    }

    public object Load(Type theType, object id, LockMode lockMode)
    {
        throw new NotImplementedException();
    }

    public object Load(string entityName, object id, LockMode lockMode)
    {
        throw new NotImplementedException();
    }

    public object Load(Type theType, object id)
    {
        throw new NotImplementedException();
    }

    public T Load<T>(object id, LockMode lockMode)
    {
        throw new NotImplementedException();
    }

    public T Load<T>(object id)
    {
        throw new NotImplementedException();
    }

    public object Load(string entityName, object id)
    {
        throw new NotImplementedException();
    }

    public void Load(object obj, object id)
    {
        throw new NotImplementedException();
    }

    public Task<object> LoadAsync(Type theType, object id, LockMode lockMode, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<object> LoadAsync(string entityName, object id, LockMode lockMode, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<object> LoadAsync(Type theType, object id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<T> LoadAsync<T>(object id, LockMode lockMode, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<T> LoadAsync<T>(object id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<object> LoadAsync(string entityName, object id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task LoadAsync(object obj, object id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public void Lock(object obj, LockMode lockMode)
    {
        throw new NotImplementedException();
    }

    public void Lock(string entityName, object obj, LockMode lockMode)
    {
        throw new NotImplementedException();
    }

    public Task LockAsync(object obj, LockMode lockMode, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task LockAsync(string entityName, object obj, LockMode lockMode, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public object Merge(object obj)
    {
        throw new NotImplementedException();
    }

    public object Merge(string entityName, object obj)
    {
        throw new NotImplementedException();
    }

    public T Merge<T>(T entity) where T : class
    {
        throw new NotImplementedException();
    }

    public T Merge<T>(string entityName, T entity) where T : class
    {
        throw new NotImplementedException();
    }

    public Task<object> MergeAsync(object obj, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<object> MergeAsync(string entityName, object obj, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<T> MergeAsync<T>(T entity, CancellationToken cancellationToken = default) where T : class
    {
        throw new NotImplementedException();
    }

    public Task<T> MergeAsync<T>(string entityName, T entity, CancellationToken cancellationToken = default) where T : class
    {
        throw new NotImplementedException();
    }

    public void Persist(object obj)
    {
        throw new NotImplementedException();
    }

    public void Persist(string entityName, object obj)
    {
        throw new NotImplementedException();
    }

    public Task PersistAsync(object obj, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task PersistAsync(string entityName, object obj, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public IQueryable<T> Query<T>()
    {
        throw new NotImplementedException();
    }

    public IQueryable<T> Query<T>(string entityName)
    {
        throw new NotImplementedException();
    }

    public IQueryOver<T, T> QueryOver<T>() where T : class
    {
        throw new NotImplementedException();
    }

    public IQueryOver<T, T> QueryOver<T>(Expression<Func<T>> alias) where T : class
    {
        throw new NotImplementedException();
    }

    public IQueryOver<T, T> QueryOver<T>(string entityName) where T : class
    {
        throw new NotImplementedException();
    }

    public IQueryOver<T, T> QueryOver<T>(string entityName, Expression<Func<T>> alias) where T : class
    {
        throw new NotImplementedException();
    }

    public void Reconnect()
    {
        throw new NotImplementedException();
    }

    public void Reconnect(DbConnection connection)
    {
        throw new NotImplementedException();
    }

    public void Refresh(object obj)
    {
        throw new NotImplementedException();
    }

    public void Refresh(object obj, LockMode lockMode)
    {
        throw new NotImplementedException();
    }

    public Task RefreshAsync(object obj, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task RefreshAsync(object obj, LockMode lockMode, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public void Replicate(object obj, ReplicationMode replicationMode)
    {
        throw new NotImplementedException();
    }

    public void Replicate(string entityName, object obj, ReplicationMode replicationMode)
    {
        throw new NotImplementedException();
    }

    public Task ReplicateAsync(object obj, ReplicationMode replicationMode, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task ReplicateAsync(string entityName, object obj, ReplicationMode replicationMode, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public object Save(object obj)
    {
        throw new NotImplementedException();
    }

    public void Save(object obj, object id)
    {
        throw new NotImplementedException();
    }

    public object Save(string entityName, object obj)
    {
        throw new NotImplementedException();
    }

    public void Save(string entityName, object obj, object id)
    {
        throw new NotImplementedException();
    }

    public Task<object> SaveAsync(object obj, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task SaveAsync(object obj, object id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<object> SaveAsync(string entityName, object obj, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task SaveAsync(string entityName, object obj, object id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public void SaveOrUpdate(object obj)
    {
        throw new NotImplementedException();
    }

    public void SaveOrUpdate(string entityName, object obj)
    {
        throw new NotImplementedException();
    }

    public void SaveOrUpdate(string entityName, object obj, object id)
    {
        throw new NotImplementedException();
    }

    public Task SaveOrUpdateAsync(object obj, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task SaveOrUpdateAsync(string entityName, object obj, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task SaveOrUpdateAsync(string entityName, object obj, object id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public ISharedSessionBuilder SessionWithOptions()
    {
        throw new NotImplementedException();
    }

    public ISession SetBatchSize(int batchSize)
    {
        throw new NotImplementedException();
    }

    public void SetReadOnly(object entityOrProxy, bool readOnly)
    {
        throw new NotImplementedException();
    }

    public void Update(object obj)
    {
        throw new NotImplementedException();
    }

    public void Update(object obj, object id)
    {
        throw new NotImplementedException();
    }

    public void Update(string entityName, object obj)
    {
        throw new NotImplementedException();
    }

    public void Update(string entityName, object obj, object id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(object obj, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(object obj, object id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(string entityName, object obj, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(string entityName, object obj, object id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
