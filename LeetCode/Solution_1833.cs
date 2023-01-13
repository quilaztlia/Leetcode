public class Solution_1833{
    
    public int MaxIceCream(int[] costs, int coins) {
        
        var glaceNumber = costs.Count();
        
        var minPrice = costs.Min();
        
        if(coins < minPrice) return 0;
        
        double sumPrice = 0;
        int i=0;
        while(sumPrice<coins && i<glaceNumber){
        //for(int i=0; i<glaceNumber; i++)
            sumPrice+= costs[i];        
        }
        if(coins > sumPrice) return glaceNumber;
        
        var orderCosts = costs.OrderBy(x => x).ToArray();
        var bars=0;
        while(coins > 0 && bars < glaceNumber){
            coins -= orderCosts[bars];
            
             if(coins>=0) bars++; 
        }        
        return bars;
    }
}