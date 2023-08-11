# Functions
      
## Total
      
The Sum function is used to sum the numeric values of the selected property for a set of objects. The set contains objects from the selected object subtree.
     
**Calculation flow:**  
         The function checks the objects from the lowest level in each branch of the selected subtree. When it encounters the first object in a given branch with the searched property, it adds the property value to the total result. It no longer counts all parent objects to that object in that branch.
     
**Recommended way to arrange objects:**  
         Place all objects whose properties you want to add at the same level in the tree below a parent.
     ![System Architecture](tree_soucet2.png)     

Example:

Sum up the prices of all components under the selected assembly.
     ![System Architecture](tree_soucet1.png)     
The following are included in the total price:
     
- Hard drive type 110
- Motherboard 110
- Monitor 1000

The resulting value will be 1220.
     
**Note:**  
         The number format does not support a thousands separator. Use a comma or period [,.] as the decimal separator .
