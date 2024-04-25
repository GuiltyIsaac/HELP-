using System;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Cua<T> : IEnumerable<T>
    {
        private Node<T> primer = null;
        private Node<T> ultim = null;

        public Cua()
        {
            Node<T> sentinella = new Node<T>();
            this.primer = sentinella;
            this.ultim = this.primer;
        }
        public void Encua(T dada)
        {
            Node<T> nouNode = new Node<T>(dada);
            this.ultim.Seguent = nouNode;
            this.ultim = nouNode;
        }
        //public void Desencua() MALAMENT!!!!!
        //{
        //    this.primer.Seguent = this.primer.Seguent.Seguent;   
        //}

        //public void Desencua() MALAMENT!!!!!
        //{
        //    this.primer = this.primer.Seguent.Seguent;
        //    if (EsBuida)
        //    {
        //        this.ultim = this.primer;     
        //    }
        //}
        public void Desencua()
        {
            this.primer = this.primer.Seguent;
        }
        public T Primer
        {
            get
            {
                if (EsBuida) throw new Exception("LA CUA ÉS BUIDA!");
                else return this.primer.Seguent.Info;
            }
        }
        public bool EsBuida
        {
            get { return this.primer.Seguent == null; }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");

            foreach (T item in this)
            {
                sb.Append(item.ToString());
                sb.Append(", ");
            }

            sb.Append("]");

            return sb.ToString();
        }
        public override bool Equals(object obj)
        {
            Cua<T> unAltre = (Cua<T>)obj;
            bool iguals = true;

            if (obj == null || this.GetType() != obj.GetType() || this.Count() != unAltre.Count())
            {
                iguals = false;
            }
            else
            {
                IEnumerator<T> enumerator1 = GetEnumerator();
                IEnumerator<T> enumerator2 = unAltre.GetEnumerator();

                while (enumerator1.MoveNext() && enumerator2.MoveNext() && iguals)
                {
                    if (!enumerator1.Current.Equals(enumerator2.Current))
                    {
                        iguals = false;
                    }
                }
            }

            return iguals;
        }
        public IEnumerator<T> GetEnumerator()
        {
            Node<T> cursor = primer.Seguent;
            while (cursor != null)
            {
                yield return cursor.Info;
                cursor = cursor.Seguent;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
