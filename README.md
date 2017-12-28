# example-aspnet-xunit-testing
- https://xunit.github.io/docs/getting-started-desktop.html
- Install `xUnit` via Nuget
- Install `xUnit.Runner.VisualStudio` Nuget
- Click `add new project > search for xunit > xunit test project`
- Create the test, see `PointTests.cs`
- Add `TreehouseDefense` as a depedencies.
- Run test by going to `Test > Run All Test`
- `[Fact()]` = attribute for xUnit unit testing framework that says that the method is a unit test.

```csharp
using Xunit;

namespace TreehouseDefense.Tests
{
    public class MapTests
    {
        [Fact]
        public void OnMapTest()
        {
            var point = new Point(1,2);
            var map = new Map(5,5);
            
            if (map.OnMap(point))
            Assert.True(true, "Pass");
        }
    }
}

```
