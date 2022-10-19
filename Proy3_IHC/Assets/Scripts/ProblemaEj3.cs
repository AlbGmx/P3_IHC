using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ProblemaEj3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start(){
        int[] nums = {-2, 1, -3, 4, -1, 2, 1, -5, 4};
        int maxSum = nums[0];
        int currentSum = nums[0];
        int start = 0;
        int end = 0;
        int currentStart = 0;
        for (int i = 1; i < nums.Length; i++){
            if (currentSum < 0){
                currentSum = nums[i];
                currentStart = i;
            }else{
                currentSum += nums[i];
            }
            if (currentSum > maxSum){
                maxSum = currentSum;
                start = currentStart;
                end = i;
            }
         }
        Debug.Log("Max sum: " + maxSum);
        Debug.Log("Start: Nums[" + start + "] = " + nums[start]);
        Debug.Log("End: Nums[" + end + "] = " + nums[end]);
    }
}
