string[] GetWordsLenThree(string[] array) {
    int newArrLen = 0;
    foreach (string s in array) {
        if (s.Length <= 3) {
            newArrLen++;
        }
    }

    string[] newArr = new string[newArrLen];

    if (newArrLen > 0) {
        int index = 0;

        foreach (string s in array) {
            if (s.Length <= 3) {
                newArr[index] = s;
                index++;
            }
        }
    }  

    return newArr;
}

System.Console.WriteLine(String.Join(", ", GetWordsLenThree(new string[]{"Hello", "2", "word", ":-)"})));
System.Console.WriteLine(String.Join(", ", GetWordsLenThree(new string[]{"Russia", "Denmark", "Kazan"})));
System.Console.WriteLine(String.Join(", ", GetWordsLenThree(new string[]{"1234", "1567", "-2", "computer science"})));
