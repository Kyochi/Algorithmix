using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Given a digit string, return all possible letter combinations that the number could represent.
namespace Algorithmix.BackTracking
{
    class LetterPhonecs
    {
        public List<string> letterCombinations(string A)
        {
            String[] phone = new String[10] { "0", "1", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
            String first = phone[(int)char.GetNumericValue(A[0])];
            List<String> r = new List<String>();
            foreach (char f in first)
            {
                String stres = "" + f;
                if (A.Length > 1)
                {
                    LetterPhonecs.build(r, stres, phone, A, 1, "");
                }
                else
                {
                    r.Add("" + f);
                }
            }
            return r;
        }
        public static void build(List<String> res, string B, string[] map, string call, int ind, String prec)
        {
            if (call.Length == ind) return;
            String choicemap = map[(int)char.GetNumericValue(call[ind])];
            String cur = prec;
            foreach (char letter in choicemap)
            {
                prec = cur + letter;
                if (ind == call.Length - 1)
                {
                    res.Add(B + prec);
                    prec = "";
                }
                else
                {
                    build(res, B, map, call, ind + 1, prec);
                }
            }
        }
    }
}
