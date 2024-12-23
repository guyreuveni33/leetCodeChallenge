public class Solution {
    public bool IsToeplitzMatrix(int[][] matrix){
        int counter=0;
        for(int j=0;j<matrix.GetLength(0)-1;j++){    
            for(int i=0;i<matrix.GetLength(0)-1;i++){
                if(matrix[i][i+counter]!=matrix[i+1][i+counter+1]){
                    return false;
                }
                counter++;
            }
        }
        return false;
    }}


class Program
{
    static void Main(string[] args)
    {
        Solution sol = new Solution();

        int[][] matrix = [[1, 2, 3, 4], [5, 1, 2, 3], [9, 5, 1, 2]];
            
        // Call the method and display the result
        Boolean result = sol.IsToeplitzMatrix(matrix);
        Console.WriteLine(result);
    }
}