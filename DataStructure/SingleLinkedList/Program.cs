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
            singleLinkedList.AddLinkedList(hero3);
            singleLinkedList.AddLinkedList(hero2);
            singleLinkedList.ListLinkedList();
            Console.ReadKey();
        }
    }
    class SingleLinkedList
    {
        private HeroNode head = new HeroNode(0, "");

        /// <summary>
        /// 添加链表
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
        /// 遍历链表
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
