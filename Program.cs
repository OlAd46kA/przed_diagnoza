// 1
using System.Collections.Generic;
Random r = new Random();
int euklidesModulo (int first, int second) {
    while (second > 0){
        int temp = second;
        second = first % temp;
        first = temp;
    }
    return first;
}

// 2
int euklidesOdejmowanie (int first, int second) {
    while (first != second) {
        _ = first > second ? first -= second : second -= first;
    }
    return first;
}

/*
int first = int.Parse(Console.ReadLine());
int second = int.Parse(Console.ReadLine());

Console.WriteLine($"modulo metoda euklidesa liczb {first} i {second} = {euklidesModulo(first, second)}");

Console.WriteLine($"modulo metoda odejmowania liczb {first} i {second} = {euklidesModulo(first, second)}");
*/

// 3
int[] bubbleSort(int[] array) {
    for (int i = 0; i < array.Length; i++) {
        for (int j = 0; j < array.Length - i - 1; j++) {
            if (array[j] > array[j + 1]) {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
    }
    return array;
}

/*
int[] testArray = new int[r.Next(1, 100)];
for (int i = 0; i < testArray.Length; i++) {
    testArray[i] = r.Next(1, 100);
}
Console.WriteLine("not sorted array");
foreach (int i in testArray) {
    Console.Write(i + " ");
}
Console.WriteLine();
Console.WriteLine("sorted");
bubbleSort(testArray);
foreach (int i in testArray) {
    Console.Write(i + " ");
}
*/
// 4
int sumadz (int n) {
    int sum = 0;
    for (int i = 1; i < n; i++) {
        if (n % i == 0) {
            sum += i;
        }
    }
    return sum;
}
/*
Console.WriteLine("Lista liczb zaprzyjaznionych");

for (int i = 1; i <= 10000; i++) {
    int temp = sumadz(i);
    if (i < temp && temp < 10000 && sumadz (temp) == i) {
        Console.WriteLine($"{i} : {temp}");
    }
}
*/

// 5
/*
int[] randomArray = new int[31];
List<int> resList = new List<int>();
for (int i = 0; i < randomArray.Length; i++) { randomArray[i] = r.Next (100, 1000); }

for (int i = 0; i < randomArray.Length; i++) {
    if (randomArray[i] % 17 == 0) {
        resList.Add(randomArray[i]);
    }
}
foreach (int n in resList) {
    Console.Write(n + " ");
}
Console.WriteLine();
Console.WriteLine($"ilosc tych liczb jest {resList.Count}");
*/

// 6
int length = int.Parse(Console.ReadLine());
int[,] matrix = new int[length, length];

int currentValue = 1;
for (int i = 0; i < length; i++) {
    for (int j = 0; j < length; j++) {
        matrix[i, j] = currentValue;
        currentValue++;
    }
}
for (int i = 0; i < length; i++) {
    for (int j = 0; j < length; j++) {
        Console.Write($"{matrix[i, j]} \t");
    }
    Console.WriteLine();
}

for (int frame = 0; frame < length / 2; frame++) {
    int frameSum = 0;

    for (int i = frame; i < length - frame; i++) {
        frameSum += matrix[frame, i];
        frameSum += matrix[length - 1 - frame, i];
        frameSum += matrix[i, frame];
        frameSum += matrix[i, length - 1 - frame];
    }

    Console.WriteLine($"suma ranmki {frame + 1}: {frameSum}");
}