using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsiniBul
{
    public static class Islemler
    {
        static Random rnd=new Random();
        public static void Karistir<T>(IList<T> list)
        {
            T gecici;
            int talihliIndex;
            for (int i = 0; i <list.Count-1; i++)
            {
                talihliIndex = rnd.Next(i, list.Count);
                gecici = list[i];
                list[i] = list[talihliIndex];
                list[talihliIndex] = gecici;

            }
        }
    }
}
