# Software detection detail

In this window you will find details about [software detection](../../../../../alvao-asset-management/implementation/detection#SW_det). Files are detected by information in [Software Product Library](../../../../../alvao-asset-management/software-management/custom-swlib). In the default file view, the window is divided into five parts (the registry view uses only the first three):

- **List of unrecognized files** (top) - displays files that have not been recognized by any rule.
- **Folder tree** (middle left) - view of the disk of the detected computer. If a folder is marked with a check mark, it means that there are detected files in the folder.
- **List of files in selected folder** (middle right) - view of files found in the folder that is currently selected in the folder tree. Files marked with a checkmark icon are recognized and have the name of the recognized software product listed in the **product** column.
- **Product List**(bottom left) - view products by category
    - *Found* - view all found software products.
    - *All* - view all available software products (this view is useful when designing your own recognition rules)
- **Rule List** (bottom right) - rules for recognizing the product that is currently selected in the product list. The list contains either only file rules or only registry rules, depending on the window view mode.

Options:

- [Edit](software/edit)
- [View](software/view)
- [Actions](software/actions)
- [Tools](software/tools)
