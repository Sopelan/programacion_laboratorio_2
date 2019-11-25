using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_17
{
    public class MiLista<T> : IEnumerable<T>
    {
        private List<T> lista;
        public MiLista()
        {
            lista = new List<T>();
        }
        public int Count
        {
            get
            {
                return lista.Count;
            }
        }
        public void Add(T t)
        {
            lista.Add(t);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)lista).GetEnumerator();
        }

        public void Remove(T t)
        {
            lista.Remove(t);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)lista).GetEnumerator();
        }
    }
}
