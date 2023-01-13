public class Solution_6287
{
    public string CategorizeBox(int length, int width, int height, int mass)
    {
        string labelBulky = string.Empty;
        string labelHeavy = string.Empty;
        string label = string.Empty;

        ulong volume = (ulong)length *(ulong) width * (ulong)height;
        //var volume = volume1 * height;

        if ((length >= 10000 || width >= 10000 || height >= 10000)
         || (volume >= 1000000000))
            labelBulky = "Bulky";

        if (mass >= 100)
            labelHeavy = "Heavy";

        if (!string.IsNullOrWhiteSpace(labelBulky)
           && !string.IsNullOrWhiteSpace(labelHeavy))
            label = "Both";

        if (string.IsNullOrWhiteSpace(labelBulky)
           && string.IsNullOrWhiteSpace(labelHeavy))
            label = "Neither";

        if (!string.IsNullOrWhiteSpace(labelBulky)
           && string.IsNullOrWhiteSpace(labelHeavy))
            label = "Bulky";

        if (string.IsNullOrWhiteSpace(labelBulky)
           && !string.IsNullOrWhiteSpace(labelHeavy))
            label = "Heavy";

        return label;
    }

}