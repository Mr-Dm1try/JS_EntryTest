using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTask {
    class Brackets {

        public static Boolean CheckBracketPlacement(String line) {
            Int32 indexInStr = 0;          

            return ToCheckInLine(ref indexInStr, line, ' ');
        }

        private static Boolean ToCheckInLine(ref Int32 index, String str, char bracket) {
            Boolean flag = true;

            switch (bracket) {
                case '(': {
                    while (index < str.Length && str[index] != ')' && flag) {
                        if (str[index] == '(') {
                            index++;
                            flag = ToCheckInLine(ref index, str, '(');
                        }
                        else if (str[index] == '[') {
                            index++;
                            flag = ToCheckInLine(ref index, str, '[');
                        }
                        else if (str[index] == ']')
                            flag = false;

                        if (index == str.Length - 1)
                            flag = false;

                        index++;
                    }
                    break;
                }
                case '[': {
                    while (index < str.Length && str[index] != ']' && flag) {
                        if (str[index] == '(') {
                            index++;
                            flag = ToCheckInLine(ref index, str, '(');
                        }
                        else if (str[index] == '[') {
                            index++;
                            flag = ToCheckInLine(ref index, str, '[');
                        }
                        else if (str[index] == ')')
                            flag = false;

                        if (index == str.Length - 1)
                            flag = false;

                        index++;
                    }
                    break;
                }
                default: {
                    while (index < str.Length && flag) {
                        if (str[index] == '(') {
                            index++;
                            flag = ToCheckInLine(ref index, str, '(');
                        }
                        else if (str[index] == '[') {
                            index++;
                            flag = ToCheckInLine(ref index, str, '[');
                        }
                        else if (str[index] == ')' || str[index] == ']')
                            flag = false;

                        index++;
                    }
                    break;
                }
            }
            return flag;
        }
    }
}
