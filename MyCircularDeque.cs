public class MyCircularDeque {
   private int maxLength=0;
    private LinkedList<int> list=new LinkedList<int>();
    public MyCircularDeque(int k) {
        maxLength = k;
    }
    
    public bool InsertFront(int value) {
        if(IsFull()){
            return false;
        }
        this.list.AddFirst(new LinkedListNode<int>(value));
        
        return true;
    }
    
    public bool InsertLast(int value) {
        if(IsFull()) 
            return false;
        this.list.AddLast(new LinkedListNode<int>(value));
        return true;
    }
    
    public bool DeleteFront() {
        if(IsEmpty()) return false;
        this.list.RemoveFirst();
        return true;        
    }
    
    public bool DeleteLast() {
        if(IsEmpty()) return false; 
        this.list.RemoveLast();
        return true;
        
    }
    
    public int GetFront() {
        if(IsEmpty()) return -1;
        
        return this.list.First();
    }
    
    public int GetRear() {
        if(IsEmpty()) return -1;
        
        return this.list.Last();
    }
    
    public bool IsEmpty() {
       return this.list.Count == 0;
            
    }
    
    public bool IsFull() {
        return this.maxLength == this.list.Count;
    }
}
