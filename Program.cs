public class ArrayProduct{
    private int[]? resultArray { get; set; }
    
    private int totalProduct;

    public int[] Execute(int[] inputArray){
        var arrayLenght = inputArray.Length;
        resultArray = new int[arrayLenght];
        totalProduct = 1;

       foreach(var n in inputArray){
            totalProduct *= n;
       }

       for(var i=0; i<inputArray.Length; i++){
            resultArray[i] = totalProduct / inputArray[i];
       }
       return resultArray;
    }
}


internal class Program
{
    private static void Main(string[] args)
    {
        var arrayProduct = new ArrayProduct();
        int[] array = {1, 2, 3, 4};

        var resultArray = arrayProduct.Execute(array);
        foreach(var n in resultArray){
            Console.WriteLine(n + " ");
        }
       
    }
}