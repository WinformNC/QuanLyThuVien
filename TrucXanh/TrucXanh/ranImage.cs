using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrucXanh
{
     class IImage
    {
       public string Image;
       public int Flag;
        public IImage(string Image,int Flag)
        {
            this.Image = Image;
            this.Flag = Flag;
        }
    }
    public class ListImage
    {
        List<IImage> lst = new List<IImage>();
        string[] lstImage = { "101.jpg", "102.jpg", "103.jpg", "104.jpg", "105.jpg", "106.jpg", "107.jpg", "108.jpg", "109.jpg", "110.jpg" };
        Random rand = new Random();
        public void CreateListImage(int max)
        {
            for (int i = 0; i < max; i++ )
                lst.Add(new IImage(lstImage[i], 0));
        }
        public string ranImage(int max)
        {
            
            int num= rand.Next(max);
           while(lst[num].Flag > 1)
               num = rand.Next(max);
           lst[num].Flag++;
           return lst[num].Image;
        }
    }
}
