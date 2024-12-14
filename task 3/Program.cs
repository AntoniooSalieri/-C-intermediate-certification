//Задача 3*
//Задача 1: Заполните спирально квадратный массив по возрастанию, с заданным размером.

class Program
{
    /// <summary>
    /// the function fills the array with a sequence of numbers, in increasing order
    /// </summary>
    /// <param name="arr">two-dimensional array filled with zeros</param>
    /// <param name="line">used for recursion, do not enter</param>
    /// <param name="position">used for recursion, do not enter</param>
    /// <param name="side">used for recursion, do not enter</param>
    /// <param name="number">used for recursion, do not enter</param>
    /// <param name="times">used for recursion, do not enter</param>
    static public void FillArr (int[,] arr, int line = 0 , int position = 0, int side  = 0, int number = 1, int times = 0){

    if (arr[arr.GetLength(0)/2, arr.GetLength(1)/2 - 1] == 0 ||         //блок отвечает за проверку заполненности массива
    arr[arr.GetLength(0)/2, arr.GetLength(1)/2] == 0){


        if (times < number)                                             //блок отвечает за перебор последовательности чисел
        {
            times ++;
        }
        else
        {
            number++;
            times = 1;
        }
        arr[line, position] = number;


                                                                        //рекурсивное заполнение массива последовательностью
        if (side == 0){

            if (position + 1 < arr.GetLength(1) && arr[line, position + 1] == 0){
                    arr[line, position] = number;
                    FillArr(arr, line, position+1, side, number, times);
            }
            else{
                times--;
                FillArr(arr, line, position, 1, number, times);
            }

        }
        if (side == 1){

            if (line + 1 < arr.GetLength(0) && arr[line + 1, position] == 0){
                    arr[line, position] = number;
                    FillArr(arr, line+1, position, side, number, times);
            }
            else{
                times--;
                FillArr(arr, line, position, 2, number, times);
            }

        }
        if (side == 2){

            if (position > 0 && arr[line, position - 1] == 0){
                    arr[line, position] = number;
                    FillArr(arr, line, position - 1, side, number, times);
            }
            else{
                times--;
                FillArr(arr, line, position, 3, number, times);
            }

        }
        if (side == 3){
            if (line > 0 && arr[line - 1, position] == 0){
                    arr[line, position] = number;
                    FillArr(arr, line - 1, position, side, number, times);
                }
            else{
                times--;
                FillArr(arr, line, position, 0, number, times);
            }
        }
    }
}
    
    /// <summary>
    /// fills the array with zeros
    /// </summary>
    /// <param name="arr"></param>
    static public void PrepearArray(int[,] arr){
        for (int i = 0; i < arr.GetLength(0); i++){
            for (int j = 0; j < arr.GetLength(1); j++){
            arr[i, j] = 0;
            }
        }
    }

    /// <summary>
    /// prints the array to the console
    /// </summary>
    /// <param name="arr"></param>
    static public void PrintArray(int[,] arr){
        for (int i = 0; i < arr.GetLength(0); i++){
            for (int j = 0; j < arr.GetLength(1); j++){
            Console.Write($"{arr[i, j]} ");
            }
        Console.WriteLine();
        }
    }

    static void Main()
    {
        int [,] testArray = new int[7, 7];
        PrepearArray(testArray);
        FillArr(testArray);
        PrintArray(testArray);
    }

}


