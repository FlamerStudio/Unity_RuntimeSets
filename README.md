# Runtime Sets

Runtime Sets inspired by Unite Austin 2017 : Game Architecture with ScriptableObjects

Thanks to Ryan Hipple for this explanations.

Runtime Sets can be really useful for list objects references in ScriptableObjects.
You can see the conference for more details.

## Instructions 

Runtime Sets package contains 5 types of Generic Collections :
- RuntimeList
- RuntimeHashSet
- RuntimeQueue
- RuntimeStack
- RuntimeDictionnary

For begin, you need to create a new class that inherits from one of these 5 classes. And instantiate the new ScriptableObject in your assets folder.

```C#
[CreateAssetMenu(menuName = "RuntimeSets/Lists/CubeBehavior")]
public class RuntimeCubeBehaviorList : RuntimeList<CubeBehavior>
{
}
```

When the asset is created, you can specify the maxCount, if the list allows Duplicates objects. The maxCount is init to int.MaxCount per default.

You can access of the items with the Items property :
```C#
List<CubeBehavior> cubes = runtimeCubeList.Items; 
```
But the property returns a COPY of the List.
You need absolutely to pass by the implemented functions in Runtime Sets to modify the contents of the list.

Actions Events are now implemented. 
```C#
Action<T> BeforeAddItem;
Action<T> SuccessAddItem;
Action<T> BeforeRemoveItem;
Action<T> SuccessRemoveItem;
```

You can subscribe of these events.
BeforeRemoveItem event gets parameter null for RuntimeStack and RuntimeQueue. The item can't be got before the Dequeue() method;
