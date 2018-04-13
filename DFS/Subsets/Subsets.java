public class Solution {
    /**
     * @param nums: A set of numbers
     * @return: A list of lists
     */
    public List<List<Integer>> subsets(int[] nums) {
        // write your code here
        List<List<Integer>> results = new ArrayList<>();
        List<Integer> subset = new ArrayList<>();
        if(nums == null){
            return null;
        }

        if(nums.length == 0){
            results.add(new ArrayList<Integer>());
            return results;
        }

        Arrays.sort(nums);




        recursion(nums, subset, 0, results);



        return results;
    }

    private void recursion( int[] nums,
                            List<Integer> subset,
                            int offset,
                            List<List<Integer>> results){


                            results.add(new ArrayList<Integer>(subset));

                            for(int i=offset; i<nums.length; i++){
                                subset.add(nums[i]);
                                recursion(nums, subset, i+1, results);
                                subset.remove(subset.size()-1);
                            }








                        }
}
