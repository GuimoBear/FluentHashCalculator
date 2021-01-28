using System;
using System.Collections.Concurrent;

namespace FluentHashCalculator.Internal
{
    internal class ObjectPool<T>
    {
        internal readonly ConcurrentBag<T> _objects;
        private readonly Func<T> _objectGenerator;

        public ObjectPool(Func<T> objectGenerator)
        {
            _objectGenerator = objectGenerator ?? throw new ArgumentNullException(nameof(objectGenerator));
            _objects = new ConcurrentBag<T>();
        }
        /*
        ~ObjectPool()
        {
            try
            {
                while (_objects.TryTake(out T instance))
                {
                    try
                    {
                        if (instance is IDisposable disposable)
                            disposable.Dispose();
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
        */

        public Container<T> Acquire()
            => new Container<T>(this);

        private T Get()
        {
            return _objects.TryTake(out T item) ? item : _objectGenerator(); 
        }

        private void Return(T item) => _objects.Add(item);

        internal class Container<T> : IDisposable
        {
            private readonly ObjectPool<T> pool;

            public readonly T Instance;

            public Container(ObjectPool<T> pool)
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
