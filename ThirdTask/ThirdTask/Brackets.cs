using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTask {
    class Brackets {

        public static Int32 CheckBracketPlacement(String line) {        //-1 если все в порядке или номер символа в строке, где была обнаружена несостыковка
            Int32 indexInStr = 0;

            if (ToCheckInLine(ref indexInStr, line, ' '))
                return -1;
            else
                return indexInStr - 2;
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
                            if (index < str.Length)
                                flag = ToCheckInLine(ref index, str, '(');
                            else
                                flag = false;
                        }
                        else if (str[index] == '[') {
                            index++;
                            if (index < str.Length)
                                flag = ToCheckInLine(ref index, str, '[');
                            else
                                flag = false;
                        }
                        else if (str[index] == ')' || str[index] == ']') {
                            index++;
                            flag = false;
                        }

                        index++;
                    }
                    break;
                }
            }
            return flag;
        }
    }
}
