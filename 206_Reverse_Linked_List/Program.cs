namespace _206_Reverse_Linked_List
{
    internal class Program
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
        public static void PrintLinkedList(ListNode head)
        {
            while (head != null)
            {
                Console.Write("Node List : " + head.val + "\t");
                head = head.next;
            }
            Console.WriteLine("\n");
        }
        public static ListNode ReverseList(ListNode head)
        {

            var fixHead = head;
            Console.WriteLine("[fixHead]: " + fixHead.val + "\n");
            // original [1][2][3]
            while (fixHead != null && fixHead.next != null)
            {
                var nextNode = fixHead.next; // xác định nextNode (head+1) [2]
                Console.WriteLine("[nextNode]: " + nextNode.val + " from [fixHead] " + fixHead.val);
                fixHead.next = nextNode.next; // Trở head về vị trí (head+2) [1] -> [3]
                Console.WriteLine($"[fixHead] {fixHead.val} point to [nextNode of {nextNode.val}]: {(fixHead.next != null ? fixHead.next.val : 0)}");
                nextNode.next = head; //trỏ (head+1) về head hiện tại [2] -> [1]
                Console.WriteLine($"[nextNode]: {nextNode.val} point to [currentHead]: {head.val}");
                head = nextNode; //Gán head+1 trở thành head head = [2]
                Console.WriteLine($"[newHead] = [nextNode]: {nextNode.val}");
                PrintLinkedList(head);
            }

            return head;
        }
        public static ListNode? RecursionReverseList(ListNode head)
        {
            var nextNode = head.next;
            Console.WriteLine($"[nextNode of {head?.val}] : {nextNode?.val ?? 0}");
            //điều kiện dừng
            if (head.next == null)
            {
                Console.WriteLine($"Found [lastNode]: {head.val} and return");
                return head;
            }
            else if (head == null)
            {
                Console.WriteLine("Not Found the [head]");
                return null;
            }

            Console.WriteLine($"Start Recursing with [nextNode]:{nextNode?.val} from [head]: {head.val} \n");
            var newHead = RecursionReverseList(nextNode);

            // This line reached => newHead = nextNode    
            nextNode.next = head;
            Console.WriteLine($"\n [nextNode]:{nextNode.val} point to [previousNode] {head.val} \n");

            Console.WriteLine($"Remove the point of [previousNode]: {head.val} is {head.next.val}");

            head.next = null;

            return newHead;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var n1 = new ListNode(1);
            var n2 = new ListNode(2);
            var n3 = new ListNode(3);
            var n4 = new ListNode(4);
            var n5 = new ListNode(5);
            var n6 = new ListNode(6);
            var n7 = new ListNode(7);

            n1.next = n2;
            n2.next = n3;
            n3.next = n4;
            n4.next = n5;
            n5.next = n6;
            n6.next = n7;
            PrintLinkedList(n1);
            var reverse = RecursionReverseList(n1);
            PrintLinkedList(reverse);
            Console.Read();
        }
    }
}