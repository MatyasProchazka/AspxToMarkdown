# Unify Objects
   
In this Window, you can unify the property sets and icons of all objects of a certain type in the tree according to a selected [object template](../../../alvao-asset-management/implementation/object-templates).  As of Alvao 10.4, changes to an object template are automatically reflected in all existing objects of that type in the tree. In earlier versions, template changes were not automatically projected, and therefore objects of the same type may historically exist in the tree with different sets of properties or icons. You can use this command to explicitly unify existing objects.

> [!CAUTION]
> The object unification operation is irreversible.  

 
- **Add missing** - turn on if you want to add all properties from the template that are missing in the objects.  

  If an object already contains a property, its value is not changed.
- **Remove Excess** - turn on if you want to remove all properties from objects that are not in the template.
- **Unify property states** - turn on if you want to unify the [property states of objects](../tab-view/properties/property-edit) according to the selected template.
- **Unify object flags** - turn on if you want to unify [object flags](../edit/object/general)
  according to the selected template.
- **Unify object icons** - turn on if you want to unify object icons according to the selected template as well.

> [!NOTE]
> The operation can only be performed by users with the *Asset Management administrators* role.
