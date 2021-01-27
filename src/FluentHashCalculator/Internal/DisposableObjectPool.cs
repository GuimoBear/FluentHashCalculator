using System;
using System.Collections.Concurrent;

namespace FluentHashCalculator.Internal
{
    internal class DisposableObjectPool<T>
        where T: IDisposable
    {
        internal readonly ConcurrentBag<T> _objects;
        private readonly Func<T> _objectGenerator;

        public DisposableObjectPool(Func<T> objectGenerator)
        {
            _objectGenerator = objectGenerator ?? throw new ArgumentNullException(nameof(objectGenerator));
            _objects = new ConcurrentBag<T>();
        }

        ~DisposableObjectPool()
        {
            try
            {
                while (_objects.TryTake(out T instance))
                {
                    try
                    {
                        instance.Dispose();
                    }
                    catch
                    {

                    }
                }
            }
            catch
            {

            }
        }

        public Container<T> Acquire()
            => new Container<T>(this);

        private T Get()
        {
            return _objects.TryTake(out T item) ? item : _objectGenerator(); 
        }

        private void Return(T item) => _objects.Add(item);

        internal class Container<T> : IDisposable
            where T : IDisposable
        {
            private readonly DisposableObjectPool<T> pool;

            public readonly T Instance;

            public Container(DisposableObjectPool<T> pool)
            {
                this.pool = pool;
                Instance = pool.Get();
            }

            public void Dispose()
            {
                pool.Return(Instance);
            }
        }
    }
}
