using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCalculation
{
    class FileManager
    {
        // 파일 불러오기
        public string[] inputFile(string input)
        {
            string inputValue = input;
            string[] expression = new string[inputValue.Length];

            for (int i = 0; i < expression.Length; i++)
            {
                expression[i] = input[i].ToString();
            }
            string[] value = new string[expression.Length];
            int j = 0, k = 0;

            for (int i = 0; i < expression.Length; i++)
            {
                if (j == expression.Length || k == expression.Length)
                {
                    break;
                }
            }
            if (expression[j].Equals("-"))
            {
                if (j == 0)
                {
                    while (true)
                    {
                        value[k] += expression[j++];
                        if (expression[j].Equals("+") || expression[j].Equals("-") || expression[j].Equals("*") || expression[j].Equals("/") || expression[j].Equals("(") || expression[j].Equals(")"))
                        {
                            break;
                        }
                    }
                    k++;
                }
                //ex : 33+-5 or 33+-5+2
                else if (expression[j - 1].Equals("+") || expression[j - 1].Equals("-") || expression[j - 1].Equals("*") || expression[j - 1].Equals("/") || expression[j - 1].Equals("("))
                {
                    while (true)
                    {
                        value[k] += expression[j++];
                        if (j == expression.Length)
                        {
                            break;
                        }
                        if (expression[j].Equals("+") || expression[j].Equals("-") || expression[j].Equals("*") || expression[j].Equals("/") || expression[j].Equals("(") || expression[j].Equals(")"))
                        {
                            break;
                        }
                    }
                    k++;
                }
                else //- 는 빼기 기호.
                {
                    value[k++] = expression[j++];
                }
            }
            else if (expression[j].Equals("("))
            {
                value[k++] = expression[j++];
            }
            else if (expression[j].Equals(")"))
            {
                value[k++] = expression[j++];
            }
            else if (expression[j].Equals("+") || expression[j].Equals("-") || expression[j].Equals("*") || expression[j].Equals("/"))
            {
                value[k++] = expression[j++];
            }
            else
            {
                while (true)
                {
                    value[k] += expression[j++];
                    if (j == expression.Length) break;
                    if (expression[j].Equals("+") || expression[j].Equals("-") || expression[j].Equals("*") || expression[j].Equals("/") || expression[j].Equals("(") || expression[j].Equals(")"))
                    {
                        break;
                    }
                }
                k++;
            }
            int expCount = 0;
            try
            {
                for (int i = 0; i<value.Length; i++)
                {
                    if (value[i].Equals("") || value[i].Equals(" ")) break;
                    expCount++;
                }
            }       
            catch (Exception e)
            {

            }
            string[] res = new string[expCount];

            for (int i = 0; i<expCount; i++)
            {
                res[i] = value[i];
             }
            return res;
        }

     }
}
