public class Solution_134 {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        
        var initialCost = cost[0];

        var initialStation = Array.IndexOf(gas, (initialCost+1));
        
        if(initialStation == -1)
            return -1;
        
        int path = initialStation;
        int enoughGas = gas[path] - cost[initialStation];
       path = ((path + 1) == cost.Count())?
                0 : path++;

        while(enoughGas> 0 && path != initialStation){
            //avance             
            path = ((path + 1) == cost.Count())?
                0 : path++;
            //Check gas
            enoughGas += (gas[path] - cost[initialStation]);            
            
            if(enoughGas < 0) return -1;
        }

        return (path != initialStation)? -1 : initialStation;
    }
}