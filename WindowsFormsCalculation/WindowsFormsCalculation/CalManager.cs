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

                IList tokenStack = makeTokens(data);
                
                //후위 표기식으로 변환
                tokenStack = convertPostOrder(tokenStack);
                Stack<object> calcStack = new Stack<object>();
                
                //후위 표기식 계산
                foreach (object value in tokenStack)
                {
                    calcStack.Push(value);
                    calcPostOrder(calcStack);
                }
                //값이 없으면 에러
                if (calcStack.Count != 1)
                {
                    throw new Exception("계산 에러");
                }
                return (decimal)calcStack.Pop();
            }
            catch(Exception e)
            {
                return (decimal)0;
            }

        }
        public IList makeTokens(string value)
        {
            IList tokenList = new ArrayList();
            StringBuilder numberTokenBuffer = new StringBuilder();
            StringBuilder wordTokenBuffer = new StringBuilder();
            //문자열을 char형으로 쪼갠다.
            char[] arrayToken = value.ToCharArray();
            foreach (char token in arrayToken)
            {
                if (!isOperation(token))
                {
                    //분할 문자가 숫자일 경우
                    //문자 버퍼에 데이터가 있으면 일단 리스트에 집어넣기
                    setWord(tokenList, wordTokenBuffer);
                    numberTokenBuffer.Append(token);
                }
                else
                {
                    //분할 문자가 문자일 경우
                    //숫자 버퍼에 데이터가 있으면 일단 리스트에 집어넣기
                    setNumber(tokenList, numberTokenBuffer);
                    if (setOperation(tokenList, token))
                    {
                        continue;
                    }
                    //문자 연산자일경우 버퍼에 넣는다.
                    wordTokenBuffer.Append(token);
                    //문자 버퍼의 단어가 const에 선언된 연산자에 있는지 체크
                    setWord(tokenList, wordTokenBuffer);
                }
            }
            //남아있는 버퍼에 리스트에 담기
            setNumber(tokenList, numberTokenBuffer);
            setWord(tokenList, wordTokenBuffer);
            return tokenList;
        }
        public bool isOperation(string token)
        {
            return containWord(token, operator2);
        }

        /// 문자열이 숫자인지 문자인지 구분하는 함수
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
       
        /// 토큰을 Decimal형식으로 변환하는 함수
        public void setNumber(IList tokenList, StringBuilder tokenBuffer)
        {
            if (tokenBuffer.Length > 0)
            {
                string buffer = tokenBuffer.ToString();
                tokenBuffer.Clear();
                tokenList.Add(decimal.Parse(buffer));
            }
        }
        
        /// 토큰을 String형식으로 변환하는 함수
        public void setWord(IList tokenList, StringBuilder tokenBuffer)
        {
            if (tokenBuffer.Length > 0)
            {
                string buffer = tokenBuffer.ToString();
            }
        }

        /// 문자 연산자 입력 함수
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

        /// 연산자 체크 함수
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

        public IList convertPostOrder(IList tokenStack)
        {
            IList postOrderList = new ArrayList();
            Stack<string> exprStack = new Stack<string>();
            Stack<string> wordStack = new Stack<string>();
            foreach (object token in tokenStack)
            {
                // 숫자인지 문자인지 판별
                if (typeof(decimal).Equals(token.GetType()))
                {
                    //숫자면 그대로 입력
                    postOrderList.Add(token);
                }
                else
                {
                    //연산자 처리
                    exprAppend(postOrderList, (string)token, exprStack, wordStack);
                }
            }
            string item = string.Empty;
            //남은 연산자가 있을 경우 입력하기
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
            //기호 연산자 처리
            if (operator1[0].Equals(token))
            {
                //왼쪽 괄호[(] 처리
                exprStack.Push(token);
            }
            else if (operator1[1].Equals(token))
            {
                //오른쪽 괄호[)] 처리
                string oper = string.Empty;
                while (true)
                {
                    //문자 스택이 없을 때까지
                    if (wordStack.Count > 0)
                    {
                        //기호를 스택에서 가져온다.
                        oper = exprStack.Pop();
                        //왼쪽 괄호 [(]를 만나면 종료
                        if (operator1[0].Equals(oper))
                        {
                            oper = wordStack.Pop();
                            postOrderList.Add(oper);
                            break;
                        }
                        //스택 순서로 후위 계산 리스트에 값을 넣는다.
                        postOrderList.Add(oper);
                    }
                    else
                    {
                        //연산 스택이 없으면 종료
                        if (exprStack.Count < 1)
                        {
                            break;
                        }
                        oper = exprStack.Pop();
                        //왼쪽 괄호 [(]를 만나면 종료
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
                //콤마 [,] 처리
                if (wordStack.Count < 1)
                {
                    throw new Exception("데이터 형식 에러");
                }
                string oper = string.Empty;
                while (true)
                {
                    //연산 스택이 없으면 종료
                    if (exprStack.Count < 1)
                    {
                        break;
                    }
                    string buffer = exprStack.Pop();
                    exprStack.Push(buffer);
                    //왼쪽 괄호 [(]를 만나면 종료
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
                //연산자 처리
                string oper = string.Empty;
                while (true)
                {
                    // 연산자 스택에 연산자가 없으면 그대로 등록
                    if (exprStack.Count == 0)
                    {
                        exprStack.Push(token);
                        break;
                    }
                    // 연산자 POP
                    oper = exprStack.Pop();
                    //연산자 순위 비교
                    if (exprOrder(oper) <= exprOrder(token))
                    { 
                        //exprStack.Push(token);
                        exprStack.Push(oper);
                        exprStack.Push(token);
                        break;
                    }
                    postOrderList.Add(oper);
                }
            }
        }
        
        /// 계산 우선순위 레벨 반환
        public int exprOrder(string value)
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

        /// 후위 계산 함수
        public void calcPostOrder(Stack<object> calcStack)
        {
            //스택 가장 위의 값을 계산
            object buffer = calcStack.Pop();
            //수일 경우는 스택넘기기
            if (typeof(decimal).Equals(buffer.GetType()))
            {
                calcStack.Push(buffer);
                return;
            }
            //문자일 경우 계산한다.
            decimal num1 = 0;
            decimal num2 = 0;
            string oper = string.Empty;
            //연산자 포함 스택에 최소 2개 이상
            if (calcStack.Count >= 2)
            {
                //버퍼는 연산자
                oper = (string)buffer;
                //그 다음값은 수
                num2 = (decimal)calcStack.Pop();
                num1 = (decimal)calcStack.Pop();
             
                decimal result = calculateByOperator(num1, num2, oper);
                calcStack.Push(result);
            }
        }

        public decimal calculateByOperator(decimal num1, decimal num2, string oper)
        {
            if (oper == string.Empty)
            {
                throw new NullReferenceException("Operator null Error");
            }
            //더하기
            if (operator2[0].Equals(oper))
            {
                return num1 + num2;
            }
            //빼기
            if (operator2[1].Equals(oper))
            {
                return num1 - num2;
            }
            //곱하기
            if (operator2[2].Equals(oper))
            {
                return num1 * num2;
            }
            //나누기
            if (operator2[3].Equals(oper))
            {
                return num1 / num2;
            }
            throw new Exception("계산식이 없습니다.");
        }
    }
}

