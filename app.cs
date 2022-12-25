// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


using System;
using System.Collections.Generic;
using System.Collections;

namespace hagar;

class Section
{
    private static void Main()
    {
        // Console.WriteLine("hello world");

        // Console.Write("enter your name : ");
        // var name = Console.ReadLine();
        // Console.WriteLine("hello "+name);


        // // The 13 tasks :-

        // //1) Reverse string
        // string str = "hagar1010";
        // string rev_str = "";
        // for (int i = str.Length - 1; i >= 0; i--)
        // {
        //     rev_str += str[i];
        // }
        // Console.WriteLine("Reverse of " + str + " is " + rev_str);



        // //2) Count of letter in string
        // int count = 0;
        // char letter = 'a';
        // for (int i = 0; i < str.Length; i++)
        // {
        //     if (str[i] == letter)
        //         count++;
        // }
        // Console.WriteLine("Count of repeat '" + letter + "' is " + count);



        // //3) Last index of letter in string
        // for (int i = str.Length - 1; i >= 0; i--)
        // {
        //     if (str[i] == letter)
        //     {
        //         Console.WriteLine("Last index of '" + letter + "' is " + i);
        //         break;
        //     }
        // }
        // //or
        // // Console.WriteLine("Last index of '" + letter + "' is " + str.LastIndexOf(letter));



        // //4) Remove letter from string
        // string removed = "";
        // for (int i = 0; i < str.Length; i++)
        // {
        //     if (str[i] != letter)
        //     {
        //         removed += str[i];
        //     }
        // }
        // Console.WriteLine("Removed '" + letter + "' from " + str + " is " + removed);
        // //or
        // //Console.WriteLine(str.Replace("a",""));



        // //5) Replace letter by letter in string
        // string replaced = "";
        // for (int i = 0; i < str.Length; i++)
        // {
        //     if (str[i] != letter)
        //     {
        //         replaced += str[i];
        //     }
        //     else
        //     {
        //         replaced += "0a";
        //     }
        // }
        // Console.WriteLine("Replaced '" + letter + "' into '0a' is " + replaced);
        // //or
        // //Console.WriteLine(str.Replace("a","0a"));



        // //6) Count of non-literals
        // int countOfNonliteral = 0;
        // for (int i = 0; i < str.Length; i++)
        // {
        //     if ((str[i] < 'a' || str[i] > 'z') && (str[i] < 'A' || str[i] > 'Z'))
        //     { //a=97, z=122, A=65, Z=90
        //         countOfNonliteral++;
        //     }
        // }
        // Console.WriteLine("Count of non literals is " + countOfNonliteral);
        // //or
        // // for (int i=0;i<str.Length;i++){
        // //     if(Char.IsDigit(str[i])){
        // //         countOfNonliteral++;
        // //         // Console.WriteLine(str[i]);
        // //     }
        // // }



        // //7) Is pallindrome?
        // string text = "level";
        // string fromEnd = "";
        // bool pall = false;
        // for (int i = text.Length - 1; i >= 0; i--)
        // {
        //     fromEnd += text[i];
        // }
        // if (text == fromEnd)
        // {
        //     pall = true;
        // }
        // if (pall)
        //     Console.WriteLine(text + " is pallindrome");
        // else
        //     Console.WriteLine(text + " is not pallindrome");
        // //or
        // // int i=0;
        // // int j=text.Length-1;
        // // for( ;i<j ; i++,j--){
        // //     if(text[i]!=text[j]){
        // //         pall=false;
        // //         break;
        // //     }else{
        // //         pall=true;
        // //     }
        // // }
        // // Console.WriteLine(pall);



        // //8) Number of item less than avrg
        // var arr = new double[] { -10, 5, 18, 2, 9, 4, 4, -5, -5, 0 }; //  22/10 = 2.2
        // int countLessAvrg = 0;
        // double avrg = 0;
        // double sum = 0;
        // for (int i = 0; i < arr.Length; i++)
        // {
        //     sum += arr[i];
        // }
        // avrg = sum / arr.Length;
        // for (int i = 0; i < arr.Length; i++)
        // {
        //     if (arr[i] < avrg)
        //     {
        //         // Console.WriteLine(arr[i]);
        //         countLessAvrg++;
        //     }
        // }
        // Console.WriteLine("Number of item less than avrg is " + countLessAvrg);



        // //9) Mean of min, max values
        // var values = new int[] { 1, 2, 2, 4, 5, 4, 7, 8, 7, 3, 6 };
        // float max = values[0];
        // float min = values[0];
        // for (int i = 1; i < values.Length; i++)
        // {
        //     if (values[i] < min)
        //         min = values[i];
        //     if (values[i] > max)
        //         max = values[i];
        // }
        // float mean = (min + max) / 2;
        // Console.WriteLine("Mean of min, max values is " + mean);



        // //10) First element greater than avg
        // var elements = new int[] { 2, 10, 7, 9, 2, 0 };  //avg=5
        // int avg = 0;
        // int sumition = 0;
        // int first = 0;
        // for (int i = 0; i < elements.Length; i++)
        // {
        //     sumition += elements[i];
        // }
        // avg = sumition / elements.Length;
        // // Console.WriteLine(avg);
        // for (int i = 0; i < elements.Length; i++)
        // {
        //     if (elements[i] > avg)
        //     {
        //         first = elements[i];
        //         break;
        //     }
        // }   
        // Console.WriteLine("First element greater than avrg is " + first);



        // //11) Earliest nearest value from mean
        // var new_arr = new List<int>();                         //***list because arr can't resize =)
        // for (int i = 0; i < elements.Length; i++)
        // {
        //     int compare=Math.Abs(avg-elements[i]); //avrg from task10 is 5
        //     // Console.WriteLine(compare);
        //     new_arr.Add(compare);                              //***list
        // }
        // int nearest = new_arr[0];//مهم
        // for(int i = 1; i < new_arr.Count; i++){                //***list
        //     if(new_arr[i] < nearest)
        //         nearest = i;
        // }  
        // Console.WriteLine("Earliest nearest value from mean is " + elements[nearest]);



        // //12) Missing Integer   **cute =)
        // int[] group = {1,2,3,4,6,7,8,9,10};     //(from 1 to 10 missing 5)
        // int miss=0;
        // for (int i = 0; i < group.Length-1; i++) {
        //     if(group[i]+1 != group[i+1]){
        //         miss=group[i]+1;
        //     }
        // }
        // Console.WriteLine("Missing number is " + miss);



        // //13) Remove duplicate
        // int[] arr1 = { 1, 2, 2, 4, 5, 4, 7, 8, 7, 3, 6 };
        // var numsList = new ArrayList();                                  // using System.Collections
        // for (int i = 0; i < arr1.Length; i++) {
        //     if (numsList.Contains(arr1[i]) == false) {                //contains is built-in method =)
        //         numsList.Add(arr1[i]);
        //     }
        // }
        // // Console.WriteLine(typeof(ArrayList));
        // var converted = numsList.ToArray();
        // for (int i = 0; i < converted.Length; i++) {
        //     if(converted[i] == converted[converted.Length-1]){
        //         Console.Write(converted[i]);
        //     }else{
        //         Console.Write(converted[i]+",");
        //     }
        // }
        // //or      (using LinQ method)
        // // int[] nums = { 1, 2, 2, 4, 5, 4, 7, 8, 7, 3, 6 };
        // // int[] dist = nums.Distinct().ToArray();
        // // for (int i = 0; i < dist.Length; i++) { 
        // //     Console.WriteLine(dist[i]); 
        // // }
        // //or      (after sorted)
        // // var arr1 =  new int[] { 1, 2, 2, 4, 5, 4, 7, 8, 7, 3, 6 } ;
        // // Array.Sort(arr1);
        // // var arr2 = new List<int>();
        // // int j=0;
        // // for (int i = 0; i < arr1.Length; i++) {
        // //     for ( ; j < arr2.Count; j++) {
        // //         if(arr1[i] == arr2[j]){
        // //             break;
        // //         }
        // //     }
        // //     if(j < arr2.Count){
        // //     }else{
        // //         arr2.Add(arr1[i]);
        // //     }   
        // // }
        // // for (int i = 0; i < arr2.Count; i++) {  //print arr2
        // //     Console.WriteLine(arr2[i]); 
        // // }



        //Questions in midterm
        // int a,b,c,x;
        // a=80;
        // b=15;
        // c=2;
        // x=a-b/(3*c)*(a+c);      //if priorty is equal then begin from left =)
        // Console.WriteLine(x);   //-84

        // int a,b;
        // a = (b = 10) + 5;
        // Console.WriteLine(a + "," + b);
    }
}
