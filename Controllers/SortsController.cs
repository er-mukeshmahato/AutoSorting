using Microsoft.AspNetCore.Mvc;
using SortApi.Helper;
using SortApi.Model;
using SortApi1.Helper;
using System.Diagnostics;
using System.Linq;
using static SortApi1.Helper.check;

namespace SortApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SortsController : ControllerBase
    {
        

	
        [HttpPost("Sort")]
        public Result SortAlgorithm([FromBody] Sort InputModel)
        {

            int[] array = InputModel.array.ToArray();
            string text = "Sorted";
            string text1 = "Mukesh Mahato";
            string text2 = "Quick Sort";
            string text3 = "Bubble sort";
            string text4 = "Insertion sort";
            string text5 = "Heap sort";
            int len = array.Length;
            check c = new check();
            c.IsSorted(array);
            c.IsSortedDescending(array);
            c.almostSort(array);
            c.sort(array);

            if ( ( (c.IsSorted(array) || c.IsSortedDescending(array)) || (c.almostSort(array) || c.sort(array))) && (len>30))
            {



                Stopwatch sw = Stopwatch.StartNew();
                QuickSort qs = new QuickSort();
                qs.Sort(array, 0, len - 1);
                sw.Stop();


                return new Result()
                {
                    Created_by = text1,
                    Sorting_Algorithm = text2,
                    Status = text,
                    SortedArray = array,
                    ExecutionTime = sw.Elapsed.TotalMilliseconds
                };
            }

            else if (c.IsSorted(array) && c.almostSort(array) && c.sort(array))
            
            {
                if (len<30)
                {
                    Stopwatch sw = Stopwatch.StartNew();
                    BubbleSort bs = new BubbleSort();
                    bs.printArray(array);
                    sw.Stop();




                    return new Result()
                    {
                        Created_by = text1,
                        Sorting_Algorithm = text3,
                        Status = text,
                        SortedArray = array,
                        ExecutionTime = sw.Elapsed.TotalMilliseconds
                    };



                }
                else
                {
                    Stopwatch sw = Stopwatch.StartNew();
                    InsertionSort Sort = new InsertionSort();
                    Sort.print(array);
                    sw.Stop();




                    return new Result()
                    {
                        Created_by = text1,
                        Sorting_Algorithm = text4,
                        Status = text,
                        SortedArray = array,
                        ExecutionTime = sw.Elapsed.TotalMilliseconds
                    };


                }





            }
           
            else 
            {
                Stopwatch sw = Stopwatch.StartNew();
                HeapSort Sort = new HeapSort();
                Sort.sort(array);
                sw.Stop();




                return new Result()
                {
                    Created_by = text1,
                    Sorting_Algorithm = text5,
                    Status = text,
                    SortedArray = array,
                    ExecutionTime = sw.Elapsed.TotalMilliseconds
                };


            }
        }
        [HttpGet("Jumps")]
        public string Jumps()
        {
            return "jumps";
        }



    }
}







