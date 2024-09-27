public class MyCalendarTwo {
   private List<int[]> bookings;
    public MyCalendarTwo() {
           bookings = new List<int[]>();
    }
    
    public bool Book(int start, int end) {     
        var overlaps = new List<int[]>();
        foreach(int[] book in bookings) 
        {
            int overlapStart = Math.Max(book[0], start), overlapEnd = Math.Min(book[1], end);
            if (overlapStart < overlapEnd) 
            {
                foreach (int[] overlap in overlaps) 
                {
                    if (Math.Max(overlap[0], overlapStart) < Math.Min(overlap[1], overlapEnd)) 
                    {
                        overlaps.Clear();
                        return false;
                    }
                }
                
                overlaps.Add(new int[] {overlapStart, overlapEnd});
            }
        }
        
        bookings.Add(new int[] {start, end});
        return true;
    }    
 
}