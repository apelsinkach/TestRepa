﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class ClassArray<T> where T:ITransport
    {
        private T[] places;
        private T defaultValue;

        public ClassArray(int sizes,T defVal)
        {
            defaultValue = defVal;
            places = new T[sizes];
            for(int i = 0; i < places.Length; i++)
            {
                places[i] = defaultValue;
            }
        }


        public static int operator +(ClassArray<T> p, T locomotive)
        {
            for (int i = 0; i < p.places.Length; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    p.places[i] = locomotive;
                    return i;
                }
            }
            return -1;
        }

        public static T operator -(ClassArray<T> p, int index)
        {
            if (!p.CheckFreePlace(index))
            {
                T locomotive = p.places[index];
                p.places[index] = p.defaultValue;
                return locomotive;
            }
            return p.defaultValue;
        }
   
        private bool CheckFreePlace(int index)
        {
            if (index < 0 || index > places.Length)
            {
                return false;
            }
            if (places[index] == null)
            {
                return true;
            }
            if (places[index].Equals(defaultValue))
            {
                return true;
            }
            return false;
        }

        public T getObject(int ind)
        {
            if(ind>-1 && ind < places.Length)
            {
                return places[ind];
            }
            return defaultValue;
        }
    }
}
