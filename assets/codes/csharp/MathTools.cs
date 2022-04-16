using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace ColorBall.Mod
{
    public class MathTools
    {
        public static int Random(int starNum, int endNum)
        {
            byte [] randomBytes = new byte[4];
            RNGCryptoServiceProvider rngProvider = new RNGCryptoServiceProvider();
            rngProvider.GetBytes(randomBytes);
            Int32 iSeed = BitConverter.ToInt32(randomBytes, 0);
            Random random = new Random(iSeed);
            return random.Next(starNum, endNum + 1);
        }

        public static bool IsParameterValid(int startNum, int endNum, int needCount)
        {
            if (startNum < 0 || endNum <0 || startNum > endNum || needCount == 0 || needCount > endNum - startNum + 1)
            {
                return false;
            }
            return true;
        }

        public static List<int> PickMethod1(int startNum, int endNum, int needCount)
        {
            if (!IsParameterValid(startNum, endNum, needCount))
            {
                return null;
            }
            List<int> posList = new List<int>();
            List<int> newPosList = new List<int>();
            for (int i = 0; i <= endNum - startNum; i++)
            {
                posList.Add(i);
            }
            int count = 0;
            while (count < needCount)
            {
                int pickPos = Random(0, posList.Count -1);
                newPosList.Add(posList[pickPos]);
                posList.RemoveAt(pickPos);
                count++;
            }
            return newPosList;
        }

        public static List<int> PickMethod2(int startNum, int endNum, int needCount)
        {
            if (!IsParameterValid(startNum, endNum, needCount))
            {
                return null;
            }
            Hashtable tb = new Hashtable();
            while (tb.Count < needCount)
            {
                int pickPos = Random(0, endNum - startNum);
                if (!tb.ContainsKey(pickPos))
                {
                    tb.Add(pickPos, pickPos);
                }
            }
            List<int> posList = new List<int>();
            foreach (int key in tb.Keys)
            {
                posList.Add(key);
            }
            return posList;
        }
    }
}
