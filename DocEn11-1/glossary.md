# Glossary
     
- **Agent** - an agent is an application (Win9x) or service (NT, 2000, XP, Vista, 7) running on a client computer and providing remote data collection, installation of software packages and communication with ALVAO Asset Management.
- **Inheritance** - see inherited property.
- **Uniqueness** - a property can be set to be unique. If uniqueness is enabled, then the *Uniqueness Check* feature can be used. This function will check if the selected property occurs with the same value multiple times and list the uniqueness violations for all properties that have been defined as such.
- **Classification property** - a property that specifies the type of object, e.g. "monitor", "processor", "room" etc. Every object must have this property. It implicitly serves as a classification property *Type*.
- **Tree Root**

            ![](glossary/Root.gif)
            
    An object that is located at the root of a tree, i.e. has no parent object.
- **Parent object**
- **Object** - An object is the basic building block of a tree database. Each object represents one node of the tree.  
An object consists of:
    - object name
    - icons
    - properties
    - notes
    - history records
    - child objects
- **Root object** - see tree root.
- **Child object**
- **Subtree**

            ![](glossary/Subtree.gif)

            A part of a tree including one specific object (the root of the subtree), its child objects, the child objects of the child objects, etc.
- **Object child** - one of the child objects or one of the child objects of the child objects, etc.
- **Object ancestor** - a parent object, a parent object of a parent object, etc.
- **Tree**

            ![](glossary/Tree.gif)

            A hierarchical structure composed of objects. Each object can have one or more child objects (sons) and at the same time be a child of another object (parent object, father).
- **Object Template** - a pattern by which new objects are created.
- **Property** - information that describes a particular characteristic of an object. Each object can be described by several properties, such as Size, Color.
- **Custom property** - a property that is part of the object (not inherited).
- **Inherited property**

            ![](glossary/Inh.gif)

            A property that is inherited into an object from one of its ancestors.
- **WMI** - Windows Management Instrumentation (WMI) is a system for managing system information based on a standardized object-oriented interface.
- **Tab** - At the bottom of the Properties and History windows are tabs that serve as filters.
