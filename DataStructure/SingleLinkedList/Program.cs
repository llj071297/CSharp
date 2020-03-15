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
            HeroNode hero4 = new HeroNode(4, "唐僧");
            //singleLinkedList.AddLinkedList(hero1);
            //singleLinkedList.AddLinkedList(herop2);
            //singleLinkedList.AddLinkedList(hero3);
            singleLinkedList.AddOrderByLinkedList(hero1);
            singleLinkedList.AddOrderByLinkedList(hero3);
            singleLinkedList.AddOrderByLinkedList(hero2);
            singleLinkedList.AddOrderByLinkedList(hero4);
            // singleLinkedList.UpdateLinkedList(4, "唐僧1");
            //singleLinkedList.deleteLinkedList(1);
            singleLinkedList.ListLinkedList();
            var heroNode = singleLinkedList.FindLastIndexNode(1);
            Console.WriteLine(heroNode?.Name);
            int count = singleLinkedList.GetLinkedListCount();
            Console.WriteLine(count);
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
        /// 获取单链表的有效个数
        /// </summary>
        public int GetLinkedListCount()
        {
            var temp = head;
            int Count = 0;
            if (temp.Next == null)
                return Count;
            while (true)
            {
                if (temp.Next == null)
                    break;
                ++Count;
                temp = temp.Next;
            }
            return Count;

        }

        /// <summary>
        /// 获取倒数第几个
        /// 1、index表示是倒数第index个节点
        /// 2、先把链表从头到尾遍历，得到链表的总的长度
        /// 3、得到size后，我们从链表的第一个开始遍历(size-index)个，就可以得到
        /// </summary>
        /// <returns></returns>
        public HeroNode FindLastIndexNode(int index)
        {
            HeroNode temp = head;
            if (temp.Next == null)
                return null;
            int size = GetLinkedListCount(); //得到链表的总长度
            if (index <= 0 || index > size) //对index做个验证
            {
                return null;
            }
            for (int i = 0; i < size - index; i++)
            {
                temp = temp.Next;
            }
            return temp.Next;
        }


        /// <summary>
        /// 排序插入单链表
        /// </summary>
        /// <param name="heroNode"></param>
        public void AddOrderByLinkedList(HeroNode heroNode)
        {
            var temp = head;
            bool falg = false;
            while (true)
            {
                if (temp.Next == null)
                    break;
                if (temp.Next.No > heroNode.No)
                    break;
                else if (temp.Next.No == heroNode.No)
                {
                    falg = true;
                    break;
                }
                temp = temp.Next;  //如果没有满足这三个条件继续下去找
            }
            if (falg == true)
                Console.WriteLine("已经有存在的");

            heroNode.Next = temp.Next;
            temp.Next = heroNode;


        }



        /// <summary>
        /// 遍历单链表
        /// </summary>
        /// <param name="heroNode"></param>
        public void ListLinkedList()
        {
            var temp = head;
            int number = 0;
            while (true)
            {
                if (temp.Next == null)
                    break;
                ++number;
                temp = temp.Next;
                Console.WriteLine($"编号：{temp.No} ,姓名：{temp.Name}");
            }
            if (number == 0)
                Console.WriteLine("单链表为空");
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
            if (isUpdata == false)
            {
                Console.WriteLine("修改失败，查询不到需要修改的数据！");
            }

        }

        /// <summary>
        /// 删除单链表
        /// </summary>
        /// <param name="no"></param>
        public void deleteLinkedList(int no)
        {
            var temp = head;
            var felg = false;
            while (true)
            {
                if (temp.Next == null)
                    break;
                if (temp.Next.No == no) //查找需要删除的节点
                {
                    felg = true;
                    break;
                }
                temp = temp.Next;
            }
            if (felg)
            {
                temp.Next = temp.Next.Next; // 把删除的节点下一个赋值给删除节点上一个
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
