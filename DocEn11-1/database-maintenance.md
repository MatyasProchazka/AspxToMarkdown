# Database maintenance
   
Options:
   
- **Refresh data for reports** - add columns representing new [database views](../../../alvao-asset-management/implementation/customization/database#view-list) in the *Query* schema, which are for data analysis and reporting, to the [custom fields](../../../alvao-service-desk/implementation/custom-items) of requests and new [properties](../../../alvao-asset-management/objects-and-properties) of objects. This update does not need to be done before each analysis or report, but only after adding new custom fields or properties.
- **Optimize Performance** - Update statistics and defragment indexes in the database and remove temporary data. This operation is performed [regularly automatically](../../../alvao-asset-management/implementation/installation/maintenance).
  Use this command only if the database performance has dropped and the Alvao system is slowed down.  

> [!CAUTION]
> 

> [!NOTE]
> - **Repair Database**- Recalculate precomputed values in the database, such as auxiliary tables of language localizations, paths in the object tree (AM), object names generated from property values (AM), etc. This command is for emergency situations only and does not need to be run regularly.
