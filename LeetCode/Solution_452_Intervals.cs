public class Solution_452_Intervals
{

    public int FindMinArrowShots(int[][] points)
    {
        var totalArrows = 0;
        List<int> arrowPoints = new List<int>();

        //int i =0;
        var orderPoints = points.OrderBy(x => x[0]).ToList();

        for (int i = 0; i < orderPoints.Count()-1; i++)
        {
            bool areIntecepted = 
                CheckInterception(orderPoints[i], orderPoints[i + 1]);

            if (!areIntecepted)
                totalArrows = (totalArrows==0)? 2 : 1;

            else
            {
                int arrowPoint =
                    GetFarestInterceptionPoint(orderPoints[i], orderPoints[i + 1]);

                arrowPoints.Add(arrowPoint);

                if (arrowPoints.Count() > 1)
                {
                    if (arrowPoints[i - 1] < arrowPoints[i])
                        totalArrows++;
                }
            }
        }
        return totalArrows;
    }

    private bool CheckInterception(int[] first, int[] second)
    {
        return (second[0] < first[1]);
    }

    private int GetFarestInterceptionPoint(int[] first, int[] second)
    {
        int arrowPosition = -1;

        var start = Math.Min(first[0], second[1]);

        var middle1 = Math.Min(first[0], second[0]);
        var middle2 = Math.Min(first[1], second[1]);
        var middle = Math.Max(middle1, middle2);

        var end = Math.Min(first[1], second[0]);

        arrowPosition = Math.Max(Math.Max(start, middle), end);

        return arrowPosition;
    }
}