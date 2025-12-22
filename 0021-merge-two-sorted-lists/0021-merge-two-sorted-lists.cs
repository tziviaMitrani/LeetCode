/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode newList=new ListNode();
        ListNode mergeList=newList;
        while(list1!=null&&list2!=null)
        {
            if(list1.val<=list2.val)
            {
                mergeList.next=list1;
                list1=list1.next;
            }
            else{
                mergeList.next=list2;
                list2=list2.next;
            }
            mergeList=mergeList.next;
        }
       if(list1!=null)
            mergeList.next=list1;
       else
            mergeList.next=list2;
       return newList.next;
    }

}