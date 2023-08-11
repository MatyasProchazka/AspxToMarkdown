# Object icons
   
On this page you can manage object icons and also property icons (which are only displayed in the AM Console). While the [WebApp](../../../../alvao-asset-management/webApp) uses vector icons in SVG format, the [AM Console](../../../../alvao-asset-management/console) displays raster icons in BMP format.
   
Options:
   
- **Command Panel**
    - **New Icon** - create a new icon. First, prepare an icon file in SVG vector format. You can use one of the freely available icons, e.g. from [https://www.flaticon.com](https://www.flaticon.com), or draw your own icon in a graphical editor, e.g. [INKSCAPE](https://inkscape.org/). Then use this command to upload the file to Alvao. A raster version of the icon is automatically generated from the vector icon.  

> [!NOTE]
> If you want to use an icon other than the generated raster icon, select both SVG and BMP files when uploading. If you want to use only the raster icon, select only the BMP file. The WebApp will then display the default object icon. The raster icon must be 16x16 pixels and have a color depth of 24 bits. The white color (R=255, G=255, B=255) is considered transparent.

    - **Edit** - edit the selected icon.
    - **Remove** - remove selected icons. It is only possible to remove custom icons that are not used. System icons cannot be removed.
    - **Download** - save selected icons to a ZIP file. You can then edit the icon files in the graphical editor and use the *Edit* command to upload them back to the corresponding icons in Alvao, or upload them to another Alvao instance as new icons using the *New Icon* command.
- **Icon table** - contains all icons and their selected attributes. You can [customize the table as needed](../../../../alvao-asset-management/working-with-tables).

> [!NOTE]
> Icons may be stored in memory and therefore a change may not be immediately apparent. To update in *AM Console* you need to restart it.
