using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RingQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int> { 1, 2, 3 };
            List<int> b = new List<int> { 2, 3, 3 };
            a = a.Except(b).ToList();
        }
    }

    /// <summary>
    /// 环形队列
    /// </summary>
    public class RingQueue
    {
        /// <summary>
        /// 初始值为0 是队列的头
        /// </summary>
        public int front { get; set; }

        /// <summary>
        /// 初始值为0 是队列的尾巴
        /// </summary>
        public int rear { get; set; }

        /// <summary>
        /// 创建队列
        /// </summary>
        public int[] arr { get; set; }

        /// <summary>
        /// 初始化队列构造器
        /// </summary>
        /// <param name="maxSize"></param>
        public RingQueue(int maxSize) 
        {
            arr = new int[maxSize];
        }

        /// <summary>
        /// 队列是否为空
        /// </summary>
        public bool IsEmpty()
        {
            return front == rear?false:true;
        }

        /// <summary>
        /// 队列有效值数量
        /// </summary>
        public void ExistSise() 
        {
            //if () 
            //{
            
            //}
        }
    }
}
