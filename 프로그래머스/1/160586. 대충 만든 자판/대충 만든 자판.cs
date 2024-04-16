using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(string[] keymap, string[] targets) {
        
        List<int>result = new List<int>();
        List<int> list = new List<int>();
        int sum = 0;
        
       for(int i=0;i<targets.Length;i++)
       {
           char[] arr = targets[i].ToCharArray();
           {
               for (int j=0;j<arr.Length;j++)
               {
                   for(int x=0;x<keymap.Length;x++)
                   {
                        int search = keymap[x].IndexOf(arr[j]); 
                       if (search!=-1)
                        {

                            list.Add(search + 1); 
                        }
                   }
                   if(list.Count==0)
                    {
                        sum = 0;
                        break;
                    }
                   
                  
                   if (list.Count>0) //1개 이상 있으면 
                   {
                       sum += list.Min(); //가장 작은(최소) 저장 
                       list.Clear();
                   }
                   
               }
               
               if(sum==0)
                {
                    result.Add(-1);
                }
               else
                {
                    result.Add(sum);
                }
               
               sum=0;
           }
       }
        if(result.All(x => x==-1))
        {
            result.Clear();
            result.Add(-1);
        }
        
        return result.ToArray();
        

    }
}