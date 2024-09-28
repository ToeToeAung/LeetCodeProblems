
  public class ListNode {
     public int val;
     public ListNode next;
     public ListNode(int val=0, ListNode next=null) {
          this.val = val;
         this.next = next;
     }
  }
 
public class Solution {

    public void ReorderList(ListNode head) {
         Stack<ListNode> s1 = new();
        var dummy = head;
        int count = 0; 
        
        while(dummy is not null) 
        {
            ++count;
            s1.Push(dummy);
            dummy = dummy.next;
        }
        
        ListNode node = new(); 
        var result = node; 
        
        for(int i = 0; i < count / 2; i++) 
        {
            node.next = head;
            head = head.next;
            node = node.next;
            
            node.next = s1.Pop();
            node = node.next;
        }
        
        if(count % 2 != 0) 
        {
            node.next = head;
            node = node.next;
        }
        
        node.next = null; 
        
        head = result.next; 
    }
}