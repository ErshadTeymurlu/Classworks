using _06_04_2022_Classwork.Utilies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_04_2022_Classwork.Models
{
    class MyList<T>
    {
        private T[] _arr;
        public static void Resize(ref T[] arr,int length)
        {
            T[] newArr = new T[length];
            for (int i = 0; i < arr.Length; i++) newArr[i] = arr[i];
            arr = newArr;
        }
        public void AddItem(T element)
        {
            Resize(ref _arr, _arr.Length+1);
            _arr[_arr.Length-1] = element;
        }
        public void AddItems(params T[] elements)
        {
            Resize(ref _arr, elements.Length);
            _arr = elements;
        }
        public void Remove(T t)
        {
            for(int i = 0; i < _arr.Length; i++)
            {
                if (t.Equals(_arr[i])) break;
                else throw new NotFoundException("");
            }
        }
    }
}
