using System;
using System.Collections.Generic;
using System.Linq;
using DotnetIteration.Models;

namespace DotnetIteration
{

    public static class Iteration
    {
        /*
           Welcome to Interation

           In each method below you will see instructions that detail the requirements
           the method must implement to make the test pass.

           To start on a method comment out, or remove, the line
           `throw new System.NotImplementedException();`

           As you write and save your code, you can look in your terminal where you
           ran `dotnet watch test` to see if your code is working. The tests
           continuously check your work each time you save. If a test is failing
           you have not yet completed that method. Once you finish a method and have
           it correct, the test will tell you how the next method is working.
        */


        //  
        // 1) Complete the method named `yelling` that takes a list of
        //    words as an argument and returns a new list with all
        //    the words forced to uppercase.
        //
        public static IEnumerable<string> Yelling(List<string> words)
        {
            var yellingWords = words.Select(word => word.ToUpper());
            return yellingWords;
            // throw new System.NotImplementedException();
        }


        // 
        // 2) Complete the method named `Double` that takes a list of
        //    numbers as an argument and returns a new list with all
        //    the numbers multiplied by 2.
        // 
        public static IEnumerable<int> Double(List<int> numbers)
        {
            var multipliedBy2 = numbers.Select(number => number * 2);
            return multipliedBy2;
            //throw new System.NotImplementedException();
        }


        // 
        // 3) Complete the method `StringyIndexes` that takes a list of
        //    strings as an argument and returns a new list with each
        //    string suffixed with " is at index X" where X is the index
        //    of the element.
        // 
        public static IEnumerable<string> StringyIndexes(List<string> words)
        {
            var isAtIndex = words.Select((word, index) => $"{word} is at index {index}");
            return isAtIndex;
            // throw new System.NotImplementedException();
        }


        // 
        // 4) Complete the method OnlyTheEvenSurvive that accepts a list of
        //    numbers and returns only the elements that are even.
        // 
        public static IEnumerable<int> OnlyTheEvenSurvive(List<int> numbers)
        {
            var onlyEvens = numbers.Where(number => number % 2 == 0);
            return onlyEvens;
            //throw new System.NotImplementedException();
        }


        // 
        // 5) Complete the method OnlyTheEvenIndexedSurvive that accepts a
        //    list of numbers and returns only the elements at indexes that
        //    are even.
        // 
        public static IEnumerable<int> OnlyTheEvenIndexedSurvive(List<int> numbers)
        {
            var onlyIndexedEvens = numbers.Where((number, index) => index % 2 == 0);
            return onlyIndexedEvens;
            // throw new System.NotImplementedException();
        }


        // 
        // 6) Complete the method BestMoviesOfTheYear that accepts a list of
        //    movie objects AND a year and returns the names of movies that are
        //    from that year AND have a score more than 90.
        // 
        // A movie object looks like this:
        // 
        // new Movie() {
        //   Name: "Get Out",
        //   Year: "2017",
        //   Score: 99
        // }
        // 
        public static IEnumerable<string> BestMovieOfTheYear(List<Movie> movies, int yearToMatch)
        {
            var onlyTheBest = movies.Where(movie => movie.Year == yearToMatch && movie.Score > 90).Select(movie => movie.Name);
            return onlyTheBest;
            //throw new System.NotImplementedException();
        }


        // 
        // 7) Complete the method EveryoneIsOdd that accepts a list of
        //    numbers and returns true if every element of the list is odd.
        // 
        public static bool EveryoneIsOdd(List<int> numbers)
        {
            var areTheyOdd = numbers.All(number => number % 2 == 1);
            return areTheyOdd;
            //throw new System.NotImplementedException();
        }


        // 
        // 8) Complete the method FindTheNeedle that accepts a list of
        //    strings and returns the one string that contains the word
        //    `needle`.
        // 
        public static string FindTheNeedle(List<string> sentences)
        {
            var foundNeedle = sentences.Find(sentence => sentence.Contains("needle"));

            return foundNeedle;
            //throw new System.NotImplementedException();
        }


        // 
        // 9) Complete the method FindTheNeedleIndex that accepts a list of
        //    strings and returns the index of the string that contains
        //    the word `needle` inside.
        // 
        public static int FindTheNeedleIndex(List<string> sentences)
        {
            var needleIndex = sentences.FindIndex((sentence) => sentence.Contains("needle"));
            return needleIndex;
            //throw new System.NotImplementedException();
        }


        // 
        // 10) Complete the method SomeoneToLove that accepts a list of
        //     strings and returns true if at least one string is exactly
        //     four characters long.
        // 
        public static bool SomeoneToLove(List<string> words)
        {
            var anyFourCharacters = words.Any(word => word.Length == 4);
            return anyFourCharacters;

            //throw new System.NotImplementedException();
        }
    }
}
