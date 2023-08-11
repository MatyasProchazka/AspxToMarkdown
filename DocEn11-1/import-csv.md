# Import CSV
  
Use this form to load objects from a CSV file into the object tree. For the structure of the input CSV file, see [ImportUtil](../../../alvao-asset-management/import-export-data/import-util#csvstructure).
 
- **Input file** - Select the input CSV file from disk from which you want to load the objects. New objects will be created in the object tree as subobjects under the currently selected object in the tree.
- **Object kind** - if the input file does not contain a *Class* column (or *Type*), select the type of objects you want to create. If the input file contains a *Class* column (or *Species*), select the *&lt;all in input file&gt;* option or, if you want to read only rows for a specific object kind from the file, select the type.
- **Key columns** - select the columns in the input file that uniquely identify the objects. If an object already exists in the object tree with the same property values according to the key columns, a new object is not created in the tree, but only the values of the other loaded properties are updated in the existing object.
- **Extended**
    - **Search Discarded Assets** - if you enable this option, the assets in the [Discarded Assets](../../../alvao-asset-management/objects-and-properties/scrapped-asset) folder are also searched and updated during import.
    - **Format of date columns** - date format in text strings (e.g. dd/MM/yyyy). If not specified, the format is automatically detected when loaded. For a detailed description of the formats, see [Custom Date and Time Format Strings](https://msdn.microsoft.com/en-us/library/8kb3ddd4%28v=vs.110%29).

> [!NOTE]
> Date formats are governed by local language settings on the server.

    - **Column separator** - specify the column separator used in imported CSV file, e.g., comma (,) or semicolon (;).
- **Check** - check the content of the input file. Any deficiencies will be written to the form.
- **Read** - load objects from the input file into the object tree.
