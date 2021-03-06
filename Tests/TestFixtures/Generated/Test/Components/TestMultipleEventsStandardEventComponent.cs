//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TestEntity {

    public MultipleEventsStandardEventComponent multipleEventsStandardEvent { get { return (MultipleEventsStandardEventComponent)GetComponent(TestComponentLookup.MultipleEventsStandardEvent); } }
    public bool hasMultipleEventsStandardEvent { get { return HasComponent(TestComponentLookup.MultipleEventsStandardEvent); } }

    public void AddMultipleEventsStandardEvent(string newValue) {
        var index = TestComponentLookup.MultipleEventsStandardEvent;
        var component = CreateComponent<MultipleEventsStandardEventComponent>(index);
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceMultipleEventsStandardEvent(string newValue) {
        var index = TestComponentLookup.MultipleEventsStandardEvent;
        var component = CreateComponent<MultipleEventsStandardEventComponent>(index);
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveMultipleEventsStandardEvent() {
        RemoveComponent(TestComponentLookup.MultipleEventsStandardEvent);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiInterfaceGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TestEntity : IMultipleEventsStandardEventEntity { }

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class TestMatcher {

    static Entitas.IMatcher<TestEntity> _matcherMultipleEventsStandardEvent;

    public static Entitas.IMatcher<TestEntity> MultipleEventsStandardEvent {
        get {
            if (_matcherMultipleEventsStandardEvent == null) {
                var matcher = (Entitas.Matcher<TestEntity>)Entitas.Matcher<TestEntity>.AllOf(TestComponentLookup.MultipleEventsStandardEvent);
                matcher.componentNames = TestComponentLookup.componentNames;
                _matcherMultipleEventsStandardEvent = matcher;
            }

            return _matcherMultipleEventsStandardEvent;
        }
    }
}
