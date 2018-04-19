/**
 * Definition of TreeNode:
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left, right;
 *     public TreeNode(int val) {
 *         this.val = val;
 *         this.left = this.right = null;
 *     }
 * }
 */


public class Solution {
    /**
     * This method will be invoked first, you should design your own algorithm 
     * to serialize a binary tree which denote by a root node to a string which
     * can be easily deserialized by your own "deserialize" method later.
     */
    public String serialize(TreeNode root) {
        // write your code here
        String results = new String();
        if(root == null){
            return "{}";
        }
        results += "{";
        Queue<TreeNode> queue = new LinkedList<>();
        Queue<String> res = new LinkedList<>();
        queue.offer(root);
        res.offer(root.val+"");
        
        while(!queue.isEmpty()){
            
            //String currentLevel = new String();

            TreeNode node = queue.poll();
            //currentLevel += node.val+",";
            if(node.left!=null){
                queue.offer(node.left);
                res.offer(node.left.val+"");
            }else{
                //queue.offer(null);
                res.offer("#");
            }
            if(node.right!=null){
                queue.offer(node.right);
                res.offer(node.right.val+"");
            }else{
                res.offer("#");
            }
            
            
            //results += currentLevel;
            
        }
        
        
        while(!res.isEmpty()){
            results+=res.poll()+",";
        }
        
        results = results.substring(0,results.length()-1)+"}";
        return results;
    }

    /**
     * This method will be invoked second, the argument data is what exactly
     * you serialized at method "serialize", that means the data is not given by
     * system, it's given by your own serialize method. So the format of data is
     * designed by yourself, and deserialize it here as you serialize it in 
     * "serialize" method.
     */
    public TreeNode deserialize(String data) {
        // write your code here
         
        if(data == null || data == "{}"){
            return null;
        }
        
        String[] elements = data.substring(1,data.length()-1).split(",");
        List<TreeNode> queue = new ArrayList<>();
        TreeNode root = new TreeNode(Integer.parseInt(elements[0]));
        queue.add(root);
        boolean isLeftChild = true;
        int index = 0;
        for(int i=1; i< elements.length; i++){
            if(!elements[i].equals("#")){
                TreeNode node = new TreeNode(Integer.parseInt(elements[i]));
                if(isLeftChild){
                    queue.get(index).left = node;
                }else{
                    queue.get(index).right = node;
                }
                queue.add(node);
            }
            if(!isLeftChild){
                index++;
            }
            
            isLeftChild=!isLeftChild;
            
            
        }
        
        return root;
        
        
    }
    

    

}