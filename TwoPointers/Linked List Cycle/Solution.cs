/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {

//         if(head == null || head.next == null)
//         {
//             return false;
//         }

//         ListNode behind = head;
//         ListNode lead = head.next;
//         while(behind.next!=null)
//         {
//             if(lead == behind)
//             {
//                 return true;
//             }
//             behind = behind.next;

//             for(int i=0;i<2;i++)
//             {
//                 if(lead.next==null)
//                 {
//                     return false;
//                 }
//                 lead = lead.next;
//             }
//         }
//         return false;
        // HashSet<ListNode> nodesSeen = new HashSet<ListNode>();
        // while (head != null) {
        //     if (nodesSeen.Contains(head)) {
        //         return true;
        //     } else {
        //         nodesSeen.Add(head);
        //     }
        //     head = head.next;
        // }
        // return false;

        if(head == null || head.next == null)
        {
            return false;
        }

        ListNode behind = head;
        ListNode lead = head.next;
        while(lead!=behind)
        {
            if(lead.next==null || lead.next.next ==null){
                return false;
            }
            lead = lead.next.next;

            behind=behind.next;

        }
        return true;

    }
}
