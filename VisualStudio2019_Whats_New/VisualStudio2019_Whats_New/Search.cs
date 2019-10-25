using System;
using System.Collections.Generic;
using System.Text;

namespace VisualStudio2019_Whats_New
{
    public class Search
    {
        public int Id { get; set; }
        public string SearchText { get; set; }
        public Result Result { get; set;}
        public List<Result> Results { get; set;}

        public Result ReturnResult(int resultId)
        {
               
            //Todo Result Return code 
            return Result;
        }

    }
}
