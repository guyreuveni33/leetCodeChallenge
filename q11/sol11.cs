﻿public class Solution {
    public bool IsToeplitzMatrix(int[][] matrix) {
        int rows = matrix.Length;
        int cols = matrix[0].Length;

        for (int i = 0; i < rows - 1; i++) {
            for (int j = 0; j < cols - 1; j++) {
                if (matrix[i][j] != matrix[i + 1][j + 1]) {
                    return false;
                }
            }
        }

        return true;
    }
}