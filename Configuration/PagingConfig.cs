using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWebsite.Configuration
{
    public class PagingConfig
    {
        public bool CustomPager { get; set; }
        public bool Enabled { get; set; }
        public int PageSize { get; set; }

        public int NumOfItemsToSkip (int currentPageNumber)
        {
            if (Enabled)
            {
                return (currentPageNumber -1) * PageSize;
            }
            return 0;
        }

        public int NumOfItemsToTake(int totalItemsCount)
        {
            if(Enabled)
            {
                return PageSize;
            }
            return 0;
        }

        public int PrevPageNumber(int currentPageNumber)
        {
            if (currentPageNumber > 1)
            {
                return currentPageNumber - 1;
            }
            else
            {
                return 1;
            }
        }
        public int NextPageNumber (int currentPageNumber, int totalItemsCount)
        {
            if (currentPageNumber < MaxPageNumber(totalItemsCount))
            {
                return currentPageNumber + 1;
            }
            else
            {
                return currentPageNumber;
            }
        }

        public int MaxPageNumber(int totalItemsCount)
        {
            int maxPageNumber;
            double numberOfPages = totalItemsCount / (double)PageSize;
            if(numberOfPages == Math.Floor(numberOfPages))
            {
                maxPageNumber = (int)numberOfPages;
            }
            else
            {
                maxPageNumber = (int)numberOfPages + 1;
            }
            return maxPageNumber;
        }
    }
}
