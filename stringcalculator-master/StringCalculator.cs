
using Xunit.Sdk;

namespace StringCalculator;

public class StringCalculator
{

    public int Add(string numbers)
    {
        if (numbers == "")
        {
            return 0;
        }
        else if (numbers.Contains("\n"))
        {
            var numsNewLine = numbers.Split("\n");
            var numsCommas = numsNewLine;
            foreach (var num in numsNewLine){
                if (num.Contains(","))
                {
                    numsCommas = num.Split(",");
                }
            }
            ;

            var sum = numsCommas.Select(int.Parse).Sum() + numsNewLine.Select(int.Parse).Sum();

            return sum;
        }
        else if (numbers.Contains(","))
        {
            var nums = numbers.Split(',');
            var sum = nums.Select(int.Parse).Sum();
            
            return sum;
        }
        else 
        {
            return int.Parse(numbers);
        }
        
    }
}
