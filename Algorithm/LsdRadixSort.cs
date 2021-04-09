using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class LsdRadixSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public LsdRadixSort(IEnumerable<T> items) : base(items) { }

        public LsdRadixSort() { }

        protected override void MakeSort()
        {
            var groups = new List<List<T>>();
            for (int i = 0; i < 10; i++)
            {
                groups.Add(new List<T>());
            }

            int length = GetMaxLength();

            for (int step = 0; step < length; step++)
            {
                
                foreach (var item in Items)
                {
                    var i = item.GetHashCode();
                    var value = i % (int)Math.Pow(10, step + 1) / (int)Math.Pow(10, step);
                    groups[value].Add(item);
                }

                var j = 0;
                
                foreach (var group in groups)
                {
                    foreach (var item in group)
                    {
                        Set(j, item);
                        j++;
                    }
                }

              
                foreach (var group in groups)
                {
                    group.Clear();
                }
            }
        }

        private int GetMaxLength()
        {
            int length = 0;
            foreach (var item in Items)
            {
                if (item.GetHashCode() < 0)
                {
                    throw new ArgumentException("Radix Sort hva only native numbers", nameof(Items));
                }
             
                var l = item.GetHashCode().ToString().Length;
                if (l > length)
                {
                    length = l;
                }
            }
            return length;
        }
    }
}
