# Modifying the Registry Recognition Rule - General
 
This tab allows you to manage the registry record definition used by a product recognition rule. Products are recognized by [Custom software product libraries](../../../../../../alvao-asset-management/software-management/custom-swlib).  
 It will be recognized by the items you specify. None of the items are mandatory.

> [!CAUTION]
> You cannot edit rules for products from the standard software library. 

  
Options:
 
- **Key Product Identification Record** -
 Enable if the rule is a software product recognition rule.  

 If you turn the option off, you are creating a **exclusive** rule,
 which does not recognize the product, but instead removes the record from the recognition process.
- **Product** - enter the product name.
- **Version** - enter the version of the product.
- **Version from** - enter the lower limit (lowest product version) that meets the condition - e.g. the value "5.1" means all versions from "5.1" onwards.
- **Version up to** - enter the upper limit (the highest version of the product) that meets the condition - e.g. the value "5.5" means all versions up to "5.5.255.255".
- **Language** - select the product language from the menu.
- **Publisher** - specify the manufacturer of the software product.
- **Path** - enter the registry key.
- **Comment** - enter a comment about the product.

> [!NOTE]
> You can use special SQL characters in input fields, e.g. "%" means a sequence of arbitrary characters.

 
### Links

- [Custom software product library](../../../../../../alvao-asset-management/software-management/custom-swlib)
