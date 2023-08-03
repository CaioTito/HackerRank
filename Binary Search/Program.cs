public class Solution
{
    public int Search(int[] nums, int alvo)
    {
        int minimo = 0;
        int maximo = nums.Count() - 1;

        while (minimo <= maximo)
        {
            int metade = (minimo + maximo) / 2;
            int palpite = nums[metade];

            if (palpite == alvo)
                return metade;
            if(palpite > alvo)
                maximo = metade - 1;
            else
                minimo = metade + 1;
        }
        return -1;
    }
}