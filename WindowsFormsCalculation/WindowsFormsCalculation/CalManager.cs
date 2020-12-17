using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCalculation
{
    public class CalManager
    {
        public string[] operator1 = { "(", ")", "," };
        public string[] operator2 = { "+", "-", "×", "÷" };

        public decimal start(string data)
        {
            try
            {
                data = data.Replace(" ", string.Empty);
                data = data.Replace(",", string.Empty);
                data = data.Replace("*", "×");
                data = data.Replace("/", "÷");

                IList tokenStack = makeTokens(data);
                
                tokenStack = convertPostOrder(tokenStack);
                Stack<object> calcStack = new Stack<object>();
                
                foreach (object value in tokenStack)
                {
                    calcStack.Push(value);
                    calcPostOrder(calcStack);
                }
                if (calcStack.Count != 1)
                {
                    throw new Exception("계산 에러");
                }
                return (decimal)calcStack.Pop();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return (decimal)0;
            }

        }

        /// <summary>
        /// 토큰으로 변환하는 함수
        /// </summary>
        /// <param name="value">입력 문자열</param>
        /// <returns>각 토큰 별로 list로 반환</returns>
        public IList makeTokens(string value)
        {
            IList tokenList = new ArrayList();
            StringBuilder numberTokenBuffer = new StringBuilder();
            StringBuilder wordTokenBuffer = new StringBuilder();

            char[] arrayToken = value.ToCharArray();
            foreach (char token in arrayToken)
            {
                if (!isOperation(token))
                {
                    setWord(tokenList, wordTokenBuffer);
                    numberTokenBuffer.Append(token);
                }
                else
                {
                    setNumber(tokenList, numberTokenBuffer);
                    if (setOperation(tokenList, token))
                    {
                        continue;
                    }
                    
                    wordTokenBuffer.Append(token);
                    setWord(tokenList, wordTokenBuffer);
                }
            }
            
            setNumber(tokenList, numberTokenBuffer);
            setWord(tokenList, wordTokenBuffer);
            return tokenList;
        }
        public bool isOperation(string token)
        {
            return containWord(token, operator2);
        }

        /// <summary>
        /// 문자열이 숫자인지 문자인지 구분하는 함수
        /// </summary>
        /// <param name="token">char형 문자</param>
        /// <returns>true: 문자, false: 숫자</returns>
        public bool isOperation(char token)
        {
            if (token >= 48 && token <= 57 || token == 46)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// 토큰을 decimal형식으로 변환하는 함수
        /// </summary>
        /// <param name="tokenList">토큰 list</param>
        /// <param name="tokenBuffer">토큰 buffer</param>
        public void setNumber(IList tokenList, StringBuilder tokenBuffer)
        {
            if (tokenBuffer.Length > 0)
            {
                string buffer = tokenBuffer.ToString();
                tokenBuffer.Clear();
                tokenList.Add(decimal.Parse(buffer));
            }
        }

        /// <summary>
        /// 토큰을 string형식으로 변환하는 함수
        /// </summary>
        /// <param name="tokenList">토큰 list</param>
        /// <param name="tokenBuffer">토큰 buffer</param>
        public void setWord(IList tokenList, StringBuilder tokenBuffer)
        {
            if (tokenBuffer.Length > 0)
            {
                string buffer = tokenBuffer.ToString();
            }
        }

        /// <summary>
        /// 문자 연산자 입력 함수
        /// </summary>
        /// <param name="tokenList">토큰 list</param>
        /// <param name="token">토큰</param>
        /// <returns>문자 연산자이면 true, 아니면 false</returns>
        public bool setOperation(IList tokenList, char token)
        {
            string tokenBuffer = token.ToString();
            if (containWord(tokenBuffer, operator1) || containWord(tokenBuffer, operator2))
            {
                tokenList.Add(tokenBuffer);
                return true;
            }
            return false;
        }

        /// <summary>
        /// 연산자 체크 함수
        /// </summary>
        /// <param name="token">토큰 value</param>
        /// <param name="check">체크할 리스트</param>
        /// <returns></returns>
        public bool containWord(string token, string[] check)
        {
            if (string.Empty.Equals(token))
            {
                return false;
            }
            foreach (string word in check)
            {
                if (word.Equals(token))
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// 후위 표현식 변환
        /// </summary>
        /// <param name="tokenStack"></param>
        /// <returns></returns>

        public IList convertPostOrder(IList tokenStack)
        {
            IList postOrderList = new ArrayList();
            Stack<string> exprStack = new Stack<string>();
            Stack<string> wordStack = new Stack<string>();
            foreach (object token in tokenStack)
            {
                if (typeof(decimal).Equals(token.GetType()))
                {
                    postOrderList.Add(token);
                }
                else
                {
                    exprAppend(postOrderList, (string)token, exprStack, wordStack);
                }
            }
            string item = string.Empty;
            while (exprStack.Count != 0)
            {
                item = exprStack.Pop();
                postOrderList.Add(item);
            }
            while (wordStack.Count != 0)
            {
                item = wordStack.Pop();
                postOrderList.Add(item);
            }
            return postOrderList;
        }

        public void exprAppend(IList postOrderList, string token, Stack<string> exprStack, Stack<string> wordStack)
        {
            if (operator1[0].Equals(token))
            {
                exprStack.Push(token);
            }
            else if (operator1[1].Equals(token))
            {
                string oper = string.Empty;
                while (true)
                {
                    if (wordStack.Count > 0)
                    {
                        oper = exprStack.Pop();
                        if (operator1[0].Equals(oper))
                        {
                            oper = wordStack.Pop();
                            postOrderList.Add(oper);
                            break;
                        }
                        postOrderList.Add(oper);
                    }
                    else
                    {
                        if (exprStack.Count < 1)
                        {
                            break;
                        }
                        oper = exprStack.Pop();
                        if (operator1[0].Equals(oper))
                        {
                            break;
                        }
                        postOrderList.Add(oper);
                    }
                }
            }
            else if (operator1[2].Equals(token))
            {
                if (wordStack.Count < 1)
                {
                    throw new Exception("데이터 형식 에러");
                }
                string oper = string.Empty;
                while (true)
                {
                    if (exprStack.Count < 1)
                    {
                        break;
                    }
                    string buffer = exprStack.Pop();
                    exprStack.Push(buffer);

                    if (operator1[0].Equals(buffer))
                    {
                        break;
                    }
                    oper = exprStack.Pop();
                    postOrderList.Add(oper);
                }
            }
            else if (isOperation(token))
            {
                string oper = string.Empty;
                while (true)
                {
                    if (exprStack.Count == 0)
                    {
                        exprStack.Push(token);
                        break;
                    }
                    oper = exprStack.Pop();

                    if (exprOrder(oper) <= exprOrder(token))
                    { 
                        exprStack.Push(oper);
                        exprStack.Push(token);
                        break;
                    }
                    postOrderList.Add(oper);
                }
            }
        }

        /// <summary>
        /// 계산 우선순위 레벨 반환
        /// </summary>
        /// <param name="value">연산자</param>
        /// <returns></returns>
        public int exprOrder(string value)
        {
            try
            {
                if (value == string.Empty)
                {
                    throw new NullReferenceException();
                }
                int order = -1;
                if ("-".Equals(value) || "+".Equals(value))
                {
                    order = 0;
                }
                else if ("×".Equals(value) || "÷".Equals(value))
                {
                    order = 1;
                }
                return order;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }

        /// <summary>
        /// 후위 계산 함수
        /// </summary>
        /// <param name="calcStack">계산 스택</param>
        public void calcPostOrder(Stack<object> calcStack)
        {
            object buffer = calcStack.Pop();
            if (typeof(decimal).Equals(buffer.GetType()))
            {
                calcStack.Push(buffer);
                return;
            }
            decimal num1 = 0;
            decimal num2 = 0;
            string oper = string.Empty;

            if (calcStack.Count >= 2)
            {
                oper = (string)buffer;
                num2 = (decimal)calcStack.Pop();
                num1 = (decimal)calcStack.Pop();
             
                decimal result = calculateByOperator(num1, num2, oper);
                calcStack.Push(result);
            }
        }

        /// <summary>
        /// 계산 함수
        /// </summary>
        /// <param name="num1">수1</param>
        /// <param name="num2">수2</param>
        /// <param name="oper">연산자</param>
        /// <returns>결과 값</returns>
        public decimal calculateByOperator(decimal num1, decimal num2, string oper)
        {
            try
            {
                if (oper == string.Empty)
                {
                    throw new NullReferenceException("Operator null Error");
                }
                if (operator2[0].Equals(oper))
                {
                    return num1 + num2;
                }
                if (operator2[1].Equals(oper))
                {
                    return num1 - num2;
                }
                if (operator2[2].Equals(oper))
                {
                    return num1 * num2;
                }
                if (operator2[3].Equals(oper))
                {
                    return num1 / num2;
                }
                throw new Exception("계산식이 없습니다.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return (decimal)0;
            }
        }
    }
}

