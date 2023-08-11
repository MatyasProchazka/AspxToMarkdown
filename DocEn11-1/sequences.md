# Number sequences
     
Each document in the records should have a unique designation. When entering a document into the register, you can enter its designation manually or have it automatically generated.
     
Media can be marked similarly to documents, see [Media](../software-management/licenses#media).
     
Number series are used to automatically generate labels. The **Tools - Lists - Numeric Sequences** command opens the [Numeric Sequences](../../list-of-windows/alvao-asset-management-console/tools/lists/numeric-sequences) window on the screen. The list in the window contains the numeric sequences of the tagging:
     
- invoices
- transfer reports
- media
- documents
- certificates
- licensing arrangements
- contracts

When you double-click on an item, the [Edit Numeric Sequence](../../list-of-windows/alvao-asset-management-console/tools/lists/numeric-sequences/numeric-sequence) window opens, where you can enable or disable the use of the sequence and change its settings.
     
Each numeric sequence generates a label in the format:
     
*pppnnnsss*
     
where:

- *ppp* is a prefix
- *pnnn* is a number
- *sss* is a suffix

You can specify the prefix and suffix arbitrarily, or leave them blank. The number series setting is used to specify the number that will be used for the next generated label.
     
**Example 1. Number Series**
     
Setting the number series for invoices:

- Prefix: *"f-"*
- Additional number: *"56"*
- Prefix: *"/04"*

With this setup, the next invoice entered will have the designation f-56/04. The next one after that will be marked f-57/04, etc.
