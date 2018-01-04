using TreehouseDefense;
using Xunit;

namespace TreehouseDefenseTest.Test
{
    public class MapLocationTests
    {
        [Fact()]
        public void ShouldThrowIfNotOnMap()
        {
            var map = new Map(3, 3);
            var exception = Assert.Throws<OutOfBoundsException>(() => new MapLocation(3, 3, map));
        }


        [Fact()]
        public void InRangeOfWidthRange1()
        {
            var map = new Map(3, 3);
            var target = new MapLocation(0, 0, map);
            Assert.True(target.InRangeOf(new MapLocation(0,1,map),1));
        }
    }
}
