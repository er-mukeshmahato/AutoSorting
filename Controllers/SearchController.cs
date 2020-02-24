using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SortApi.Helper;
using SortApi.Model;

namespace SortApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        [HttpPost("Linear")]
        public SearchResult Linear([FromBody] Search InputModel)
        {

            int[] array = InputModel.array.ToArray();
            int len = array.Length;
            Stopwatch sw = Stopwatch.StartNew();
            int i = InputModel.x;
            
            Linear search = new Linear();
           int index= search.search(array,i);
            sw.Stop();






            return new SearchResult()
            {
                SortedArray = array.ToList(),
                Index = index,
                ExecutionTime = sw.Elapsed.TotalMilliseconds

            };


        }

        [HttpPost("Binary")]
        public SearchResult Binary([FromBody] Search InputModel)
        {

            int[] array = InputModel.array.ToArray();
            int len = array.Length;
            Stopwatch sw = Stopwatch.StartNew();
            Array.Sort(array);
            int i = InputModel.x;
            BinarySearch search = new BinarySearch();
            int index= search.binarySearch(array,0,len-1,i);
            sw.Stop();






            return new SearchResult()
            {
                SortedArray = array.ToList(),
                Index = index,
                ExecutionTime = sw.Elapsed.TotalMilliseconds

            };


        }
        [HttpPost("Jump")]
        public SearchResult Jump([FromBody] Search InputModel)
        {

            int[] array = InputModel.array.ToArray();
            int len = array.Length;
            Stopwatch sw = Stopwatch.StartNew();
            Array.Sort(array);
            int i =InputModel.x;

            JumpSearch search = new JumpSearch();
           int index= search.jumpSearch(array, i);
            sw.Stop();






            return new SearchResult()
            {
                SortedArray = array.ToList(),
                Index = index,
                ExecutionTime = sw.Elapsed.TotalMilliseconds

            };


        }
       
         [HttpGet("Jumps")]
        public string Jumps()
        {
            return "jumps";
        }
    }
}