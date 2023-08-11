# File Recognition Rule - General
 
This tab allows you to manage the file definition used by a product recognition rule. Products are recognized by [Custom software product libraries](../../../../../../alvao-asset-management/software-management/custom-swlib).  
 It will be recognized by the data you enter.

> [!CAUTION]
> You cannot modify rules for products from the standard software library.

 
Options:

- **Key product identification file** -
 Enable if the rule is a software product recognition rule.  

 If you turn the option off, you are creating a **selection rule**,
 which does not recognize the product, but instead excludes the file from the recognition process.
- **File name** - enter the name of the file.
- **File extension** - enter the file extension.
- **File Size** - enter the file size in bytes.
- **Company** - enter the name of the product publisher.
- **Product Name** - enter the name of the product name.
- **Language** - select the product language from the menu.
- **Product Version** - enter the product version.
- **Product version from** - enter the lower limit (lowest product version) that meets the condition - e.g. the value "5.1" means all versions from "5.1" onwards.
- **Product version up to** - enter the upper limit (highest product version) that meets the condition - e.g. a value of "5.5" means all versions up to "5.5.255.255".
- **File Version** - detect by file version
- **File version from** - specify file version.
- **File version to** - enter the lowest file version number - the bottom value of the interval.
- **Original File Name** - enter the highest file version number - the upper value of the interval.
- **Internal Name** - enter the internal name.
- **Comments** - enter a comment.
- **File Description** - enter a description of the file.

> [!NOTE]
> You can use special SQL characters in input fields, e.g. "%" means a sequence of arbitrary characters.
