# Description of XML object export
      
The tree structure in Asset management can be exported to XML format. Below you can find a description of the individual tags (entities) that are used in the structure.
     
- ICONLIST - a list of icons including the binary form
    - ICON - icon
        - UID - unique identifier of system icons
        - DATE - binary icon data (24-bit BMP without FILEHEADER)
- KINDLIST - list of property definitions
    - KIND - property definition
        - NAME - name
        - ICON - icon name
        - ORDER - order
        - FLAGS - bitmap of property attribute settings, (0x0002=uses list of values, 0x0020=inherited, 0x1000=unique,0x2000=selection only)
        - VALUELIST - list of static values
        - VALUEKINDID - name of the property from which the list of values is shared
            - VALUE - value in the list of values
        - UNIQUE - unique
        - GLOBALSCOPE - global across all objects
        - SELECTONLY - selection only
        - ACCOUNTING - accountant role can edit values
        - CLEANVALUEBYCOPYING - delete value when copying an object
- NODE - object in tree
    - NAME - name in the tree
    - ICON - icon name
    - CLASSID - object kind ID
    - CLASS - object kind
    - HIDDEN - system object
    - STATE - bitmap of object attribute settings (0x16=hidden object)
    - AUTOUPDATE - automatically update according to detection
    - IGNOREDIFFERENCES - ignore differences against registration
    - PROPLIST - list of object properties
        - PROP - property
            - VALUE - value
            - KIND - property type
            - STATE - bitmap of property attributes (0x10=determine name in tree, 0x40=inherit property)
            - NAMEORDER - order in the object name
            - INHERITABLE - inherit property
    - HISTORYLIST - object history
        - HISTORY - one history record
            - DATE - date
            - DESC - description
            - USER - user
            - FLAGS - bitmap of flags (See chapter on [Alvao database](database)).
    - NODELIST - list of NODE child objects
    - SWLIST - list of installed software on the computer
        - SW - name of the installed product, attributes:
            - CAT - category (1=operating system)
            - TYPE - 1=commercial, 2=freeware, 3=shareware, 4=unspecified
            - LICNAME - the name of the license that covers the installation
            - SERIALNUM - license activation key
            - FROMPACK - the product is included in the package
            - INSTUSER - installed
            - INVNUM - license inventory number
            - INVOICE - invoice number of the purchased license
            - PARAM1 - product user field
            - PARAM2 - user field of the product
            - INSTDATE - installed
            - DETINSTDATE - installation detected
            - AUTHORIZED - approved installation
