//Task 1
//In a given array of integers nums swap values of the first and the last array elements, the second and the penultimate etc., if the two exchanged values are even
//Example
//{ 10 , 5, 3, 4}               =>  { 4, 5, 3, 10}
//{ 100, 2, 3, 4, 5}             => { 100, 4, 3, 2, 5}
//{ 100, 2, 3, 45, 33, 8, 4, 54} => { 54, 4, 3, 45, 33, 8, 2, 100}

static void swapNums (int[] nums)
{
    int temp;

    for (int i = 0; i < nums.Length / 2; i++) 
    {
        if(nums[i] % 2 == 0 && nums[nums.Length - (i + 1)] % 2 == 0)
        {
            temp = nums[i];
            nums[i] = nums[nums.Length - (i + 1)];
            nums[nums.Length - (i + 1)] = temp;
        }
    }
}

//Task 2
//In a given array of integers nums calculate integer result value, that is equal to the distance between the first and the last entry of the maximum value in the array.
//Example
//{4, 100!, 3, 4}          result = 0
//{ 5, 50!, 50!, 4, 5}     result = 1
//{ 5, 350!, 350, 4, 350!} result = 3
//{ 10!, 10, 10, 10, 10!}  result = 4

static int findDistanceBetweenMaxValueFirstAndLastEntry (int[] nums)
{
    int max = nums[0];
    int indexOfMax = 0;
    int indexOfMaxLastEntry = 0;

    for (int i = 1; i < nums.Length; i++)
    {
        if(nums[i] > max)
        {
            max = nums[i];
            indexOfMax = i;
            indexOfMaxLastEntry = i;
        } else if(nums[i] == max)
        {
            indexOfMaxLastEntry = i;
        }
    }

    return indexOfMaxLastEntry - indexOfMax;
}

//Task 3
//In a predetermined two-dimensional integer array (square matrix) matrix insert 0 into elements to the left side of the main diagonal, and 1 into elements to the right side of the diagonal.
//Example
//{{ 2, 4, 3, 3},          {{ 2, 1, 1, 1},
// { 5, 7, 8, 5},    =>     { 0, 7, 1, 1},          
// { 2, 4, 3, 3},           { 0, 0, 3, 1},
// { 5, 7, 8, 5}}           { 0, 0, 0, 5}}

static void transformTwoDimensionalArray(int[][] nums)
{
    int diagonalElementIndexBase = 0;

    for (int i = 0; i < nums.Length; i++)
    {
        for(int j = 0; j < nums[i].Length; j++)
        {
            if(j < diagonalElementIndexBase)
            {
                nums[i][j] = 0;
            } else if (j > diagonalElementIndexBase)
            {
                nums[i][j] = 1;
            }
        }

        diagonalElementIndexBase++;
    }
}