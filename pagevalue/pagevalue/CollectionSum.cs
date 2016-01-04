using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace pagevalue
{
    public class CollectionSum
    {
        private List<OrderObject> collectionOrder;
        public CollectionSum()
        {
            CollInit();
        }
        private void CollInit()
        {
            collectionOrder = new List<OrderObject>()
            {
                { new OrderObject {Id=1,Cost=1, Revenue=11, SellPrice=21}},
                { new OrderObject {Id=2,Cost=2, Revenue=12, SellPrice=22}},
                { new OrderObject {Id=3,Cost=3, Revenue=13, SellPrice=23}},
                { new OrderObject {Id=4,Cost=4, Revenue=14, SellPrice=24}},
                { new OrderObject {Id=5,Cost=5, Revenue=15, SellPrice=25}},
                { new OrderObject {Id=6,Cost=6, Revenue=16, SellPrice=26}},
                { new OrderObject {Id=7,Cost=7, Revenue=17, SellPrice=27}},
                { new OrderObject {Id=8,Cost=8, Revenue=18, SellPrice=28}},
                { new OrderObject {Id=9,Cost=9, Revenue=19, SellPrice=29}},
                { new OrderObject {Id=10,Cost=10, Revenue=20, SellPrice=30}},
                { new OrderObject {Id=11,Cost=11, Revenue=21, SellPrice=31}}
            };
        }

        public string Sum(int groupNum,string groupColumns)
        {
            int totalGroupPages = collectionOrder.Count / groupNum + 1;
            string sumText = string.Empty;
            List<int> resultList = new List<int>();
            for (int currentPage = 1; currentPage <= totalGroupPages; currentPage++)
            {
                var result = collectionOrder.OrderBy(d => d.Id).Skip(groupNum * (currentPage - 1)).Take(groupNum).Sum(x => (int)x.GetType().GetProperty(groupColumns).GetValue(x));
                resultList.Add(result);
            }

            return string.Join(",",resultList);

        }
    }
}
