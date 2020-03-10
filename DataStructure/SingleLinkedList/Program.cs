using System;
using System.Collections.Generic;

namespace SingleLinkedListDamo
{

    class Program
    {

        HeroNode head = new HeroNode(0, ""); //头节点、头指针    
        static void Main(string[] args)
        {
            SingleLinkedList singleLinkedList = new SingleLinkedList();
            HeroNode hero1 = new HeroNode(1, "孙悟空");
            HeroNode hero2 = new HeroNode(2, "猪八戒");
            HeroNode hero3 = new HeroNode(3, "沙和尚");
            singleLinkedList.AddLinkedList(hero1);
            singleLinkedList.AddLinkedList(hero2);
            singleLinkedList.AddLinkedList(hero3);
            singleLinkedList.ListLinkedList();
            singleLinkedList.UpdateLinkedList(4, "唐僧");
            singleLinkedList.ListLinkedList();
            Console.ReadKey();
        }
    }
    class SingleLinkedList
    {
        private HeroNode head = new HeroNode(0, "");

        /// <summary>
        /// 添加单链表
        /// </summary>
        /// <param name="heroNode"></param>
        public void AddLinkedList(HeroNode heroNode)
        {
            var temp = head;
            while (true)
            {
                if (temp.Next == null)
                    break;
                temp = temp.Next;
            }
            temp.Next = heroNode;
        }

        /// <summary>
        /// 排序插入单链表
        /// </summary>
        public void AddOrderByLinkedList() 
        {
        
        }

        /// <summary>
        /// 遍历单链表
        /// </summary>
        /// <param name="heroNode"></param>
        public void ListLinkedList()
        {
            var temp = head;
            while (true)
            {
                if (temp.Next == null)
                    break;
                temp = temp.Next;
                Console.WriteLine(temp.Name);
            }
        }

        /// <summary>
        /// 修改单链表
        /// </summary>
        public void UpdateLinkedList(int no, string name)
        {
            var temp = head;
            bool isUpdata = false;
            while (true)
            {
                if (temp.Next == null)
                    break;
                temp = temp.Next;
                if (temp.No == no)
                {
                    var usedName = temp.Name;
                    temp.Name = name;
                    isUpdata = true;
                    Console.WriteLine("修改成功！修改前：" + usedName + ",修改后：" + temp.Name);                  
                    break;
                }
            }
            if (isUpdata==false) 
            {
                Console.WriteLine("修改失败，查询不到需要修改的数据！");
            }

        }
    }

    class HeroNode
    {
        public int No { get; set; }
        public string Name { get; set; }
        public HeroNode Next { get; set; }
        public HeroNode(int no, string name)
        {
            No = no;
            Name = name;
        }
    }
}
